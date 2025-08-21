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
            panel1_Window = new Panel();
            pictureBox1_AppIcon = new PictureBox();
            label1_AppVersion = new Label();
            button2_Close = new Button();
            pdfToolStripZoomEx1 = new Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoomEx();
            pdfViewer1 = new CustomPdfViewer();
            pdfToolStripPages1 = new Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripPages();
            button1_StampSignature = new Button();
            panel1_Window.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_AppIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1_Window
            // 
            panel1_Window.AutoSize = true;
            panel1_Window.Controls.Add(pictureBox1_AppIcon);
            panel1_Window.Controls.Add(label1_AppVersion);
            panel1_Window.Controls.Add(button2_Close);
            panel1_Window.Dock = DockStyle.Top;
            panel1_Window.Location = new Point(0, 0);
            panel1_Window.Name = "panel1_Window";
            panel1_Window.Size = new Size(802, 34);
            panel1_Window.TabIndex = 2;
            panel1_Window.MouseDown += panel1_Window_MouseDown;
            // 
            // pictureBox1_AppIcon
            // 
            pictureBox1_AppIcon.Image = Properties.Resources.sgb;
            pictureBox1_AppIcon.Location = new Point(4, 8);
            pictureBox1_AppIcon.Name = "pictureBox1_AppIcon";
            pictureBox1_AppIcon.Size = new Size(39, 23);
            pictureBox1_AppIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1_AppIcon.TabIndex = 6;
            pictureBox1_AppIcon.TabStop = false;
            // 
            // label1_AppVersion
            // 
            label1_AppVersion.AutoSize = true;
            label1_AppVersion.Location = new Point(49, 8);
            label1_AppVersion.Name = "label1_AppVersion";
            label1_AppVersion.Size = new Size(45, 15);
            label1_AppVersion.TabIndex = 5;
            label1_AppVersion.Text = "Version";
            label1_AppVersion.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button2_Close
            // 
            button2_Close.Location = new Point(765, 0);
            button2_Close.Name = "button2_Close";
            button2_Close.Size = new Size(37, 31);
            button2_Close.TabIndex = 0;
            button2_Close.Text = "✕";
            button2_Close.UseVisualStyleBackColor = true;
            button2_Close.Click += button2_Close_Click;
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
            // 
            // button1_StampSignature
            // 
            button1_StampSignature.Location = new Point(330, 34);
            button1_StampSignature.Name = "button1_StampSignature";
            button1_StampSignature.Size = new Size(122, 30);
            button1_StampSignature.TabIndex = 6;
            button1_StampSignature.Text = "Estampar Firma";
            button1_StampSignature.UseVisualStyleBackColor = true;
            button1_StampSignature.Click += button1_StampSignature_Click;
            // 
            // Signer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 736);
            Controls.Add(button1_StampSignature);
            Controls.Add(pdfViewer1);
            Controls.Add(pdfToolStripPages1);
            Controls.Add(pdfToolStripZoomEx1);
            Controls.Add(panel1_Window);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Signer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignaBG";
            Load += Signer_Load;
            panel1_Window.ResumeLayout(false);
            panel1_Window.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_AppIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1_Window;
        private PictureBox pictureBox1_AppIcon;
        private Label label1_AppVersion;
        private Button button2_Close;
        private Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoomEx pdfToolStripZoomEx1;
        private Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripPages pdfToolStripPages1;
        private CustomPdfViewer pdfViewer1;
        private Button button1_StampSignature;
    }
}