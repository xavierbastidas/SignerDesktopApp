namespace SignaBSG
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            button4_Clear = new Button();
            button3_Sign = new Button();
            groupBox3_SearchDocument = new GroupBox();
            label3_PdfDocument = new Label();
            label4_DragDocument = new Label();
            button2_SearchDocument = new Button();
            groupBox4_SelectedDocuments = new GroupBox();
            label6_SelectedDocuments = new Label();
            groupBox2_EnterPassword = new GroupBox();
            checkBox1_ShowPassword = new CheckBox();
            label5_CertificatePassword = new Label();
            textBox1_EnterPassword = new TextBox();
            groupBox1_SearchCertificate = new GroupBox();
            label1_P12Certificate = new Label();
            label2_DragCertificateHere = new Label();
            button1_SearchCertificate = new Button();
            panel1_Ventana = new Panel();
            pictureBox_AppIcon = new PictureBox();
            label1_AppVersion = new Label();
            button5_Minimize = new Button();
            button6_Maximize = new Button();
            button7_Close = new Button();
            toolTip1 = new ToolTip(components);
            panel1_Signer = new Panel();
            menuStrip1 = new MenuStrip();
            appicationToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            changeThemeToolStripMenuItem = new ToolStripMenuItem();
            darkThemeToolStripMenuItem = new ToolStripMenuItem();
            lightThemeToolStripMenuItem = new ToolStripMenuItem();
            systemThemeToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            appVersionToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            groupBox3_SearchDocument.SuspendLayout();
            groupBox4_SelectedDocuments.SuspendLayout();
            groupBox2_EnterPassword.SuspendLayout();
            groupBox1_SearchCertificate.SuspendLayout();
            panel1_Ventana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_AppIcon).BeginInit();
            panel1_Signer.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button4_Clear
            // 
            button4_Clear.Location = new Point(723, 376);
            button4_Clear.Name = "button4_Clear";
            button4_Clear.Size = new Size(75, 33);
            button4_Clear.TabIndex = 10;
            button4_Clear.Text = "Limpiar";
            button4_Clear.UseVisualStyleBackColor = true;
            button4_Clear.Click += button4_Clear_Click;
            // 
            // button3_Sign
            // 
            button3_Sign.Location = new Point(604, 376);
            button3_Sign.Name = "button3_Sign";
            button3_Sign.Size = new Size(75, 33);
            button3_Sign.TabIndex = 9;
            button3_Sign.Text = "Firmar";
            button3_Sign.UseVisualStyleBackColor = true;
            button3_Sign.Click += button3_Sign_Click;
            // 
            // groupBox3_SearchDocument
            // 
            groupBox3_SearchDocument.Controls.Add(label3_PdfDocument);
            groupBox3_SearchDocument.Controls.Add(label4_DragDocument);
            groupBox3_SearchDocument.Controls.Add(button2_SearchDocument);
            groupBox3_SearchDocument.Location = new Point(357, 20);
            groupBox3_SearchDocument.Name = "groupBox3_SearchDocument";
            groupBox3_SearchDocument.Size = new Size(441, 233);
            groupBox3_SearchDocument.TabIndex = 8;
            groupBox3_SearchDocument.TabStop = false;
            // 
            // label3_PdfDocument
            // 
            label3_PdfDocument.AutoSize = true;
            label3_PdfDocument.Location = new Point(159, 26);
            label3_PdfDocument.Name = "label3_PdfDocument";
            label3_PdfDocument.Size = new Size(99, 15);
            label3_PdfDocument.TabIndex = 2;
            label3_PdfDocument.Text = "Documentos PDF";
            // 
            // label4_DragDocument
            // 
            label4_DragDocument.AutoEllipsis = true;
            label4_DragDocument.Location = new Point(15, 149);
            label4_DragDocument.Name = "label4_DragDocument";
            label4_DragDocument.Size = new Size(409, 20);
            label4_DragDocument.TabIndex = 0;
            label4_DragDocument.Text = "También lo puedes arrastrar aquí";
            // 
            // button2_SearchDocument
            // 
            button2_SearchDocument.Location = new Point(126, 73);
            button2_SearchDocument.Name = "button2_SearchDocument";
            button2_SearchDocument.Size = new Size(172, 37);
            button2_SearchDocument.TabIndex = 1;
            button2_SearchDocument.Text = "Buscar Documentos";
            button2_SearchDocument.UseVisualStyleBackColor = true;
            button2_SearchDocument.Click += button2_SearchDocument_Click;
            // 
            // groupBox4_SelectedDocuments
            // 
            groupBox4_SelectedDocuments.Controls.Add(label6_SelectedDocuments);
            groupBox4_SelectedDocuments.Location = new Point(19, 270);
            groupBox4_SelectedDocuments.Name = "groupBox4_SelectedDocuments";
            groupBox4_SelectedDocuments.Size = new Size(778, 80);
            groupBox4_SelectedDocuments.TabIndex = 7;
            groupBox4_SelectedDocuments.TabStop = false;
            // 
            // label6_SelectedDocuments
            // 
            label6_SelectedDocuments.AutoSize = true;
            label6_SelectedDocuments.Location = new Point(17, 29);
            label6_SelectedDocuments.Name = "label6_SelectedDocuments";
            label6_SelectedDocuments.Size = new Size(206, 15);
            label6_SelectedDocuments.TabIndex = 0;
            label6_SelectedDocuments.Text = "0 DOCUMENTO(S) SELECCIONADO(S)";
            // 
            // groupBox2_EnterPassword
            // 
            groupBox2_EnterPassword.Controls.Add(checkBox1_ShowPassword);
            groupBox2_EnterPassword.Controls.Add(label5_CertificatePassword);
            groupBox2_EnterPassword.Controls.Add(textBox1_EnterPassword);
            groupBox2_EnterPassword.Location = new Point(19, 169);
            groupBox2_EnterPassword.Name = "groupBox2_EnterPassword";
            groupBox2_EnterPassword.Size = new Size(328, 84);
            groupBox2_EnterPassword.TabIndex = 6;
            groupBox2_EnterPassword.TabStop = false;
            // 
            // checkBox1_ShowPassword
            // 
            checkBox1_ShowPassword.AutoSize = true;
            checkBox1_ShowPassword.Location = new Point(245, 32);
            checkBox1_ShowPassword.Name = "checkBox1_ShowPassword";
            checkBox1_ShowPassword.Size = new Size(67, 19);
            checkBox1_ShowPassword.TabIndex = 4;
            checkBox1_ShowPassword.Text = "mostrar";
            checkBox1_ShowPassword.UseVisualStyleBackColor = true;
            checkBox1_ShowPassword.CheckedChanged += checkBox1_ShowPassword_CheckedChanged;
            // 
            // label5_CertificatePassword
            // 
            label5_CertificatePassword.AutoSize = true;
            label5_CertificatePassword.Location = new Point(6, 33);
            label5_CertificatePassword.Name = "label5_CertificatePassword";
            label5_CertificatePassword.Size = new Size(67, 15);
            label5_CertificatePassword.TabIndex = 3;
            label5_CertificatePassword.Text = "Contraseña";
            // 
            // textBox1_EnterPassword
            // 
            textBox1_EnterPassword.Location = new Point(91, 33);
            textBox1_EnterPassword.Name = "textBox1_EnterPassword";
            textBox1_EnterPassword.Size = new Size(148, 23);
            textBox1_EnterPassword.TabIndex = 2;
            textBox1_EnterPassword.UseSystemPasswordChar = true;
            // 
            // groupBox1_SearchCertificate
            // 
            groupBox1_SearchCertificate.Controls.Add(label1_P12Certificate);
            groupBox1_SearchCertificate.Controls.Add(label2_DragCertificateHere);
            groupBox1_SearchCertificate.Controls.Add(button1_SearchCertificate);
            groupBox1_SearchCertificate.Location = new Point(18, 20);
            groupBox1_SearchCertificate.Name = "groupBox1_SearchCertificate";
            groupBox1_SearchCertificate.Size = new Size(329, 143);
            groupBox1_SearchCertificate.TabIndex = 5;
            groupBox1_SearchCertificate.TabStop = false;
            // 
            // label1_P12Certificate
            // 
            label1_P12Certificate.AccessibleName = "";
            label1_P12Certificate.AutoSize = true;
            label1_P12Certificate.Location = new Point(79, 26);
            label1_P12Certificate.Name = "label1_P12Certificate";
            label1_P12Certificate.Size = new Size(87, 15);
            label1_P12Certificate.TabIndex = 2;
            label1_P12Certificate.Text = "Certificado P12";
            // 
            // label2_DragCertificateHere
            // 
            label2_DragCertificateHere.AccessibleName = "";
            label2_DragCertificateHere.AutoEllipsis = true;
            label2_DragCertificateHere.Location = new Point(7, 106);
            label2_DragCertificateHere.Name = "label2_DragCertificateHere";
            label2_DragCertificateHere.Size = new Size(306, 20);
            label2_DragCertificateHere.TabIndex = 0;
            label2_DragCertificateHere.Text = "También lo puedes arrastrar aquí";
            // 
            // button1_SearchCertificate
            // 
            button1_SearchCertificate.Location = new Point(55, 54);
            button1_SearchCertificate.Name = "button1_SearchCertificate";
            button1_SearchCertificate.Size = new Size(145, 37);
            button1_SearchCertificate.TabIndex = 1;
            button1_SearchCertificate.Text = "Buscar Certificado";
            button1_SearchCertificate.UseVisualStyleBackColor = true;
            button1_SearchCertificate.Click += button1_SearchCertificate_Click;
            // 
            // panel1_Ventana
            // 
            panel1_Ventana.AutoSize = true;
            panel1_Ventana.Controls.Add(pictureBox_AppIcon);
            panel1_Ventana.Controls.Add(label1_AppVersion);
            panel1_Ventana.Controls.Add(button5_Minimize);
            panel1_Ventana.Controls.Add(button6_Maximize);
            panel1_Ventana.Controls.Add(button7_Close);
            panel1_Ventana.Dock = DockStyle.Top;
            panel1_Ventana.Location = new Point(0, 0);
            panel1_Ventana.Name = "panel1_Ventana";
            panel1_Ventana.Size = new Size(816, 34);
            panel1_Ventana.TabIndex = 1;
            panel1_Ventana.MouseDown += panel1_MouseDown;
            // 
            // pictureBox_AppIcon
            // 
            pictureBox_AppIcon.Image = Properties.Resources.sgb;
            pictureBox_AppIcon.Location = new Point(4, 8);
            pictureBox_AppIcon.Name = "pictureBox_AppIcon";
            pictureBox_AppIcon.Size = new Size(39, 23);
            pictureBox_AppIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_AppIcon.TabIndex = 6;
            pictureBox_AppIcon.TabStop = false;
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
            // button5_Minimize
            // 
            button5_Minimize.Location = new Point(688, 0);
            button5_Minimize.Name = "button5_Minimize";
            button5_Minimize.Size = new Size(37, 31);
            button5_Minimize.TabIndex = 4;
            button5_Minimize.Text = "−";
            toolTip1.SetToolTip(button5_Minimize, "Minimizar");
            button5_Minimize.UseVisualStyleBackColor = true;
            button5_Minimize.Click += button5_Minimize_Click;
            // 
            // button6_Maximize
            // 
            button6_Maximize.Location = new Point(731, 0);
            button6_Maximize.Name = "button6_Maximize";
            button6_Maximize.Size = new Size(39, 31);
            button6_Maximize.TabIndex = 1;
            button6_Maximize.Text = "☐";
            toolTip1.SetToolTip(button6_Maximize, "Maximizar");
            button6_Maximize.UseVisualStyleBackColor = true;
            button6_Maximize.Click += button6_Maximize_Click;
            // 
            // button7_Close
            // 
            button7_Close.Location = new Point(776, 0);
            button7_Close.Name = "button7_Close";
            button7_Close.Size = new Size(40, 31);
            button7_Close.TabIndex = 0;
            button7_Close.Text = "✕";
            toolTip1.SetToolTip(button7_Close, "Cerrar");
            button7_Close.UseVisualStyleBackColor = true;
            button7_Close.Click += button7_Close_Click;
            // 
            // panel1_Signer
            // 
            panel1_Signer.Controls.Add(button4_Clear);
            panel1_Signer.Controls.Add(groupBox1_SearchCertificate);
            panel1_Signer.Controls.Add(button3_Sign);
            panel1_Signer.Controls.Add(groupBox3_SearchDocument);
            panel1_Signer.Controls.Add(groupBox2_EnterPassword);
            panel1_Signer.Controls.Add(groupBox4_SelectedDocuments);
            panel1_Signer.Location = new Point(0, 57);
            panel1_Signer.Name = "panel1_Signer";
            panel1_Signer.Size = new Size(816, 428);
            panel1_Signer.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { appicationToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 34);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(816, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // appicationToolStripMenuItem
            // 
            appicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            appicationToolStripMenuItem.Name = "appicationToolStripMenuItem";
            appicationToolStripMenuItem.Size = new Size(75, 20);
            appicationToolStripMenuItem.Text = "Aplicación";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Salir";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeThemeToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(95, 20);
            settingsToolStripMenuItem.Text = "Configuración";
            // 
            // changeThemeToolStripMenuItem
            // 
            changeThemeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkThemeToolStripMenuItem, lightThemeToolStripMenuItem, systemThemeToolStripMenuItem });
            changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
            changeThemeToolStripMenuItem.Size = new Size(180, 22);
            changeThemeToolStripMenuItem.Text = "CambiarTema";
            // 
            // darkThemeToolStripMenuItem
            // 
            darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            darkThemeToolStripMenuItem.Size = new Size(180, 22);
            darkThemeToolStripMenuItem.Text = "Tema oscuro";
            darkThemeToolStripMenuItem.Click += darkThemeToolStripMenuItem_Click;
            // 
            // lightThemeToolStripMenuItem
            // 
            lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            lightThemeToolStripMenuItem.Size = new Size(180, 22);
            lightThemeToolStripMenuItem.Text = "Tema claro";
            lightThemeToolStripMenuItem.Click += lightThemeToolStripMenuItem_Click;
            // 
            // systemThemeToolStripMenuItem
            // 
            systemThemeToolStripMenuItem.Name = "systemThemeToolStripMenuItem";
            systemThemeToolStripMenuItem.Size = new Size(180, 22);
            systemThemeToolStripMenuItem.Text = "Tema sistema";
            systemThemeToolStripMenuItem.Click += systemThemeToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { appVersionToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(53, 20);
            helpToolStripMenuItem.Text = "Ayuda";
            // 
            // appVersionToolStripMenuItem
            // 
            appVersionToolStripMenuItem.Name = "appVersionToolStripMenuItem";
            appVersionToolStripMenuItem.Size = new Size(180, 22);
            appVersionToolStripMenuItem.Text = "Versión";
            appVersionToolStripMenuItem.Click += appVersionToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "Acerca de";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 487);
            Controls.Add(panel1_Signer);
            Controls.Add(menuStrip1);
            Controls.Add(panel1_Ventana);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Home_Load;
            groupBox3_SearchDocument.ResumeLayout(false);
            groupBox3_SearchDocument.PerformLayout();
            groupBox4_SelectedDocuments.ResumeLayout(false);
            groupBox4_SelectedDocuments.PerformLayout();
            groupBox2_EnterPassword.ResumeLayout(false);
            groupBox2_EnterPassword.PerformLayout();
            groupBox1_SearchCertificate.ResumeLayout(false);
            groupBox1_SearchCertificate.PerformLayout();
            panel1_Ventana.ResumeLayout(false);
            panel1_Ventana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_AppIcon).EndInit();
            panel1_Signer.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2_DragCertificateHere;
        private Button button1_SearchCertificate;
        private Panel panel2;
        private GroupBox groupBox1_SearchCertificate;
        private GroupBox groupBox2_EnterPassword;
        private Label label5_CertificatePassword;
        private TextBox textBox1_EnterPassword;
        private GroupBox groupBox4_SelectedDocuments;
        private Label label6_SelectedDocuments;
        private Button button4_Clear;
        private Button button3_Sign;
        private GroupBox groupBox3_SearchDocument;
        private Label label4_DragDocument;
        private Button button2_SearchDocument;
        private Label label1_P12Certificate;
        private Label label3_PdfDocument;
        private CheckBox checkBox1_ShowPassword;
        private Panel panel1_Ventana;
        private Button button7_Close;
        private Button button5_Minimize;
        private Button button6_Maximize;
        private Label label1_AppVersion;
        private ToolTip toolTip1;
        private PictureBox pictureBox_AppIcon;
        private Panel panel1_Signer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem appicationToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem changeThemeToolStripMenuItem;
        private ToolStripMenuItem darkThemeToolStripMenuItem;
        private ToolStripMenuItem lightThemeToolStripMenuItem;
        private ToolStripMenuItem systemThemeToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem appVersionToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
