using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SignaBSG
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
           
        }

        private void label1_Buscar_Certififcado_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

            groupBox1_Buscar_Certificado.AllowDrop = true;

            groupBox1_Buscar_Certificado.DragEnter += GroupBoxCertificado_DragEnter;
            groupBox1_Buscar_Certificado.DragDrop += GroupBoxCertificado_DragDrop;


        }
        private void GroupBoxCertificado_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
                // Acepta sólo si hay al menos un .pfx
                if (archivos.Any(f => Path.GetExtension(f).ToLower() == ".p12"))
                {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }

            e.Effect = DragDropEffects.None;
        }


        private void GroupBoxCertificado_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            string archivoPfx = archivos.FirstOrDefault(f => Path.GetExtension(f).ToLower() == ".pfx");

            if (!string.IsNullOrEmpty(archivoPfx))
            {
              //  rutaCertificado = archivoPfx; // Se guarda solo en memoria
                MessageBox.Show($"Certificado cargado: {Path.GetFileName(archivoPfx)}", "Certificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sólo se permite arrastrar archivos .pfx para el certificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btn_Firmar_Documento(object sender, EventArgs e)
        {


            using (Signer sig = new Signer())
            {
                this.Enabled = false;
                sig.ShowDialog();
                this.Enabled = true;
            }

        }

        private void button2_Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cambiarTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--FormSettings form = new FormSettings();
            // form.ShowDialog(); // Modo modal
        }

        private void acercaDeLaAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void button1_Buscar_Certificado_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Seleccionar Certificado",
                Filter = "Archivos P12 (*.p12)|*.p12|Todos los archivos (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaCertificado = openFileDialog.FileName;
                // Puedes usar la ruta aquí como necesites, por ejemplo:
                MessageBox.Show($"Certificado seleccionado:\n{rutaCertificado}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // O asignarlo a un TextBox si quieres mostrarlo en la interfaz:
                // textBoxRutaCertificado.Text = rutaCertificado;
            }
        }



        private void button1_Click_Buscar_Documentos(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Seleccionar Documentos PDF",
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] archivosSeleccionados = openFileDialog.FileNames;

                // Ejemplo: mostrar cuántos archivos se seleccionaron
                MessageBox.Show($"{archivosSeleccionados.Length} documento(s) seleccionado(s)", "Documentos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Aquí puedes agregar lógica para mostrar o almacenar los archivos
                // Por ejemplo: mostrarlos en un ListBox o guardarlos en una lista
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
    }
}
