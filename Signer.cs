using SignaBSG.Resources.Colors;
using SignaBSG.Resources.Estilos;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms.PdfViewer;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace SignaBSG
{
    public partial class Signer : Form
    {
        private readonly string certificateP12;
        private readonly string certificatePassword;
        private readonly string documentPdf;
        private readonly string version;
        private Cursor firmaCursor;
        private System.Timers.Timer cursorTimer;

        // Constantes para mover el formulario
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public Signer(string certificateP12, string certificatePassword, string documentPdf,string version)
        {
            InitializeComponent();

            this.certificateP12 = certificateP12;
            this.certificatePassword = certificatePassword;
            this.documentPdf = documentPdf;
            this.version = version;

            ConfigurarFormulario();
            AplicarTemaVisual();
        }

        private void Signer_Load(object sender, EventArgs e)
        {
            label1_VersionApp.Text = $"SignaBG {this.version}";

            ConfigurarVisorPdf();



            firmaCursor = new Cursor(new MemoryStream(Properties.Resources.firmaCursor));

          
            pdfViewerControl1.Load(this.documentPdf);

            // Suscribirse al evento de clic del visor PDF
            pdfViewerControl1.PageClicked+= PdfViewer_PageClicked;
            cursorTimer = new System.Timers.Timer();
            cursorTimer.Interval = 100; // cada 100 ms
            cursorTimer.Tick += CursorTimer_Tick;
            cursorTimer.Start();


        }



        #region Event
        private void PdfViewer_PageClicked(object sender, PageClickedEventArgs args)
        {
            // Índice de página (0-based), lo convertimos a 1-based si quieres mostrarlo al usuario
            int pageNumber = args.PageIndex + 1;

            // Coordenadas reales dentro del documento PDF (en puntos)
            System.Drawing.PointF mousePosition = args.Position;

            // Mostrar coordenadas en el PDF
            MessageBox.Show(
                $"Página: {pageNumber}\n" +
                $"X: {mousePosition.X:F2}, Y: {mousePosition.Y:F2}",
                "Lugar de firma",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // 🔜 Aquí podrías guardar estas coordenadas para insertar una firma más adelante
        }

        #endregion


        #region Configuración de interfaz

        private void ConfigurarFormulario()
        {
            FormBorderStyle = FormBorderStyle.None;
            Text = string.Empty;
            DoubleBuffered = true;
        }

        private void AplicarTemaVisual()
        {
            if (Enum.TryParse(Properties.Settings.Default.TemaActual, out Tema tema))
            {
                if (tema == Tema.Sistema)
                    tema = TemaApp.DetectarTemaDelSistema();

                if (tema == Tema.Oscuro)
                    DarkMode.AplicarEstilo(this);
                else
                    LigthMode.AplicarEstilo(this);
            }
        }

        private void ConfigurarVisorPdf()
        {
            var toolbar = pdfViewerControl1.ToolbarSettings;

            toolbar.OpenButton.IsVisible = false;
            toolbar.SaveButton.IsVisible = false;
            toolbar.PrintButton.IsVisible = false;
            toolbar.SelectionButton.IsVisible = false;
            toolbar.PanButton.IsVisible = false;
            toolbar.FitPageButton.IsVisible = false;
            toolbar.FitWidthButton.IsVisible = false;

            pdfViewerControl1.IsBookmarkEnabled = false;
        }

        #endregion

        #region Eventos

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Ventana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void panel1_Ventana_Paint(object sender, PaintEventArgs e)
        {
            // Personalización visual si se desea.
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {
            // Reservado para futuras acciones en vista previa.
        }

        #endregion
    }
}
