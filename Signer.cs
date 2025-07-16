using SignaBSG.Resources.Colors;
using SignaBSG.Resources.Estilos;
using SignaBSG.Services;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms.PdfViewer;
using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SignaBSG
{
    public partial class Signer : Form
    {
        private readonly string certificateP12;
        private readonly string certificatePassword;
        private string documentPdf;
        private readonly string version;
        private int pageNumber;
        private float coordinateX;
        private float coordinateY;

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public Signer(string certificateP12, string certificatePassword, string documentPdf, string version)
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

            pdfViewerControl1.Load(this.documentPdf);

            pdfViewerControl1.PageClicked += PdfViewer_PageClicked;
        }



        private async Task EstamparFirma()
        {

           
            try
            {
                var pdfFirmadoBytes = await ApiRequest.FirmarPdfPost(
                    this.documentPdf,
                    this.certificateP12,
                    this.certificatePassword,
                    coordinateX,
                    coordinateY,
                    pageNumber
                );

                if (pdfFirmadoBytes == null)
                {
                    MessageBox.Show("La firma del PDF no se completó.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var directorio = Path.GetDirectoryName(this.documentPdf);
                var nombreArchivo = Path.GetFileNameWithoutExtension(this.documentPdf);
                var extension = Path.GetExtension(this.documentPdf);
                var rutaDestino = Path.Combine(directorio, $"{nombreArchivo}Signed{extension}");

                File.WriteAllBytes(rutaDestino, pdfFirmadoBytes);
               // pdfViewerControl1.Load(rutaDestino);

                MessageBox.Show($"PDF firmado y cargado correctamente en : {rutaDestino}");
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void PdfViewer_PageClicked(object sender, PageClickedEventArgs args)
        {
            pageNumber = args.PageIndex + 1;
            PointF mousePosition = args.Position;
            coordinateX = mousePosition.X;
            coordinateY = mousePosition.Y;

            MessageBox.Show(
                $"Página: {pageNumber}\n" +
                $"X: {mousePosition.X:F2}, Y: {mousePosition.Y:F2}",
                "Lugar de firma",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Ventana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private  async void button1_Click_1(object sender, EventArgs e)
        {
           await  EstamparFirma();
        }
    }
}
