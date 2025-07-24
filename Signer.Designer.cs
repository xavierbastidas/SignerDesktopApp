using SignaBSG.Helpers; 
namespace SignaBSG
{
    partial class Signer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1_Ventana = new Panel();
            pictureBox1_Icon = new PictureBox();
            label1_VersionApp = new Label();
            button1_Close = new Button();
            pdfToolStripZoomEx1 = new Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoomEx();
            pdfViewer1 = new CustomPdfViewer();
            pdfToolStripPages1 = new Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripPages();
            button1_EstamparFirma = new Button();
            panel1_Ventana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Icon).BeginInit();
            SuspendLayout();
            // 
            // panel1_Ventana
            // 
            panel1_Ventana.AutoSize = true;
            panel1_Ventana.Controls.Add(pictureBox1_Icon);
            panel1_Ventana.Controls.Add(label1_VersionApp);
            panel1_Ventana.Controls.Add(button1_Close);
            panel1_Ventana.Dock = DockStyle.Top;
            panel1_Ventana.Location = new Point(0, 0);
            panel1_Ventana.Name = "panel1_Ventana";
            panel1_Ventana.Size = new Size(802, 34);
            panel1_Ventana.TabIndex = 2;
            panel1_Ventana.MouseDown += panel1_Ventana_MouseDown;
            // 
            // pictureBox1_Icon
            // 
            pictureBox1_Icon.Image = Properties.Resources.sgb;
            pictureBox1_Icon.Location = new Point(4, 8);
            pictureBox1_Icon.Name = "pictureBox1_Icon";
            pictureBox1_Icon.Size = new Size(39, 23);
            pictureBox1_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1_Icon.TabIndex = 6;
            pictureBox1_Icon.TabStop = false;
            // 
            // label1_VersionApp
            // 
            label1_VersionApp.AutoSize = true;
            label1_VersionApp.Location = new Point(49, 8);
            label1_VersionApp.Name = "label1_VersionApp";
            label1_VersionApp.Size = new Size(45, 15);
            label1_VersionApp.TabIndex = 5;
            label1_VersionApp.Text = "Version";
            label1_VersionApp.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button1_Close
            // 
            button1_Close.Location = new Point(765, 0);
            button1_Close.Name = "button1_Close";
            button1_Close.Size = new Size(37, 31);
            button1_Close.TabIndex = 0;
            button1_Close.Text = "✕";
            button1_Close.UseVisualStyleBackColor = true;
            button1_Close.Click += buttonCerrar_Click;
            // 
            // pdfToolStripZoomEx1
            // 
            pdfToolStripZoomEx1.Dock = DockStyle.None;
            pdfToolStripZoomEx1.Location = new Point(0, 34);
            pdfToolStripZoomEx1.Name = "pdfToolStripZoomEx1";
            pdfToolStripZoomEx1.PdfViewer = pdfViewer1;
            pdfToolStripZoomEx1.Size = new Size(214, 25);
            pdfToolStripZoomEx1.TabIndex = 3;
            pdfToolStripZoomEx1.Text = "pdfToolStripZoomEx1";
            pdfToolStripZoomEx1.ZoomLevel = new float[]
    {
    100F,
    50F,
    80F,
    150F
    };
            // 
            // pdfViewer1
            // 
            pdfViewer1.BackColor = SystemColors.ControlDark;
            pdfViewer1.CurrentIndex = -1;
            pdfViewer1.CurrentPageHighlightColor = Color.FromArgb(170, 70, 130, 180);
            pdfViewer1.CursorPersonalizado = null;
            pdfViewer1.Document = null;
            pdfViewer1.FormHighlightColor = Color.Transparent;
            pdfViewer1.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            pdfViewer1.LoadingIconText = "Loading...";
            pdfViewer1.Location = new Point(2, 67);
            pdfViewer1.Margin = new Padding(4, 3, 4, 3);
            pdfViewer1.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.OptimizedLoadThreshold = 1000;
            pdfViewer1.Padding = new Padding(12, 12, 12, 12);
            pdfViewer1.PageAlign = ContentAlignment.MiddleCenter;
            pdfViewer1.PageAutoDispose = true;
            pdfViewer1.PageBackColor = Color.White;
            pdfViewer1.PageBorderColor = Color.Black;
            pdfViewer1.PageMargin = new Padding(10);
            pdfViewer1.PageSeparatorColor = Color.Gray;
            pdfViewer1.RenderFlags = Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH;
            pdfViewer1.ShowCurrentPageHighlight = true;
            pdfViewer1.ShowLoadingIcon = true;
            pdfViewer1.ShowPageSeparator = true;
            pdfViewer1.Size = new Size(800, 670);
            pdfViewer1.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.Zoom;
            pdfViewer1.TabIndex = 5;
            pdfViewer1.TextSelectColor = Color.FromArgb(70, 70, 130, 180);
            pdfViewer1.TilesCount = 2;
            pdfViewer1.UseProgressiveRender = true;
            pdfViewer1.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            pdfViewer1.Zoom = 0F;
            // 
            // pdfToolStripPages1
            // 
            pdfToolStripPages1.Dock = DockStyle.None;
            pdfToolStripPages1.Location = new Point(590, 37);
            pdfToolStripPages1.Name = "pdfToolStripPages1";
            pdfToolStripPages1.PdfViewer = pdfViewer1;
            pdfToolStripPages1.Size = new Size(220, 27);
            pdfToolStripPages1.TabIndex = 4;
            pdfToolStripPages1.Text = "pdfToolStripPages1";
            pdfToolStripPages1.ItemClicked += pdfToolStripPages1_ItemClicked;
            // 
            // button1_EstamparFirma
            // 
            button1_EstamparFirma.Location = new Point(330, 34);
            button1_EstamparFirma.Name = "button1_EstamparFirma";
            button1_EstamparFirma.Size = new Size(122, 30);
            button1_EstamparFirma.TabIndex = 6;
            button1_EstamparFirma.Text = "Estampar Firma";
            button1_EstamparFirma.UseVisualStyleBackColor = true;
            button1_EstamparFirma.Click += button1_Click;
            // 
            // Signer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 736);
            Controls.Add(button1_EstamparFirma);
            Controls.Add(pdfViewer1);
            Controls.Add(pdfToolStripPages1);
            Controls.Add(pdfToolStripZoomEx1);
            Controls.Add(panel1_Ventana);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Signer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignaBG";
            Load += Signer_Load;
            panel1_Ventana.ResumeLayout(false);
            panel1_Ventana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1_Ventana;
        private PictureBox pictureBox1_Icon;
        private Label label1_VersionApp;
        private Button button1_Close;
        private Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoomEx pdfToolStripZoomEx1;
        private Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripPages pdfToolStripPages1;
        private CustomPdfViewer pdfViewer1;
        private Button button1_EstamparFirma;
    }
}