using SignaBSG.Resources.Colors;
using SignaBSG.Resources.Styles;
using System.Runtime.InteropServices;

namespace SignaBSG
{
    public partial class Home : Form
    {
        #region Variables

        public static int documentCount = 0;
        private static string certificatePassword = "";
        private static string documentPdf = "";
        private static string certificateP12 = "";
        private static string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        #endregion

        #region Constructor

        public Home()
        {
            InitializeComponent();
            InitializeForm();
            ApplyTheme();
        }

        #endregion

        #region Form Initialization

        private void InitializeForm()
        {
            label6_SelectedDocuments.BorderStyle = BorderStyle.FixedSingle;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = string.Empty;
            this.DoubleBuffered = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1_AppVersion.Text = $"SignaBG {version}";
            SetupDragAndDrop(groupBox1_SearchCertificate, ".p12", GroupBoxCertificate_Drop);
            SetupDragAndDrop(groupBox3_SearchDocument, ".pdf", GroupBoxDocument_Drop);
        }

        private void ApplyTheme()
        {
            if (Enum.TryParse(Properties.Settings.Default.CurrentTheme, out Theme theme))
            {
                if (theme == Theme.System)
                    theme = AppTheme.DetectSystemTheme();

                if (theme == Theme.Dark)
                    DarkMode.ApplyStyle(this);
                else
                    LightMode.ApplyStyle(this);
            }
        }

        #endregion

        #region Drag and Drop

        private void SetupDragAndDrop(Control control, string extension, DragEventHandler dropHandler)
        {
            control.AllowDrop = true;
            control.DragEnter += (s, e) => OnDragEnter(e, extension);
            control.DragDrop += dropHandler;
        }

