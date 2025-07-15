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
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signer));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            panel1_Ventana = new Panel();
            button1_Close = new Button();
            pictureBox1_ico = new PictureBox();
            label1_Version = new Label();
            button2_Close = new Button();
            pdfViewerControl1 = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            panel1_Ventana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_ico).BeginInit();
            SuspendLayout();
            // 
            // panel1_Ventana
            // 
            panel1_Ventana.AutoSize = true;
            panel1_Ventana.Controls.Add(button1_Close);
            panel1_Ventana.Controls.Add(pictureBox1_ico);
            panel1_Ventana.Controls.Add(label1_Version);
            panel1_Ventana.Controls.Add(button2_Close);
            panel1_Ventana.Dock = DockStyle.Top;
            panel1_Ventana.Location = new Point(0, 0);
            panel1_Ventana.Name = "panel1_Ventana";
            panel1_Ventana.Size = new Size(769, 34);
            panel1_Ventana.TabIndex = 2;
            panel1_Ventana.MouseDown += panel1_Ventana_MouseDown;
            // 
            // button1_Close
            // 
            button1_Close.Location = new Point(729, 0);
            button1_Close.Name = "button1_Close";
            button1_Close.Size = new Size(40, 31);
            button1_Close.TabIndex = 7;
            button1_Close.Text = "✕";
            button1_Close.UseVisualStyleBackColor = true;
            button1_Close.Click += button1_Click;
            // 
            // pictureBox1_ico
            // 
            pictureBox1_ico.Image = Properties.Resources.image;
            pictureBox1_ico.Location = new Point(4, 8);
            pictureBox1_ico.Name = "pictureBox1_ico";
            pictureBox1_ico.Size = new Size(39, 23);
            pictureBox1_ico.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1_ico.TabIndex = 6;
            pictureBox1_ico.TabStop = false;
            // 
            // label1_Version
            // 
            label1_Version.AutoSize = true;
            label1_Version.Location = new Point(49, 8);
            label1_Version.Name = "label1_Version";
            label1_Version.Size = new Size(45, 15);
            label1_Version.TabIndex = 5;
            label1_Version.Text = "Version";
            label1_Version.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button2_Close
            // 
            button2_Close.Location = new Point(781, 0);
            button2_Close.Name = "button2_Close";
            button2_Close.Size = new Size(40, 31);
            button2_Close.TabIndex = 0;
            button2_Close.Text = "✕";
            button2_Close.UseVisualStyleBackColor = true;
            // 
            // pdfViewerControl1
            // 
            pdfViewerControl1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            pdfViewerControl1.EnableContextMenu = true;
            pdfViewerControl1.EnableNotificationBar = true;
            pdfViewerControl1.HorizontalScrollOffset = 0;
            pdfViewerControl1.IsBookmarkEnabled = true;
            pdfViewerControl1.IsTextSearchEnabled = true;
            pdfViewerControl1.IsTextSelectionEnabled = true;
            pdfViewerControl1.Location = new Point(0, 37);
            messageBoxSettings1.EnableNotification = true;
            pdfViewerControl1.MessageBoxSettings = messageBoxSettings1;
            pdfViewerControl1.MinimumZoomPercentage = 50;
            pdfViewerControl1.Name = "pdfViewerControl1";
            pdfViewerControl1.PageBorderThickness = 1;
            pdfViewerPrinterSettings1.Copies = 1;
            pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings1.PrintLocation = (PointF)resources.GetObject("pdfViewerPrinterSettings1.PrintLocation");
            pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
            pdfViewerControl1.PrinterSettings = pdfViewerPrinterSettings1;
            pdfViewerControl1.ReferencePath = null;
            pdfViewerControl1.ScrollDisplacementValue = 0;
            pdfViewerControl1.ShowHorizontalScrollBar = true;
            pdfViewerControl1.ShowToolBar = true;
            pdfViewerControl1.ShowVerticalScrollBar = true;
            pdfViewerControl1.Size = new Size(769, 765);
            pdfViewerControl1.SpaceBetweenPages = 8;
            pdfViewerControl1.TabIndex = 3;
            pdfViewerControl1.Text = "pdfViewerControl1";
            textSearchSettings1.CurrentInstanceColor = Color.FromArgb(127, 255, 171, 64);
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = Color.FromArgb(127, 254, 255, 0);
            pdfViewerControl1.TextSearchSettings = textSearchSettings1;
            pdfViewerControl1.VerticalScrollOffset = 0;
            pdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            pdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // Signer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 798);
            Controls.Add(pdfViewerControl1);
            Controls.Add(panel1_Ventana);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Signer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignaBG";
            Load += Signer_Load;
            panel1_Ventana.ResumeLayout(false);
            panel1_Ventana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_ico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1_Ventana;
        private PictureBox pictureBox1_ico;
        private Label label1_Version;
        private Button button2_Close;
        private Button button1_Close;
        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl pdfViewerControl1;
    }
}