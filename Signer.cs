using SignaBSG.Resources.Colors;
using SignaBSG.Resources.Styles;
using SignaBSG.Services;
using System.Reflection;
using System.Runtime.InteropServices;


namespace SignaBSG
{
    public partial class Signer : Form
    {
        #region Variables

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private readonly string certificateP12;
        private readonly string certificatePassword;
        private readonly string documentPdf;
        private readonly string version;

        private int pageNumber;
        private int pageIndex;
        private float coordinateX;
        private float coordinateY;

        private Cursor customCursor;
        private Home mainForm;

        private Rectangle clientRect;
        private bool isRectPlaced = false;
       



        [DllImport("user32.dll")] private static extern bool ReleaseCapture();
        [DllImport("user32.dll")] private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        #endregion

        #region Constructor

        public Signer(Home mainForm, string certificateP12, string certificatePassword, string documentPdf, string version)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.certificateP12 = certificateP12;
            this.certificatePassword = certificatePassword;
            this.documentPdf = documentPdf;
            this.version = version;

            InitializeForm();
        }

        #endregion

        #region Form Initialization

        private void InitializeForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            Text = string.Empty;
            DoubleBuffered = true;
            ApplyVisualTheme();
        }

        private void ApplyVisualTheme()
        {
            if (!Enum.TryParse(Properties.Settings.Default.CurrentTheme, out Theme theme))
                return;

            if (theme == Theme.System)
                theme = AppTheme.DetectSystemTheme();

            if (theme == Theme.Dark)
                DarkMode.ApplyStyle(this);
            else
                LightMode.ApplyStyle(this);
        }

        private void Signer_Load(object sender, EventArgs e)
        {
            label1_VersionApp.Text = $"SignaBG {version}";
            pdfViewer1.Zoom = 1.0f;
            pdfViewer1.LoadDocument(this.documentPdf);
            ConfigureCustomCursor();
        }

        #endregion

        #region PDF Viewer Configuration

        private void ConfigureCustomCursor()
        {
            try
            {
                using Stream stream = Assembly
                    .GetExecutingAssembly()
                    .GetManifestResourceStream("SignaBSG.Resources.Cursors.signatureCursor.cur");

                customCursor = stream != null ? new Cursor(stream) : Cursors.Hand;
                pdfViewer1.CursorPersonalizado = customCursor;
                pdfViewer1.MouseClick += PdfViewer1_MouseClick;
                pdfViewer1.Paint += PdfViewer1_Paint;
            }
            catch
            {
                customCursor = Cursors.Hand;
            }
        }



        private void PdfViewer1_MouseClick(object? sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea estampar la firma aquí?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Size rectSize = new Size(100, 50); // tamaño visual en píxeles
                Point location = new Point(
                    e.Location.X - rectSize.Width / 2,
                    e.Location.Y - rectSize.Height / 2
                );

                clientRect = new Rectangle(location, rectSize);
                isRectPlaced = true;

                pdfViewer1.Invalidate(); // Forzar redibujado

                pageIndex = pdfViewer1.CurrentIndex;

                // Convertir punto superior izquierdo y tamaño del rectángulo
                PointF topLeftPdf = pdfViewer1.ClientToPage(pageIndex, clientRect.Location);
                PointF bottomRightPdf = pdfViewer1.ClientToPage(pageIndex, new Point(
                    clientRect.Right,
                    clientRect.Bottom
                ));

                // Calcular ancho y alto en coordenadas PDF
                float pdfX = topLeftPdf.X;
                float pdfY = topLeftPdf.Y;
                float pdfWidth = bottomRightPdf.X - topLeftPdf.X;
                float pdfHeight = bottomRightPdf.Y - topLeftPdf.Y;

                // Ahora puedes usar estos datos para firmar
                coordinateX = pdfX;
                coordinateY = pdfY;
                //coordinateWidth = pdfWidth;
                //coordinateHeight = pdfHeight;
            }
        }

        private void PdfViewer1_Paint(object sender, PaintEventArgs e)
        {
            if (isRectPlaced)
            {
                using (Pen redPen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawRectangle(redPen, clientRect);
                }
            }
        }





        #endregion

        #region PDF Signing

        private async Task StampSignature()
        {
            try
            {
                var signedPdfBytes = await ApiRequest.FirmarPdfPost(
                    documentPdf,
                    certificateP12,
                    certificatePassword,
                    coordinateX,
                    coordinateY,
                    pageNumber
                );

                if (signedPdfBytes == null)
                {
                    ShowMessage("La firma del PDF no se completó.", "Advertencia", MessageBoxIcon.Warning);
                    return;
                }

                string destinationPath = GetSignedFilePath();
                File.WriteAllBytes(destinationPath, signedPdfBytes);

                ShowMessage($"PDF firmado correctamente en:\n{destinationPath}", "Firma completada", MessageBoxIcon.Information);

                this.mainForm.ClearControls();
                this.Close();
            }
            catch (Exception ex)
            {
                ShowMessage($"Ocurrió un error:\n{ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        private string GetSignedFilePath()
        {
            string directory = Path.GetDirectoryName(documentPdf);
            string fileName = Path.GetFileNameWithoutExtension(documentPdf);
            string extension = Path.GetExtension(documentPdf);

            return Path.Combine(directory, $"{fileName}Signed{extension}");
        }

        private void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = StampSignature();
        }

        #endregion

        #region UI Events

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

        private void pdfToolStripPages1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
