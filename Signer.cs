
using Microsoft.VisualBasic.Logging;
using SignaBSG.Resources.Colors;
using SignaBSG.Resources.Estilos;
using SignaBSG.Services;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace SignaBSG
{
    public partial class Signer : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private readonly string certificateP12;
        private readonly string certificatePassword;
        private readonly string documentPdf;
        private readonly string version;

        private int pageNumber;
        private float coordinateX;
        private float coordinateY;

        private Cursor cursorPersonalizado;
        private Home formPrincipal;
        // Coordenadas del rectángulo en el visor
        private Point? firmaRectClientLocation = null;

        // Tamaño del rectángulo a dibujar (puedes ajustarlo)
        private readonly Size firmaRectSize = new Size(100, 50);



        [DllImport("user32.dll")] private static extern bool ReleaseCapture();
        [DllImport("user32.dll")] private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public Signer(Home princiapl, string certificateP12, string certificatePassword, string documentPdf, string version)
        {
            InitializeComponent();

            this.formPrincipal = princiapl;
            this.certificateP12 = certificateP12;
            this.certificatePassword = certificatePassword;
            this.documentPdf = documentPdf;
            this.version = version;

            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            FormBorderStyle = FormBorderStyle.None;
            Text = string.Empty;
            DoubleBuffered = true;
            AplicarTemaVisual();
        }

        private void AplicarTemaVisual()
        {
            if (!Enum.TryParse(Properties.Settings.Default.TemaActual, out Tema tema))
                return;

            if (tema == Tema.Sistema)
                tema = TemaApp.DetectarTemaDelSistema();

            if (tema == Tema.Oscuro)
                DarkMode.AplicarEstilo(this);
            else
                LigthMode.AplicarEstilo(this);
        }

        private void Signer_Load(object sender, EventArgs e)
        {
            label1_VersionApp.Text = $"SignaBG {version}";

            //pdfToolStripZoomEx1.ZoomLevel.SetValue(pdfViewer1.CurrentPage, 1.0f); // 100%
            pdfViewer1.Zoom = 1.0f;

            pdfViewer1.LoadDocument(this.documentPdf);

            ConfigurarCursorPersonalizado();
        }


        private void PdfViewer1_Paint(object sender, PaintEventArgs e)
        {
            if (firmaRectClientLocation.HasValue)
            {
                Rectangle rect = new Rectangle(firmaRectClientLocation.Value, firmaRectSize);
                using (Pen redPen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawRectangle(redPen, rect);

                  
                }
            }
        }


        private void ConfigurarCursorPersonalizado()
        {
            try
            {
                using Stream stream = Assembly
                    .GetExecutingAssembly()
                    .GetManifestResourceStream("SignaBSG.Resources.Cursors.firmaCursor.cur");

                cursorPersonalizado = stream != null ? new Cursor(stream) : Cursors.Hand;
                pdfViewer1.CursorPersonalizado = cursorPersonalizado;
                pdfViewer1.MouseClick += PdfViewer1_MouseClick;
                pdfViewer1.Paint += PdfViewer1_Paint;
            }
            catch
            {
                cursorPersonalizado = Cursors.Hand;
            }
        }



        private void PdfViewer1_MouseClick(object? sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea estampar la firma aquí?",
                "Advertencia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int pageIndex = pdfViewer1.CurrentIndex;
                pageNumber = pageIndex + 1;

                // Punto del clic en cliente (pantalla)
                Point clientClickPoint = new Point(e.X, e.Y);

                // ✅ Guardar posición para dibujar el rectángulo
                firmaRectClientLocation = clientClickPoint;

                // ⚠️ Este punto es la esquina superior izquierda del rectángulo
                // ✅ Convertir de cliente → PDF (para firmar justo donde se ve el rectángulo)
                PointF pdfPoint = pdfViewer1.ClientToPage(pageIndex, firmaRectClientLocation.Value);


                coordinateX = pdfPoint.X;
                coordinateY = firmaRectClientLocation.Value.Y;
                // ✅ Forzar el repintado para mostrar el rectángulo
                pdfViewer1.Invalidate();





                // ✅ Estampar la firma usando esas coordenadas reales del PDF
                //EstamparFirma();
            }
        }



        #region Firma PDF

        private async Task EstamparFirma()
        {
            try
            {
                var pdfFirmadoBytes = await ApiRequest.FirmarPdfPost(
                    documentPdf,
                    certificateP12,
                    certificatePassword,
                    coordinateX,
                    coordinateY,
                    pageNumber
                );

                if (pdfFirmadoBytes == null)
                {
                    MostrarMensaje("La firma del PDF no se completó.", "Advertencia", MessageBoxIcon.Warning);
                    return;
                }

                string rutaDestino = ObtenerRutaArchivoFirmado();
                File.WriteAllBytes(rutaDestino, pdfFirmadoBytes);


                MostrarMensaje($"PDF firmado correctamente en:\n{rutaDestino}", "Firma completada", MessageBoxIcon.Information);


                try
                {
                    var psi = new ProcessStartInfo
                    {
                        FileName = "explorer.exe",
                        Arguments = $"/select,\"{rutaDestino}\"",
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir la carpeta: " + ex.Message);
                }

                this.formPrincipal.LimpiarControles();

                this.Close();






            }
            catch (Exception ex)
            {
                MostrarMensaje($"Ocurrió un error:\n{ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        private string ObtenerRutaArchivoFirmado()
        {
            string directorio = System.IO.Path.GetDirectoryName(documentPdf);
            string nombreArchivo = System.IO.Path.GetFileNameWithoutExtension(documentPdf);
            string extension = System.IO.Path.GetExtension(documentPdf);

            return System.IO.Path.Combine(directorio, $"{nombreArchivo}Signed{extension}");
        }

        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

        #endregion

        #region Eventos UI

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Ventana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            EstamparFirma();
        }
    }
}
