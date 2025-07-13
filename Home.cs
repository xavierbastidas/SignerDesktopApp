using SignaBSG.Resources.Colors;
using SignaBSG.Resources.Estilos;


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

            label1_Num_Docs.BorderStyle = BorderStyle.FixedSingle;

            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = "";
            this.DoubleBuffered = true;


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

        private void Home_Load(object sender, EventArgs e)


        {

            this.Text = $"SignaBG {version}";

            SetupDragAndDrop(groupBox1_Buscar_Certificado, ".p12", GroupBoxCertificado_DragDrop);
            SetupDragAndDrop(groupBox1_Buscar_Documentos, ".pdf", GroupBoxDocumento_DragDrop);
        }

        // --- DRAG & DROP HELPERS ---
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

        // --- DRAG & DROP EVENT HANDLERS ---
        private void GroupBoxDocumento_DragDrop(object? sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            string archivoPdf = archivos.FirstOrDefault(f => Path.GetExtension(f).ToLower() == ".pdf");

            if (!string.IsNullOrEmpty(archivoPdf))
            {
                conteoDocs = archivos.Length;
                documentPdf = archivoPdf;

                label1_Num_Docs.Text = $"{conteoDocs} DOCUMENTO(S) SELECCIONADOS";
                label1_Tambien_Busca_Doc.Text = archivoPdf;
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
                label1_Arrastre_Certificado.Text = archivoP12;

                MessageBox.Show($"Certificado cargado: {Path.GetFileName(archivoP12)}", "Certificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MostrarAdvertencia("Sólo se permite arrastrar archivos .p12 para el certificado.");
            }
        }

        // --- FILE DIALOGS ---
        private void button1_Buscar_Certificado_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = CrearDialogoArchivo("Seleccionar Certificado", "Archivos P12 (*.p12)|*.p12");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                certificateP12 = openFileDialog.FileName;
                label1_Arrastre_Certificado.Text = certificateP12;
            }
        }

        private void button1_Click_Buscar_Documentos(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = CrearDialogoArchivo("Seleccionar Documentos PDF", "Archivos PDF (*.pdf)|*.pdf", true);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                documentPdf = openFileDialog.FileName;
                conteoDocs = openFileDialog.FileNames.Length;

                label1_Num_Docs.Text = $"{conteoDocs} DOCUMENTO(S) SELECCIONADO(S)";
                label1_Tambien_Busca_Doc.Text = documentPdf;
            }
        }

        private OpenFileDialog CrearDialogoArchivo(string titulo, string filtro, bool multi = false) =>
            new OpenFileDialog
            {
                Title = titulo,
                Filter = filtro,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Multiselect = multi
            };

        // --- BOTONES ---
        private void btn_Firmar_Documento(object sender, EventArgs e)
        {
            certificatePassword = textBox1_Contrasenia.Text;

            if (string.IsNullOrEmpty(certificateP12) || string.IsNullOrEmpty(certificatePassword) || string.IsNullOrEmpty(documentPdf))
            {
                MostrarAdvertencia("Por favor llene los campos necesarios: Certificado .p12, Contraseña y Documento.");
                return;
            }

            using Signer sig = new(certificateP12, certificatePassword, documentPdf);
            sig.ShowDialog();
        }

        private void button2_Limpiar_Click(object sender, EventArgs e)
        {
            label1_Arrastre_Certificado.Text = "También lo puedes arrastrar aquí";
            label1_Tambien_Busca_Doc.Text = "También lo puedes arrastrar aquí";
            label1_Num_Docs.Text = "0 DOCUMENTO(S) SELECCIONADO(S)";
            textBox1_Contrasenia.Clear();

            certificateP12 = "";
            certificatePassword = "";
            documentPdf = "";
        }

        // --- UTILIDADES ---
        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // --- MENÚ ---
        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();






        private void acercaDeLaAppToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        // --- EVENTOS NO USADOS ---
        private void label1_Buscar_Certififcado_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void label1_Tambien_Busca_Doc_Click(object sender, EventArgs e) { }
        private void groupBox1_Doc_Selecionados_Enter(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

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

            Tema temaSistema = TemaApp.DetectarTemaDelSistema();

            if (temaSistema == Tema.Oscuro)
                DarkMode.AplicarEstilo(this);
            else
                LigthMode.AplicarEstilo(this);
        }


        private void checkBox1_Contrasenia_CheckedChanged(object sender, EventArgs e)
        {
            textBox1_Contrasenia.UseSystemPasswordChar = !checkBox1_Contrasenia.Checked;
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
           "1. Haz clic en 'Buscar Certificado' y selecciona tu archivo .p12.\n" +
           "2. Ingresa la contraseña del certificado en el campo correspondiente.\n" +
           "3. Haz clic en 'Buscar Documentos' para seleccionar uno o más archivos PDF que deseas firmar.\n" +
           "4. Verifica que los documentos aparezcan en la lista.\n" +
           "5. Presiona el botón 'Firmar' para iniciar el proceso de firma digital.\n\n" +
           "💡 Puedes cambiar el tema desde Configuración → Cambiar Tema.\n\n" +
           "Para más ayuda, contacta al soporte.";

            MessageBox.Show(instrucciones, "Cómo usar SignaBG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}

