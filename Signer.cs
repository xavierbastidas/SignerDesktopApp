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
        private Image selloImage;
        private Home mainForm;

        private bool isRectPlaced = false;
        private RectangleF pdfRect;

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

        private void Signer_Load(object sender, EventArgs e) => LoadPdfViewer();

        private void LoadPdfViewer()
        {
            label1_AppVersion.Text = $"SignaBG {version}";
            pdfViewer1.Zoom = 1.0f;
            pdfViewer1.LoadDocument(documentPdf);

            ConfigureCustomCursor();
            LoadSelloImage();
        }

        #endregion

        #region PDF Viewer Configuration

        private void ConfigureCustomCursor()
        {
            try
            {
                using Stream stream = Assembly
                    .GetExecutingAssembly()
                    .GetManifestResourceStream("SignaBSG.Resources.Cursors.cursor.cur");

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

        private void LoadSelloImage()
        {
            using Stream stream = Assembly
                .GetExecutingAssembly()
                .GetManifestResourceStream("SignaBSG.Resources.Images.sello.png");

            if (stream != null)
                selloImage = Image.FromStream(stream);
            else
                throw new Exception("No se pudo encontrar el recurso de sello.");
        }

        private void PdfViewer1_MouseClick(object? sender, MouseEventArgs e) => HandlePdfMouseClick(e);

        private void HandlePdfMouseClick(MouseEventArgs e)
        {
            if (!ConfirmStampPlacement())
                return;

            pageIndex = pdfViewer1.CurrentIndex;

            SetPdfRectFromClick(e.Location);

            coordinateX = pdfRect.X;
            coordinateY = pdfRect.Y;
            pageNumber = pageIndex + 1;

            isRectPlaced = true;
            pdfViewer1.Invalidate();
        }

        private bool ConfirmStampPlacement() =>
            MessageBox.Show("¿Desea estampar la firma aquí?", "Confirm",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        private void SetPdfRectFromClick(Point clickLocation)
        {
            PointF pdfTopLeft = pdfViewer1.ClientToPage(pageIndex,
                new Point(clickLocation.X - 50, clickLocation.Y - 25));
            PointF pdfBottomRight = pdfViewer1.ClientToPage(pageIndex,
                new Point(clickLocation.X + 50, clickLocation.Y + 25));

            pdfRect = new RectangleF(
                pdfTopLeft.X,
                pdfBottomRight.Y,
                pdfBottomRight.X - pdfTopLeft.X,
                pdfTopLeft.Y - pdfBottomRight.Y
            );
        }

        private void PdfViewer1_Paint(object sender, PaintEventArgs e) => DrawSello(e.Graphics);

        private void DrawSello(Graphics g)
        {
            if (!isRectPlaced) return;

            Point topLeft = pdfViewer1.PageToClient(pageIndex, new PointF(pdfRect.Left, pdfRect.Top + pdfRect.Height));
            Point bottomRight = pdfViewer1.PageToClient(pageIndex, new PointF(pdfRect.Right, pdfRect.Top));

            Rectangle clientRect = Rectangle.FromLTRB(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y);
            g.DrawImage(selloImage, clientRect);
        }

        #endregion

        #region PDF Signing

        private void button1_StampSignature_Click(object sender, EventArgs e) => _ = StampSignatureAsync();

        private async Task StampSignatureAsync()
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

                mainForm.ClearAllFields();
                Close();
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

            return Path.Combine(directory, $"{fileName}signed{extension}");
        }

        private void ShowMessage(string message, string title, MessageBoxIcon icon) =>
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);

        #endregion

        #region UI Events

        private void button2_Close_Click(object sender, EventArgs e) => Close();

        private void panel1_Window_MouseDown(object sender, MouseEventArgs e) => DragWindow();

        private void DragWindow()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        #endregion

        #region Window  Behavior
        [DllImport("user32.dll")] private static extern bool ReleaseCapture();
        [DllImport("user32.dll")] private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        #endregion

       
    }
}
