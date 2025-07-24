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
            label1_NumDocumentos.BorderStyle = BorderStyle.FixedSingle;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = string.Empty;
            this.DoubleBuffered = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1_VersionApp.Text = $"SignaBG {version}";
            SetupDragAndDrop(groupBox1_BuscarCertificado, ".p12", GroupBoxCertificate_DragDrop);
            SetupDragAndDrop(groupBox1_BuscarDocumento, ".pdf", GroupBoxDocument_DragDrop);
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

        private void GroupBoxDocument_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string pdfFile = files.FirstOrDefault(f => Path.GetExtension(f).ToLower() == ".pdf");

            if (!string.IsNullOrEmpty(pdfFile))
            {
                documentCount = files.Length;
                documentPdf = pdfFile;
                label1_NumDocumentos.Text = $"{documentCount} DOCUMENTO(S) SELECCIONADO(S)";
                label1_ArrastrarDocumento.Text = pdfFile;
            }
            else
            {
                ShowWarning("Sólo se permite arrastrar archivos .pdf para el documento.");
            }
        }

        private void GroupBoxCertificate_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string p12File = files.FirstOrDefault(f => Path.GetExtension(f).ToLower() == ".p12");

            if (!string.IsNullOrEmpty(p12File))
            {
                certificateP12 = p12File;
                label1_ArrastrarCertificado.Text = p12File;
            }
            else
            {
                ShowWarning("Sólo se permite arrastrar archivos .p12 para el certificado.");
            }
        }

        #endregion

        #region File Dialogs

        private void button1_Buscar_Certificado_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = CreateFileDialog("Seleccionar Certificado", "Archivos P12 (*.p12)|*.p12");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                certificateP12 = dialog.FileName;
                label1_ArrastrarCertificado.Text = certificateP12;
            }
        }

        private void button1_Click_Buscar_Documentos(object sender, EventArgs e)
        {
            OpenFileDialog dialog = CreateFileDialog("Seleccionar Documentos PDF", "Archivos PDF (*.pdf)|*.pdf", true);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                documentPdf = dialog.FileName;
                documentCount = dialog.FileNames.Length;
                label1_NumDocumentos.Text = $"{documentCount} DOCUMENTO(S) SELECCIONADO(S)";
                label1_ArrastrarDocumento.Text = documentPdf;
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

        private void btn_Firmar_Documento(object sender, EventArgs e)
        {
            certificatePassword = textBox1_Contrasenia.Text;

            if (!ValidateFields())
                return;

            FileInfo fileInfo = new FileInfo(documentPdf);

            if (!fileInfo.Exists)
            {
                MessageBox.Show("El documento PDF no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsFileSizeAllowedByLicense(fileInfo.Length))
            {
                MessageBox.Show("El tamaño del PDF no está permitido por las restricciones de licencia.\n\n" +
                                "Solo se permiten documentos menores a 1MB, mayores a 10MB,\n" +
                                "o de tamaño exacto como 2MB, 3MB, 4MB o 5MB.",
                                "Restricción de Licencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using Signer signer = new(this, certificateP12, certificatePassword, documentPdf, version);
            signer.ShowDialog();
        }

        private bool IsFileSizeAllowedByLicense(long fileSizeBytes)
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
                ShowWarning("Por favor llene los campos necesarios: Certificado .p12, Contraseña y Documento.");
                return false;
            }
            return true;
        }

        private void button2_Limpiar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        public void ClearControls()
        {
            label1_ArrastrarCertificado.Text = "También lo puedes arrastrar aquí";
            label1_ArrastrarDocumento.Text = "También lo puedes arrastrar aquí";
            label1_NumDocumentos.Text = "0 DOCUMENTO(S) SELECCIONADO(S)";
            textBox1_Contrasenia.Clear();

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

        private void checkBox1_Contrasenia_CheckedChanged(object sender, EventArgs e)
        {
            textBox1_Contrasenia.UseSystemPasswordChar = !checkBox1_MostrarContrasenia.Checked;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        #endregion

        #region Menu

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void temaOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentTheme = Theme.Dark.ToString();
            Properties.Settings.Default.Save();
            DarkMode.ApplyStyle(this);
        }

        private void temaClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentTheme = Theme.Light.ToString();
            Properties.Settings.Default.Save();
            LightMode.ApplyStyle(this);
        }

        private void temaSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentTheme = Theme.System.ToString();
            Properties.Settings.Default.Save();
            ApplyTheme();
        }

        private void versiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = $"📦 Versión de la aplicación: {version}\n\n" +
                             "👨‍💻 Desarrollado por Bastidas Solutions Group";

            MessageBox.Show(message, "Información de la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comoUsarLaAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string instructions =
               "📘 Cómo usar SignaBG:\n\n" +
               "1. Selecciona tu certificado .p12.\n" +
               "2. Ingresa la contraseña.\n" +
               "3. Selecciona uno o más documentos PDF.\n" +
               "4. Haz clic en 'Firmar'.\n\n" +
               "💡 Puedes cambiar el tema desde Configuración → Cambiar Tema.";

            MessageBox.Show(instructions, "Cómo usar SignaBG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Window Controls and Behavior

        [DllImport("user32.dll")] public static extern bool ReleaseCapture();
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void button2_Close_Click(object sender, EventArgs e) => this.Close();
        private void button2_Maximizar_Click(object sender, EventArgs e) =>
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;

        private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        #endregion
    }
}
