using SignaBSG.Resources.Colors;
using SignaBSG.Resources.Estilos;
using Syncfusion.Windows.Forms.PdfViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignaBSG
{
    public partial class Signer : Form
    {

        public string certificateP12 = "";
        public string certificatePassword = "";

        public  string documentPdf = "";

       
        public Signer(string certificateP12, string certificatePassword, string documentPdf)
        {

            InitializeComponent();
            this.certificateP12 = certificateP12;
            this.certificatePassword = certificatePassword;
            this.documentPdf = documentPdf;

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

        private void Signer_Load(object sender, EventArgs e)
        {
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = $"SignaBG {version}";
            pdfViewerControl1.Load(this.documentPdf);

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
