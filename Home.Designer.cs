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
            tabControl1_Firmador = new TabControl();
            tabPage1_FirmarDocumento = new TabPage();
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
            menuStrip1_Herramientas = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            cambiarTemaToolStripMenuItem = new ToolStripMenuItem();
            temaOscuroToolStripMenuItem = new ToolStripMenuItem();
            temaClaroToolStripMenuItem = new ToolStripMenuItem();
            porDefectoToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeLaAppToolStripMenuItem = new ToolStripMenuItem();
            versiónToolStripMenuItem = new ToolStripMenuItem();
            comoUsarLaAppToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(components);
            tabControl1_Firmador.SuspendLayout();
            tabPage1_FirmarDocumento.SuspendLayout();
            groupBox1_BuscarDocumento.SuspendLayout();
            groupBox1_DocSelecionados.SuspendLayout();
            groupBox2_Contrasenia.SuspendLayout();
            groupBox1_BuscarCertificado.SuspendLayout();
            panel1_Ventana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_Icon).BeginInit();
            menuStrip1_Herramientas.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1_Firmador
            // 
            tabControl1_Firmador.Controls.Add(tabPage1_FirmarDocumento);
            tabControl1_Firmador.Location = new Point(0, 61);
            tabControl1_Firmador.Name = "tabControl1_Firmador";
            tabControl1_Firmador.SelectedIndex = 0;
            tabControl1_Firmador.Size = new Size(821, 431);
            tabControl1_Firmador.TabIndex = 0;
            // 
            // tabPage1_FirmarDocumento
            // 
            tabPage1_FirmarDocumento.BackColor = Color.Transparent;
            tabPage1_FirmarDocumento.Controls.Add(button2_Limpiar);
            tabPage1_FirmarDocumento.Controls.Add(button2_Firmar);
            tabPage1_FirmarDocumento.Controls.Add(groupBox1_BuscarDocumento);
            tabPage1_FirmarDocumento.Controls.Add(groupBox1_DocSelecionados);
            tabPage1_FirmarDocumento.Controls.Add(groupBox2_Contrasenia);
            tabPage1_FirmarDocumento.Controls.Add(groupBox1_BuscarCertificado);
            tabPage1_FirmarDocumento.Location = new Point(4, 24);
            tabPage1_FirmarDocumento.Name = "tabPage1_FirmarDocumento";
            tabPage1_FirmarDocumento.Padding = new Padding(3);
            tabPage1_FirmarDocumento.Size = new Size(813, 403);
            tabPage1_FirmarDocumento.TabIndex = 0;
            tabPage1_FirmarDocumento.Text = "Firmar documento";
            tabPage1_FirmarDocumento.Click += tabPage1_Click;
            // 
            // button2_Limpiar
            // 
            button2_Limpiar.Location = new Point(732, 343);
            button2_Limpiar.Name = "button2_Limpiar";
            button2_Limpiar.Size = new Size(75, 33);
            button2_Limpiar.TabIndex = 10;
            button2_Limpiar.Text = "Limpiar";
            button2_Limpiar.UseVisualStyleBackColor = true;
            button2_Limpiar.Click += button2_Limpiar_Click;
            // 
            // button2_Firmar
            // 
            button2_Firmar.Location = new Point(620, 343);
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
            groupBox1_BuscarDocumento.Location = new Point(353, 3);
            groupBox1_BuscarDocumento.Name = "groupBox1_BuscarDocumento";
            groupBox1_BuscarDocumento.Size = new Size(454, 225);
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
            label1_ArrastrarDocumento.Size = new Size(433, 20);
            label1_ArrastrarDocumento.TabIndex = 0;
            label1_ArrastrarDocumento.Text = "También lo puedes arrastrar aquí";
            label1_ArrastrarDocumento.Click += label1_Tambien_Busca_Doc_Click;
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
            groupBox1_DocSelecionados.Location = new Point(6, 234);
            groupBox1_DocSelecionados.Name = "groupBox1_DocSelecionados";
            groupBox1_DocSelecionados.Size = new Size(801, 85);
            groupBox1_DocSelecionados.TabIndex = 7;
            groupBox1_DocSelecionados.TabStop = false;
            groupBox1_DocSelecionados.Enter += groupBox1_Doc_Selecionados_Enter;
            // 
            // label1_NumDocumentos
            // 
            label1_NumDocumentos.AutoSize = true;
            label1_NumDocumentos.Location = new Point(18, 19);
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
            groupBox2_Contrasenia.Location = new Point(7, 155);
            groupBox2_Contrasenia.Name = "groupBox2_Contrasenia";
            groupBox2_Contrasenia.Size = new Size(328, 73);
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
            textBox1_Contrasenia.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1_BuscarCertificado
            // 
            groupBox1_BuscarCertificado.Controls.Add(label1_CertificadoP12);
            groupBox1_BuscarCertificado.Controls.Add(label1_ArrastrarCertificado);
            groupBox1_BuscarCertificado.Controls.Add(button1_OpenFileCertificado);
            groupBox1_BuscarCertificado.Location = new Point(6, 6);
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
            label1_ArrastrarCertificado.Click += label1_Buscar_Certififcado_Click;
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
            panel1_Ventana.Size = new Size(820, 34);
            panel1_Ventana.TabIndex = 1;
            panel1_Ventana.Paint += panel1_Ventana_Paint;
            panel1_Ventana.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1_Icon
            // 
            pictureBox1_Icon.Image = Properties.Resources.image;
            pictureBox1_Icon.Location = new Point(4, 8);
            pictureBox1_Icon.Name = "pictureBox1_Icon";
            pictureBox1_Icon.Size = new Size(39, 23);
            pictureBox1_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1_Icon.TabIndex = 6;
            pictureBox1_Icon.TabStop = false;
            pictureBox1_Icon.Click += pictureBox1_Click;
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
            button2_Minimizar.Location = new Point(690, 0);
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
            button2_Maximizar.Location = new Point(736, 0);
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
            button2_Close.Location = new Point(781, 0);
            button2_Close.Name = "button2_Close";
            button2_Close.Size = new Size(40, 31);
            button2_Close.TabIndex = 0;
            button2_Close.Text = "✕";
            toolTip1.SetToolTip(button2_Close, "Cerrar");
            button2_Close.UseVisualStyleBackColor = true;
            button2_Close.Click += button2_Close_Click;
            // 
            // menuStrip1_Herramientas
            // 
            menuStrip1_Herramientas.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, configuraciónToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1_Herramientas.Location = new Point(0, 34);
            menuStrip1_Herramientas.Name = "menuStrip1_Herramientas";
            menuStrip1_Herramientas.RightToLeft = RightToLeft.No;
            menuStrip1_Herramientas.Size = new Size(820, 24);
            menuStrip1_Herramientas.TabIndex = 3;
            menuStrip1_Herramientas.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cambiarTemaToolStripMenuItem });
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(95, 20);
            configuraciónToolStripMenuItem.Text = "Configuración";
            configuraciónToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cambiarTemaToolStripMenuItem
            // 
            cambiarTemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temaOscuroToolStripMenuItem, temaClaroToolStripMenuItem, porDefectoToolStripMenuItem });
            cambiarTemaToolStripMenuItem.Name = "cambiarTemaToolStripMenuItem";
            cambiarTemaToolStripMenuItem.Size = new Size(150, 22);
            cambiarTemaToolStripMenuItem.Text = "Cambiar Tema";
            // 
            // temaOscuroToolStripMenuItem
            // 
            temaOscuroToolStripMenuItem.Name = "temaOscuroToolStripMenuItem";
            temaOscuroToolStripMenuItem.Size = new Size(164, 22);
            temaOscuroToolStripMenuItem.Text = "Tema oscuro";
            temaOscuroToolStripMenuItem.Click += temaOscuroToolStripMenuItem_Click;
            // 
            // temaClaroToolStripMenuItem
            // 
            temaClaroToolStripMenuItem.Name = "temaClaroToolStripMenuItem";
            temaClaroToolStripMenuItem.Size = new Size(164, 22);
            temaClaroToolStripMenuItem.Text = "Tema claro";
            temaClaroToolStripMenuItem.Click += temaClaroToolStripMenuItem_Click;
            // 
            // porDefectoToolStripMenuItem
            // 
            porDefectoToolStripMenuItem.Name = "porDefectoToolStripMenuItem";
            porDefectoToolStripMenuItem.Size = new Size(164, 22);
            porDefectoToolStripMenuItem.Text = "Tema del sistema";
            porDefectoToolStripMenuItem.Click += porDefectoToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeLaAppToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // acercaDeLaAppToolStripMenuItem
            // 
            acercaDeLaAppToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { versiónToolStripMenuItem, comoUsarLaAppToolStripMenuItem });
            acercaDeLaAppToolStripMenuItem.Name = "acercaDeLaAppToolStripMenuItem";
            acercaDeLaAppToolStripMenuItem.Size = new Size(163, 22);
            acercaDeLaAppToolStripMenuItem.Text = "Acerca de la App";
            // 
            // versiónToolStripMenuItem
            // 
            versiónToolStripMenuItem.Name = "versiónToolStripMenuItem";
            versiónToolStripMenuItem.Size = new Size(169, 22);
            versiónToolStripMenuItem.Text = "Versión";
            versiónToolStripMenuItem.Click += versiónToolStripMenuItem_Click;
            // 
            // comoUsarLaAppToolStripMenuItem
            // 
            comoUsarLaAppToolStripMenuItem.Name = "comoUsarLaAppToolStripMenuItem";
            comoUsarLaAppToolStripMenuItem.Size = new Size(169, 22);
            comoUsarLaAppToolStripMenuItem.Text = "Como usar la App";
            comoUsarLaAppToolStripMenuItem.Click += comoUsarLaAppToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 491);
            Controls.Add(menuStrip1_Herramientas);
            Controls.Add(panel1_Ventana);
            Controls.Add(tabControl1_Firmador);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Home_Load;
            tabControl1_Firmador.ResumeLayout(false);
            tabPage1_FirmarDocumento.ResumeLayout(false);
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
            menuStrip1_Herramientas.ResumeLayout(false);
            menuStrip1_Herramientas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1_Firmador;
        private TabPage tabPage1_FirmarDocumento;
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
        private MenuStrip menuStrip1_Herramientas;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem cambiarTemaToolStripMenuItem;
        private ToolStripMenuItem temaOscuroToolStripMenuItem;
        private ToolStripMenuItem temaClaroToolStripMenuItem;
        private ToolStripMenuItem porDefectoToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeLaAppToolStripMenuItem;
        private ToolStripMenuItem versiónToolStripMenuItem;
        private ToolStripMenuItem comoUsarLaAppToolStripMenuItem;
        private Button button2_Close;
        private Button button2_Minimizar;
        private Button button2_Maximizar;
        private Label label1_VersionApp;
        private ToolTip toolTip1;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private PictureBox pictureBox1_Icon;
    }
}
