using SignaBSG.Resources.Colors;
using SignaBSG.Resources.Estilos;
using System.Runtime.InteropServices;

namespace SignaBSG
{
    public partial class Home : Form
    {
        public static int conteoDocs = 0;
        private static string certificatePassword = "";
        private static string documentPdf = "";
        private static string certificateP12 = "";
        private static string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public Home()
        {
            InitializeComponent();
            InicializarFormulario();
            AplicarTema();
        }

        #region Inicialización

        private void InicializarFormulario()
        {
            label1_NumDocumentos.BorderStyle = BorderStyle.FixedSingle;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = string.Empty;
            this.DoubleBuffered = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1_VersionApp.Text = $"SignaBG {version}";

            SetupDragAndDrop(groupBox1_BuscarCertificado, ".p12", GroupBoxCertificado_DragDrop);
            SetupDragAndDrop(groupBox1_BuscarDocumento, ".pdf", GroupBoxDocumento_DragDrop);
        }

        private void AplicarTema()
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

        private void GroupBoxDocumento_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            string archivoPdf = archivos.FirstOrDefault(f => Path.GetExtension(f).ToLower() == ".pdf");

            if (!string.IsNullOrEmpty(archivoPdf))
            {
                conteoDocs = archivos.Length;
                documentPdf = archivoPdf;
                label1_NumDocumentos.Text = $"{conteoDocs} DOCUMENTO(S) SELECCIONADO(S)";
                label1_ArrastrarDocumento.Text = archivoPdf;
            }
            else
            {
                MostrarAdvertencia("Sólo se permite arrastrar archivos .pdf para el documento.");
            }
        }

        private void GroupBoxCertificado_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            string archivoP12 = archivos.FirstOrDefault(f => Path.GetExtension(f).ToLower() == ".p12");

            if (!string.IsNullOrEmpty(archivoP12))
            {
                certificateP12 = archivoP12;
                label1_ArrastrarCertificado.Text = archivoP12;
               
            }
            else
            {
                MostrarAdvertencia("Sólo se permite arrastrar archivos .p12 para el certificado.");
            }
        }

        #endregion

        #region Diálogos de Archivo

        private void button1_Buscar_Certificado_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = CrearDialogoArchivo("Seleccionar Certificado", "Archivos P12 (*.p12)|*.p12");
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                certificateP12 = dlg.FileName;
                label1_ArrastrarCertificado.Text = certificateP12;
            }
        }

        private void button1_Click_Buscar_Documentos(object sender, EventArgs e)
        {
            OpenFileDialog dlg = CrearDialogoArchivo("Seleccionar Documentos PDF", "Archivos PDF (*.pdf)|*.pdf", true);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                documentPdf = dlg.FileName;
                conteoDocs = dlg.FileNames.Length;
                label1_NumDocumentos.Text = $"{conteoDocs} DOCUMENTO(S) SELECCIONADO(S)";
                label1_ArrastrarDocumento.Text = documentPdf;
            }
        }

        private OpenFileDialog CrearDialogoArchivo(string titulo, string filtro, bool multi = false) =>
            new()
            {
                Title = titulo,
                Filter = filtro,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Multiselect = multi
            };

        #endregion

        #region Firma y Validación

        private void btn_Firmar_Documento(object sender, EventArgs e)
        {
            certificatePassword = textBox1_Contrasenia.Text;

            if (!ValidarCamposParaFirmar()) return;

            using Signer sig = new(certificateP12, certificatePassword, documentPdf,version);
            sig.ShowDialog();
        }

        private bool ValidarCamposParaFirmar()
        {
            if (string.IsNullOrEmpty(certificateP12) ||
                string.IsNullOrEmpty(certificatePassword) ||
                string.IsNullOrEmpty(documentPdf))
            {
                MostrarAdvertencia("Por favor llene los campos necesarios: Certificado .p12, Contraseña y Documento.");
                return false;
            }
            return true;
        }

        private void button2_Limpiar_Click(object sender, EventArgs e)
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

        #region Utilidades y UI

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        #region Menú

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void temaOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TemaActual = Tema.Oscuro.ToString();
            Properties.Settings.Default.Save();
            DarkMode.AplicarEstilo(this);
        }

        private void temaClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TemaActual = Tema.Claro.ToString();
            Properties.Settings.Default.Save();
            LigthMode.AplicarEstilo(this);
        }

        private void porDefectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TemaActual = Tema.Sistema.ToString();
            Properties.Settings.Default.Save();
            AplicarTema();
        }

        private void versiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = $"📦 Versión de la aplicación: {version}\n\n" +
                             "👨‍💻 Desarrollado por Bastidas Solutions Group";

            MessageBox.Show(mensaje, "Información de la aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comoUsarLaAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string instrucciones =
               "📘 Cómo usar SignaBG:\n\n" +
               "1. Selecciona tu certificado .p12.\n" +
               "2. Ingresa la contraseña.\n" +
               "3. Selecciona uno o más documentos PDF.\n" +
               "4. Haz clic en 'Firmar'.\n\n" +
               "💡 Puedes cambiar el tema desde Configuración → Cambiar Tema.";

            MessageBox.Show(instrucciones, "Cómo usar SignaBG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Ventana

        [DllImport("user32.dll")] public static extern bool ReleaseCapture();
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void button2_Close_Click(object sender, EventArgs e) => this.Close();
        private void button2_Maximizar_Click(object sender, EventArgs e) =>
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;

        private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        #endregion

        #region Eventos Vacíos

        private void label1_Buscar_Certififcado_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void label1_Tambien_Busca_Doc_Click(object sender, EventArgs e) { }
        private void groupBox1_Doc_Selecionados_Enter(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void archivoToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void acercaDeLaAppToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void panel1_Ventana_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        #endregion
    }
}