        private void OnDragEnter(DragEventArgs e, string extension)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Any(f => Path.GetExtension(f).ToLower() == extension))
                {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }
            e.Effect = DragDropEffects.None;
        }

        private void GroupBoxDocument_Drop(object sender, DragEventArgs e) => HandleDocumentDrop(e);
        private void GroupBoxCertificate_Drop(object sender, DragEventArgs e) => HandleCertificateDrop(e);

        private void HandleDocumentDrop(DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string pdfFile = files.FirstOrDefault(f => Path.GetExtension(f).ToLower() == ".pdf");

            if (!string.IsNullOrEmpty(pdfFile))
            {
                documentCount = files.Length;
                documentPdf = pdfFile;
                label6_SelectedDocuments.Text = $"{documentCount} DOCUMENTO(S) SELECCIONADO(S)";
                label4_DragDocument.Text = pdfFile;
            }
            else
            {
                ShowWarning("Solo se permiten archivos .pdf para los documentos.");
            }
        }


        private void HandleCertificateDrop(DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string p12File = files.FirstOrDefault(f => Path.GetExtension(f).ToLower() == ".p12");

            if (!string.IsNullOrEmpty(p12File))
            {
                certificateP12 = p12File;
                label2_DragCertificateHere.Text = p12File;
            }
            else
            {
                ShowWarning("Solo se permiten archivos .p12 para el certificado.");
            }
        }


        #endregion

        #region File Dialogs

        private void button1_SearchCertificate_Click(object sender, EventArgs e) => SelectCertificateFile();
        private void button2_SearchDocument_Click(object sender, EventArgs e) => SelectDocumentFiles();

        private void SelectCertificateFile()
        {
            OpenFileDialog dialog = CreateFileDialog("Selecciona certificado", "Archivos P12 (*.p12)|*.p12");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                certificateP12 = dialog.FileName;
                label2_DragCertificateHere.Text = certificateP12;
            }
        }


        private void SelectDocumentFiles()
        {
            OpenFileDialog dialog = CreateFileDialog("Selecciona documentos PDF", "Archivos PDF (*.pdf)|*.pdf", true);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                documentPdf = dialog.FileName;
                documentCount = dialog.FileNames.Length;
                label6_SelectedDocuments.Text = $"{documentCount} DOCUMENTO(S) SELECCIONADO(S)";
                label4_DragDocument.Text = documentPdf;
            }
        }


        private OpenFileDialog CreateFileDialog(string title, string filter, bool multi = false) =>
            new()
            {
                Title = title,
                Filter = filter,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Multiselect = multi
            };

        #endregion

        #region Signing and Validation

        private void button3_Sign_Click(object sender, EventArgs e) => SignDocument();

        private void SignDocument()
        {
            certificatePassword = textBox1_EnterPassword.Text;

            if (!ValidateFields())
                return;

            FileInfo fileInfo = new FileInfo(documentPdf);

            if (!fileInfo.Exists)
            {
                MessageBox.Show("El documento PDF no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsFileSizeAllowed(fileInfo.Length))
            {
                MessageBox.Show("El tamaño del PDF no está permitido por las restricciones de la licencia.\n\n" +
                                "Solo se permiten documentos menores a 1MB, mayores a 10MB,\n" +
                                "o exactamente de 2MB, 3MB, 4MB o 5MB.",
                                "Restricción de licencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using Signer signer = new(this, certificateP12, certificatePassword, documentPdf, version);
            signer.ShowDialog();
        }


        private bool IsFileSizeAllowed(long fileSizeBytes)
        {
            const long minAllowedBytes = 1025 * 1024;
            const long maxAllowedBytes = 10 * 1024 * 1024;

            if (fileSizeBytes < minAllowedBytes || fileSizeBytes > maxAllowedBytes)
                return true;

            long fileSizeMB = fileSizeBytes / (1024 * 1024);

            return fileSizeMB switch
            {
                2 or 3 or 4 or 5 => true,
                _ => false
            };
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(certificateP12) ||
                string.IsNullOrEmpty(certificatePassword) ||
                string.IsNullOrEmpty(documentPdf))
            {
                ShowWarning("Por favor, completa todos los campos requeridos: Certificado .p12, Contraseña y Documento.");
                return false;
            }
            return true;
        }


        private void button4_Clear_Click(object sender, EventArgs e) => ClearAllFields();

        public void ClearAllFields()
        {
            label2_DragCertificateHere.Text = "También puedes arrastrarlo aquí";
            label4_DragDocument.Text = "También puedes arrastrarlo aquí";
            label6_SelectedDocuments.Text = "0 DOCUMENTO(S) SELECCIONADO(S)";
            textBox1_EnterPassword.Clear();

            certificateP12 = "";
            certificatePassword = "";
            documentPdf = "";
        }


        #endregion

        #region UI Utilities

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void checkBox1_ShowPassword_CheckedChanged(object sender, EventArgs e) => TogglePasswordVisibility();

        private void TogglePasswordVisibility()
        {
            textBox1_EnterPassword.UseSystemPasswordChar = !checkBox1_ShowPassword.Checked;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) => StartWindowDrag();

        private void StartWindowDrag()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        #endregion

        #region Menu

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e) => ChangeTheme(Theme.Dark);
        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e) => ChangeTheme(Theme.Light);
        private void systemThemeToolStripMenuItem_Click(object sender, EventArgs e) => ChangeTheme(Theme.System);

        private void ChangeTheme(Theme theme)
        {
            Properties.Settings.Default.CurrentTheme = theme.ToString();
            Properties.Settings.Default.Save();

            if (theme == Theme.Dark)
                DarkMode.ApplyStyle(this);
            else if (theme == Theme.Light)
                LightMode.ApplyStyle(this);
            else
                ApplyTheme();
        }

        private void appVersionToolStripMenuItem_Click(object sender, EventArgs e) => ShowAppVersion();
        private void aboutToolStripMenuItem_Click (object sender, EventArgs e) => ShowInstructions();

        private void ShowAppVersion()
        {
            string message = $"📦 Versión de la App: {version}\n\n" +
                             "👨‍💻 Desarrollado por Bastidas Solutions Group";
            MessageBox.Show(message, "Información de la App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ShowInstructions()
        {
            string instructions =
               "📘 Cómo usar SignaBG:\n\n" +
               "1. Selecciona tu certificado .p12.\n" +
               "2. Ingresa la contraseña.\n" +
               "3. Selecciona uno o más documentos PDF.\n" +
               "4. Haz clic en 'Firmar'.\n\n" +
               "💡 Puedes cambiar el tema desde Configuración → Cambiar tema.";

            MessageBox.Show(instructions, "Cómo usar SignaBG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        #endregion

        #region Window Controls and Behavior

        [DllImport("user32.dll")] public static extern bool ReleaseCapture();
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void button7_Close_Click(object sender, EventArgs e) => this.Close();
        private void button6_Maximize_Click(object sender, EventArgs e) => ToggleWindowState();
        private void button5_Minimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void ToggleWindowState()
        {
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        #endregion
    }
}
