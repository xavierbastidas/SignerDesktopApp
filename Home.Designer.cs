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
            button2_Limpiar = new Button();
            button2_Firmar = new Button();
            groupBox1_BuscarDocumento = new GroupBox();
            label1_DocumentoPdf = new Label();
            label1_ArrastrarDocumento = new Label();
            button1_OpenFileDocumento = new Button();
            groupBox1_DocSelecionados = new GroupBox();
            label1_NumDocumentos = new Label();
            groupBox2_Contrasenia = new GroupBox();
            checkBox1_MostrarContrasenia = new CheckBox();
            label1_Contrasenia = new Label();
            textBox1_Contrasenia = new TextBox();
            groupBox1_BuscarCertificado = new GroupBox();
            label1_CertificadoP12 = new Label();
            label1_ArrastrarCertificado = new Label();
            button1_OpenFileCertificado = new Button();
            panel1_Ventana = new Panel();
            pictureBox1_Icon = new PictureBox();
            label1_VersionApp = new Label();
            button2_Minimizar = new Button();
            button2_Maximizar = new Button();
            button2_Close = new Button();
            toolTip1 = new ToolTip(components);
            panel1_Firmador = new Panel();
            menuStrip1 = new MenuStrip();
            configuracionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            cambiarTemaToolStripMenuItem = new ToolStripMenuItem();
            temaOscuroToolStripMenuItem = new ToolStripMenuItem();
            temaClaroToolStripMenuItem = new ToolStripMenuItem();
            temaSistemaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            versiónToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            groupBox1_BuscarDocumento.SuspendLayout();
            groupBox1_DocSelecionados.SuspendLayout();
            groupBox2_Contrasenia.SuspendLayout();
            groupBox1_BuscarCertificado.SuspendLayout();
            panel1_Ventana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Icon).BeginInit();
            panel1_Firmador.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button2_Limpiar
            // 
            button2_Limpiar.Location = new Point(723, 376);
            button2_Limpiar.Name = "button2_Limpiar";
            button2_Limpiar.Size = new Size(75, 33);
            button2_Limpiar.TabIndex = 10;
            button2_Limpiar.Text = "Limpiar";
            button2_Limpiar.UseVisualStyleBackColor = true;
            button2_Limpiar.Click += button2_Limpiar_Click;
            // 
            // button2_Firmar
            // 
            button2_Firmar.Location = new Point(604, 376);
            button2_Firmar.Name = "button2_Firmar";
            button2_Firmar.Size = new Size(75, 33);
            button2_Firmar.TabIndex = 9;
            button2_Firmar.Text = "Firmar";
            button2_Firmar.UseVisualStyleBackColor = true;
            button2_Firmar.Click += btn_Firmar_Documento;
            // 
            // groupBox1_BuscarDocumento
            // 
            groupBox1_BuscarDocumento.Controls.Add(label1_DocumentoPdf);
            groupBox1_BuscarDocumento.Controls.Add(label1_ArrastrarDocumento);
            groupBox1_BuscarDocumento.Controls.Add(button1_OpenFileDocumento);
            groupBox1_BuscarDocumento.Location = new Point(357, 20);
            groupBox1_BuscarDocumento.Name = "groupBox1_BuscarDocumento";
            groupBox1_BuscarDocumento.Size = new Size(441, 233);
            groupBox1_BuscarDocumento.TabIndex = 8;
            groupBox1_BuscarDocumento.TabStop = false;
            // 
            // label1_DocumentoPdf
            // 
            label1_DocumentoPdf.AutoSize = true;
            label1_DocumentoPdf.Location = new Point(159, 26);
            label1_DocumentoPdf.Name = "label1_DocumentoPdf";
            label1_DocumentoPdf.Size = new Size(99, 15);
            label1_DocumentoPdf.TabIndex = 2;
            label1_DocumentoPdf.Text = "Documentos PDF";
            // 
            // label1_ArrastrarDocumento
            // 
            label1_ArrastrarDocumento.AutoEllipsis = true;
            label1_ArrastrarDocumento.Location = new Point(15, 149);
            label1_ArrastrarDocumento.Name = "label1_ArrastrarDocumento";
            label1_ArrastrarDocumento.Size = new Size(409, 20);
            label1_ArrastrarDocumento.TabIndex = 0;
            label1_ArrastrarDocumento.Text = "También lo puedes arrastrar aquí";
            // 
            // button1_OpenFileDocumento
            // 
            button1_OpenFileDocumento.Location = new Point(126, 73);
            button1_OpenFileDocumento.Name = "button1_OpenFileDocumento";
            button1_OpenFileDocumento.Size = new Size(172, 37);
            button1_OpenFileDocumento.TabIndex = 1;
            button1_OpenFileDocumento.Text = "Buscar Documentos";
            button1_OpenFileDocumento.UseVisualStyleBackColor = true;
            button1_OpenFileDocumento.Click += button1_Click_Buscar_Documentos;
            // 
            // groupBox1_DocSelecionados
            // 
            groupBox1_DocSelecionados.Controls.Add(label1_NumDocumentos);
            groupBox1_DocSelecionados.Location = new Point(19, 270);
            groupBox1_DocSelecionados.Name = "groupBox1_DocSelecionados";
            groupBox1_DocSelecionados.Size = new Size(778, 80);
            groupBox1_DocSelecionados.TabIndex = 7;
            groupBox1_DocSelecionados.TabStop = false;
            // 
            // label1_NumDocumentos
            // 
            label1_NumDocumentos.AutoSize = true;
            label1_NumDocumentos.Location = new Point(17, 29);
            label1_NumDocumentos.Name = "label1_NumDocumentos";
            label1_NumDocumentos.Size = new Size(206, 15);
            label1_NumDocumentos.TabIndex = 0;
            label1_NumDocumentos.Text = "0 DOCUMENTO(S) SELECCIONADO(S)";
            // 
            // groupBox2_Contrasenia
            // 
            groupBox2_Contrasenia.Controls.Add(checkBox1_MostrarContrasenia);
            groupBox2_Contrasenia.Controls.Add(label1_Contrasenia);
            groupBox2_Contrasenia.Controls.Add(textBox1_Contrasenia);
            groupBox2_Contrasenia.Location = new Point(19, 169);
            groupBox2_Contrasenia.Name = "groupBox2_Contrasenia";
            groupBox2_Contrasenia.Size = new Size(328, 84);
            groupBox2_Contrasenia.TabIndex = 6;
            groupBox2_Contrasenia.TabStop = false;
            // 
            // checkBox1_MostrarContrasenia
            // 
            checkBox1_MostrarContrasenia.AutoSize = true;
            checkBox1_MostrarContrasenia.Location = new Point(245, 32);
            checkBox1_MostrarContrasenia.Name = "checkBox1_MostrarContrasenia";
            checkBox1_MostrarContrasenia.Size = new Size(67, 19);
            checkBox1_MostrarContrasenia.TabIndex = 4;
            checkBox1_MostrarContrasenia.Text = "mostrar";
            checkBox1_MostrarContrasenia.UseVisualStyleBackColor = true;
            checkBox1_MostrarContrasenia.CheckedChanged += checkBox1_Contrasenia_CheckedChanged;
            // 
            // label1_Contrasenia
            // 
            label1_Contrasenia.AutoSize = true;
            label1_Contrasenia.Location = new Point(6, 33);
            label1_Contrasenia.Name = "label1_Contrasenia";
            label1_Contrasenia.Size = new Size(67, 15);
            label1_Contrasenia.TabIndex = 3;
            label1_Contrasenia.Text = "Contraseña";
            // 
            // textBox1_Contrasenia
            // 
            textBox1_Contrasenia.Location = new Point(91, 33);
            textBox1_Contrasenia.Name = "textBox1_Contrasenia";
            textBox1_Contrasenia.Size = new Size(148, 23);
            textBox1_Contrasenia.TabIndex = 2;
            textBox1_Contrasenia.UseSystemPasswordChar = true;
            // 
            // groupBox1_BuscarCertificado
            // 
            groupBox1_BuscarCertificado.Controls.Add(label1_CertificadoP12);
            groupBox1_BuscarCertificado.Controls.Add(label1_ArrastrarCertificado);
            groupBox1_BuscarCertificado.Controls.Add(button1_OpenFileCertificado);
            groupBox1_BuscarCertificado.Location = new Point(18, 20);
            groupBox1_BuscarCertificado.Name = "groupBox1_BuscarCertificado";
            groupBox1_BuscarCertificado.Size = new Size(329, 143);
            groupBox1_BuscarCertificado.TabIndex = 5;
            groupBox1_BuscarCertificado.TabStop = false;
            // 
            // label1_CertificadoP12
            // 
            label1_CertificadoP12.AccessibleName = "";
            label1_CertificadoP12.AutoSize = true;
            label1_CertificadoP12.Location = new Point(79, 26);
            label1_CertificadoP12.Name = "label1_CertificadoP12";
            label1_CertificadoP12.Size = new Size(87, 15);
            label1_CertificadoP12.TabIndex = 2;
            label1_CertificadoP12.Text = "Certificado P12";
            // 
            // label1_ArrastrarCertificado
            // 
            label1_ArrastrarCertificado.AccessibleName = "";
            label1_ArrastrarCertificado.AutoEllipsis = true;
            label1_ArrastrarCertificado.Location = new Point(7, 106);
            label1_ArrastrarCertificado.Name = "label1_ArrastrarCertificado";
            label1_ArrastrarCertificado.Size = new Size(306, 20);
            label1_ArrastrarCertificado.TabIndex = 0;
            label1_ArrastrarCertificado.Text = "También lo puedes arrastrar aquí";
            // 
            // button1_OpenFileCertificado
            // 
            button1_OpenFileCertificado.Location = new Point(55, 54);
            button1_OpenFileCertificado.Name = "button1_OpenFileCertificado";
            button1_OpenFileCertificado.Size = new Size(145, 37);
            button1_OpenFileCertificado.TabIndex = 1;
            button1_OpenFileCertificado.Text = "Buscar Certificado";
            button1_OpenFileCertificado.UseVisualStyleBackColor = true;
            button1_OpenFileCertificado.Click += button1_Buscar_Certificado_Click;
            // 
            // panel1_Ventana
            // 
            panel1_Ventana.AutoSize = true;
            panel1_Ventana.Controls.Add(pictureBox1_Icon);
            panel1_Ventana.Controls.Add(label1_VersionApp);
            panel1_Ventana.Controls.Add(button2_Minimizar);
            panel1_Ventana.Controls.Add(button2_Maximizar);
            panel1_Ventana.Controls.Add(button2_Close);
            panel1_Ventana.Dock = DockStyle.Top;
            panel1_Ventana.Location = new Point(0, 0);
            panel1_Ventana.Name = "panel1_Ventana";
            panel1_Ventana.Size = new Size(816, 34);
            panel1_Ventana.TabIndex = 1;
            panel1_Ventana.MouseDown += panel1_MouseDown;
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
            // button2_Minimizar
            // 
            button2_Minimizar.Location = new Point(688, 0);
            button2_Minimizar.Name = "button2_Minimizar";
            button2_Minimizar.Size = new Size(37, 31);
            button2_Minimizar.TabIndex = 4;
            button2_Minimizar.Text = "−";
            toolTip1.SetToolTip(button2_Minimizar, "Minimizar");
            button2_Minimizar.UseVisualStyleBackColor = true;
            button2_Minimizar.Click += button2_Click;
            // 
            // button2_Maximizar
            // 
            button2_Maximizar.Location = new Point(731, 0);
            button2_Maximizar.Name = "button2_Maximizar";
            button2_Maximizar.Size = new Size(39, 31);
            button2_Maximizar.TabIndex = 1;
            button2_Maximizar.Text = "☐";
            toolTip1.SetToolTip(button2_Maximizar, "Maximizar");
            button2_Maximizar.UseVisualStyleBackColor = true;
            button2_Maximizar.Click += button2_Maximizar_Click;
            // 
            // button2_Close
            // 
            button2_Close.Location = new Point(776, 0);
            button2_Close.Name = "button2_Close";
            button2_Close.Size = new Size(40, 31);
            button2_Close.TabIndex = 0;
            button2_Close.Text = "✕";
            toolTip1.SetToolTip(button2_Close, "Cerrar");
            button2_Close.UseVisualStyleBackColor = true;
            button2_Close.Click += button2_Close_Click;
            // 
            // panel1_Firmador
            // 
            panel1_Firmador.Controls.Add(button2_Limpiar);
            panel1_Firmador.Controls.Add(groupBox1_BuscarCertificado);
            panel1_Firmador.Controls.Add(button2_Firmar);
            panel1_Firmador.Controls.Add(groupBox1_BuscarDocumento);
            panel1_Firmador.Controls.Add(groupBox2_Contrasenia);
            panel1_Firmador.Controls.Add(groupBox1_DocSelecionados);
            panel1_Firmador.Location = new Point(0, 57);
            panel1_Firmador.Name = "panel1_Firmador";
            panel1_Firmador.Size = new Size(816, 428);
            panel1_Firmador.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { configuracionToolStripMenuItem, configuraciónToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 34);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(816, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // configuracionToolStripMenuItem
            // 
            configuracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            configuracionToolStripMenuItem.Size = new Size(52, 20);
            configuracionToolStripMenuItem.Text = "Home";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cambiarTemaToolStripMenuItem });
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(95, 20);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // cambiarTemaToolStripMenuItem
            // 
            cambiarTemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temaOscuroToolStripMenuItem, temaClaroToolStripMenuItem, temaSistemaToolStripMenuItem });
            cambiarTemaToolStripMenuItem.Name = "cambiarTemaToolStripMenuItem";
            cambiarTemaToolStripMenuItem.Size = new Size(147, 22);
            cambiarTemaToolStripMenuItem.Text = "CambiarTema";
            // 
            // temaOscuroToolStripMenuItem
            // 
            temaOscuroToolStripMenuItem.Name = "temaOscuroToolStripMenuItem";
            temaOscuroToolStripMenuItem.Size = new Size(145, 22);
            temaOscuroToolStripMenuItem.Text = "Tema oscuro";
            temaOscuroToolStripMenuItem.Click += temaOscuroToolStripMenuItem_Click;
            // 
            // temaClaroToolStripMenuItem
            // 
            temaClaroToolStripMenuItem.Name = "temaClaroToolStripMenuItem";
            temaClaroToolStripMenuItem.Size = new Size(145, 22);
            temaClaroToolStripMenuItem.Text = "Tema claro";
            temaClaroToolStripMenuItem.Click += temaClaroToolStripMenuItem_Click;
            // 
            // temaSistemaToolStripMenuItem
            // 
            temaSistemaToolStripMenuItem.Name = "temaSistemaToolStripMenuItem";
            temaSistemaToolStripMenuItem.Size = new Size(145, 22);
            temaSistemaToolStripMenuItem.Text = "Tema sistema";
            temaSistemaToolStripMenuItem.Click += temaSistemaToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { versiónToolStripMenuItem, ayudaToolStripMenuItem });
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(74, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de ";
            // 
            // versiónToolStripMenuItem
            // 
            versiónToolStripMenuItem.Name = "versiónToolStripMenuItem";
            versiónToolStripMenuItem.Size = new Size(180, 22);
            versiónToolStripMenuItem.Text = "Versión";
            versiónToolStripMenuItem.Click += versiónToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(180, 22);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.Click += comoUsarLaAppToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 487);
            Controls.Add(panel1_Firmador);
            Controls.Add(menuStrip1);
            Controls.Add(panel1_Ventana);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Home_Load;
            groupBox1_BuscarDocumento.ResumeLayout(false);
            groupBox1_BuscarDocumento.PerformLayout();
            groupBox1_DocSelecionados.ResumeLayout(false);
            groupBox1_DocSelecionados.PerformLayout();
            groupBox2_Contrasenia.ResumeLayout(false);
            groupBox2_Contrasenia.PerformLayout();
            groupBox1_BuscarCertificado.ResumeLayout(false);
            groupBox1_BuscarCertificado.PerformLayout();
            panel1_Ventana.ResumeLayout(false);
            panel1_Ventana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Icon).EndInit();
            panel1_Firmador.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1_ArrastrarCertificado;
        private Button button1_OpenFileCertificado;
        private Panel panel2;
        private GroupBox groupBox1_BuscarCertificado;
        private GroupBox groupBox2_Contrasenia;
        private Label label1_Contrasenia;
        private TextBox textBox1_Contrasenia;
        private GroupBox groupBox1_DocSelecionados;
        private Label label1_NumDocumentos;
        private Button button2_Limpiar;
        private Button button2_Firmar;
        private GroupBox groupBox1_BuscarDocumento;
        private Label label1_ArrastrarDocumento;
        private Button button1_OpenFileDocumento;
        private Label label1_CertificadoP12;
        private Label label1_DocumentoPdf;
        private CheckBox checkBox1_MostrarContrasenia;
        private Panel panel1_Ventana;
        private Button button2_Close;
        private Button button2_Minimizar;
        private Button button2_Maximizar;
        private Label label1_VersionApp;
        private ToolTip toolTip1;
        private PictureBox pictureBox1_Icon;
        private Panel panel1_Firmador;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem cambiarTemaToolStripMenuItem;
        private ToolStripMenuItem temaOscuroToolStripMenuItem;
        private ToolStripMenuItem temaClaroToolStripMenuItem;
        private ToolStripMenuItem temaSistemaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem versiónToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
    }
}
