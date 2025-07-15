using SignaBSG.Resources.Colors;
using SignaBSG.Resources.Estilos;
using Syncfusion.Windows.Forms.PdfViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignaBSG
{
    public partial class Signer : Form
    {

        public string certificateP12 = "";
        public string certificatePassword = "";

        public string documentPdf = "";


        public Signer(string certificateP12, string certificatePassword, string documentPdf)
        {

            InitializeComponent();
            this.certificateP12 = certificateP12;
            this.certificatePassword = certificatePassword;
            this.documentPdf = documentPdf;

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



        // DLLs para mover el formulario
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        private void Signer_Load(object sender, EventArgs e)
        {
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            label1_Version.Text = $"SignaBG {version}";

            pdfViewerControl1.ToolbarSettings.OpenButton.IsVisible = false;

            pdfViewerControl1.ToolbarSettings.SaveButton.IsVisible = false;

            pdfViewerControl1.ToolbarSettings.PrintButton.IsVisible = false;

            pdfViewerControl1.ToolbarSettings.SelectionButton.IsVisible = false;

           pdfViewerControl1.ToolbarSettings.PanButton.IsVisible = false;

            pdfViewerControl1.ToolbarSettings.FitPageButton.IsVisible = false;
            pdfViewerControl1.ToolbarSettings.FitWidthButton.IsVisible = false;
            pdfViewerControl1.IsBookmarkEnabled = false;

            pdfViewerControl1.Load(this.documentPdf);

          
           
          

        }

      

      

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Ventana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

       
    }
}
