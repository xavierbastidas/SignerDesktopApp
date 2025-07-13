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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            tabControl1_Firmador = new TabControl();
            tabPage1 = new TabPage();
            button2_Limpiar = new Button();
            button2_Firmar = new Button();
            groupBox1_Buscar_Documentos = new GroupBox();
            label1_DocumentosPdf = new Label();
            label1_Tambien_Busca_Doc = new Label();
            button1 = new Button();
            groupBox1_Doc_Selecionados = new GroupBox();
            label1_Num_Docs = new Label();
            groupBox2_Contrasenia = new GroupBox();
            checkBox1_Contrasenia = new CheckBox();
            label1_Contrasenia = new Label();
            textBox1_Contrasenia = new TextBox();
            groupBox1_Buscar_Certificado = new GroupBox();
            label1_CertificadoP12 = new Label();
            label1_Arrastre_Certificado = new Label();
            button1_Buscar_Certificado = new Button();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
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
            button2 = new Button();
            tabControl1_Firmador.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1_Buscar_Documentos.SuspendLayout();
            groupBox1_Doc_Selecionados.SuspendLayout();
            groupBox2_Contrasenia.SuspendLayout();
            groupBox1_Buscar_Certificado.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1_Firmador
            // 
            tabControl1_Firmador.Controls.Add(tabPage1);
            tabControl1_Firmador.Location = new Point(4, 58);
            tabControl1_Firmador.Name = "tabControl1_Firmador";
            tabControl1_Firmador.SelectedIndex = 0;
            tabControl1_Firmador.Size = new Size(799, 433);
            tabControl1_Firmador.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(button2_Limpiar);
            tabPage1.Controls.Add(button2_Firmar);
            tabPage1.Controls.Add(groupBox1_Buscar_Documentos);
            tabPage1.Controls.Add(groupBox1_Doc_Selecionados);
            tabPage1.Controls.Add(groupBox2_Contrasenia);
            tabPage1.Controls.Add(groupBox1_Buscar_Certificado);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Firmar documentos";
            tabPage1.Click += tabPage1_Click;
            // 
            // button2_Limpiar
            // 
            button2_Limpiar.Location = new Point(710, 343);
            button2_Limpiar.Name = "button2_Limpiar";
            button2_Limpiar.Size = new Size(75, 33);
            button2_Limpiar.TabIndex = 10;
            button2_Limpiar.Text = "Limpiar";
            button2_Limpiar.UseVisualStyleBackColor = true;
            button2_Limpiar.Click += button2_Limpiar_Click;
            // 
            // button2_Firmar
            // 
            button2_Firmar.Location = new Point(571, 343);
            button2_Firmar.Name = "button2_Firmar";
            button2_Firmar.Size = new Size(75, 33);
            button2_Firmar.TabIndex = 9;
            button2_Firmar.Text = "Firmar";
            button2_Firmar.UseVisualStyleBackColor = true;
            button2_Firmar.Click += btn_Firmar_Documento;
            // 
            // groupBox1_Buscar_Documentos
            // 
            groupBox1_Buscar_Documentos.Controls.Add(label1_DocumentosPdf);
            groupBox1_Buscar_Documentos.Controls.Add(label1_Tambien_Busca_Doc);
            groupBox1_Buscar_Documentos.Controls.Add(button1);
            groupBox1_Buscar_Documentos.Location = new Point(331, 6);
            groupBox1_Buscar_Documentos.Name = "groupBox1_Buscar_Documentos";
            groupBox1_Buscar_Documentos.Size = new Size(454, 222);
            groupBox1_Buscar_Documentos.TabIndex = 8;
            groupBox1_Buscar_Documentos.TabStop = false;
            // 
            // label1_DocumentosPdf
            // 
            label1_DocumentosPdf.AutoSize = true;
            label1_DocumentosPdf.Location = new Point(159, 26);
            label1_DocumentosPdf.Name = "label1_DocumentosPdf";
            label1_DocumentosPdf.Size = new Size(99, 15);
            label1_DocumentosPdf.TabIndex = 2;
            label1_DocumentosPdf.Text = "Documentos PDF";
            // 
            // label1_Tambien_Busca_Doc
            // 
            label1_Tambien_Busca_Doc.AutoEllipsis = true;
            label1_Tambien_Busca_Doc.Location = new Point(15, 149);
            label1_Tambien_Busca_Doc.Name = "label1_Tambien_Busca_Doc";
            label1_Tambien_Busca_Doc.Size = new Size(433, 20);
            label1_Tambien_Busca_Doc.TabIndex = 0;
            label1_Tambien_Busca_Doc.Text = "También lo puedes arrastrar aquí";
            label1_Tambien_Busca_Doc.Click += label1_Tambien_Busca_Doc_Click;
            // 
            // button1
            // 
            button1.Location = new Point(126, 73);
            button1.Name = "button1";
            button1.Size = new Size(172, 37);
            button1.TabIndex = 1;
            button1.Text = "Buscar Documentos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_Buscar_Documentos;
            // 
            // groupBox1_Doc_Selecionados
            // 
            groupBox1_Doc_Selecionados.Controls.Add(label1_Num_Docs);
            groupBox1_Doc_Selecionados.Location = new Point(6, 234);
            groupBox1_Doc_Selecionados.Name = "groupBox1_Doc_Selecionados";
            groupBox1_Doc_Selecionados.Size = new Size(779, 85);
            groupBox1_Doc_Selecionados.TabIndex = 7;
            groupBox1_Doc_Selecionados.TabStop = false;
            groupBox1_Doc_Selecionados.Enter += groupBox1_Doc_Selecionados_Enter;
            // 
            // label1_Num_Docs
            // 
            label1_Num_Docs.AutoSize = true;
            label1_Num_Docs.Location = new Point(18, 19);
            label1_Num_Docs.Name = "label1_Num_Docs";
            label1_Num_Docs.Size = new Size(206, 15);
            label1_Num_Docs.TabIndex = 0;
            label1_Num_Docs.Text = "0 DOCUMENTO(S) SELECCIONADO(S)";
            // 
            // groupBox2_Contrasenia
            // 
            groupBox2_Contrasenia.Controls.Add(checkBox1_Contrasenia);
            groupBox2_Contrasenia.Controls.Add(label1_Contrasenia);
            groupBox2_Contrasenia.Controls.Add(textBox1_Contrasenia);
            groupBox2_Contrasenia.Location = new Point(7, 155);
            groupBox2_Contrasenia.Name = "groupBox2_Contrasenia";
            groupBox2_Contrasenia.Size = new Size(318, 73);
            groupBox2_Contrasenia.TabIndex = 6;
            groupBox2_Contrasenia.TabStop = false;
            // 
            // checkBox1_Contrasenia
            // 
            checkBox1_Contrasenia.AutoSize = true;
            checkBox1_Contrasenia.Location = new Point(245, 32);
            checkBox1_Contrasenia.Name = "checkBox1_Contrasenia";
            checkBox1_Contrasenia.Size = new Size(67, 19);
            checkBox1_Contrasenia.TabIndex = 4;
            checkBox1_Contrasenia.Text = "mostrar";
            checkBox1_Contrasenia.UseVisualStyleBackColor = true;
            checkBox1_Contrasenia.CheckedChanged += checkBox1_Contrasenia_CheckedChanged;
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
            textBox1_Contrasenia.Location = new Point(91, 28);
            textBox1_Contrasenia.Name = "textBox1_Contrasenia";
            textBox1_Contrasenia.Size = new Size(148, 23);
            textBox1_Contrasenia.TabIndex = 2;
            textBox1_Contrasenia.UseSystemPasswordChar = true;
            textBox1_Contrasenia.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1_Buscar_Certificado
            // 
            groupBox1_Buscar_Certificado.Controls.Add(label1_CertificadoP12);
            groupBox1_Buscar_Certificado.Controls.Add(label1_Arrastre_Certificado);
            groupBox1_Buscar_Certificado.Controls.Add(button1_Buscar_Certificado);
            groupBox1_Buscar_Certificado.Location = new Point(6, 6);
            groupBox1_Buscar_Certificado.Name = "groupBox1_Buscar_Certificado";
            groupBox1_Buscar_Certificado.Size = new Size(319, 143);
            groupBox1_Buscar_Certificado.TabIndex = 5;
            groupBox1_Buscar_Certificado.TabStop = false;
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
            // label1_Arrastre_Certificado
            // 
            label1_Arrastre_Certificado.AccessibleName = "";
            label1_Arrastre_Certificado.AutoEllipsis = true;
            label1_Arrastre_Certificado.Location = new Point(7, 106);
            label1_Arrastre_Certificado.Name = "label1_Arrastre_Certificado";
            label1_Arrastre_Certificado.Size = new Size(306, 20);
            label1_Arrastre_Certificado.TabIndex = 0;
            label1_Arrastre_Certificado.Text = "También lo puedes arrastrar aquí";
            label1_Arrastre_Certificado.Click += label1_Buscar_Certififcado_Click;
            // 
            // button1_Buscar_Certificado
            // 
            button1_Buscar_Certificado.Location = new Point(55, 54);
            button1_Buscar_Certificado.Name = "button1_Buscar_Certificado";
            button1_Buscar_Certificado.Size = new Size(145, 37);
            button1_Buscar_Certificado.TabIndex = 1;
            button1_Buscar_Certificado.Text = "Buscar Certificado";
            button1_Buscar_Certificado.UseVisualStyleBackColor = true;
            button1_Buscar_Certificado.Click += button1_Buscar_Certificado_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 23);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, configuraciónToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(3, 31);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(216, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
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
            // 
            // temaClaroToolStripMenuItem
            // 
            temaClaroToolStripMenuItem.Name = "temaClaroToolStripMenuItem";
            temaClaroToolStripMenuItem.Size = new Size(164, 22);
            temaClaroToolStripMenuItem.Text = "Tema claro";
            // 
            // porDefectoToolStripMenuItem
            // 
            porDefectoToolStripMenuItem.Name = "porDefectoToolStripMenuItem";
            porDefectoToolStripMenuItem.Size = new Size(164, 22);
            porDefectoToolStripMenuItem.Text = "Tema del sistema";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeLaAppToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
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
            // 
            // comoUsarLaAppToolStripMenuItem
            // 
            comoUsarLaAppToolStripMenuItem.Name = "comoUsarLaAppToolStripMenuItem";
            comoUsarLaAppToolStripMenuItem.Size = new Size(169, 22);
            comoUsarLaAppToolStripMenuItem.Text = "Como usar la App";
            // 
            // button2
            // 
            button2.Location = new Point(739, 3);
            button2.Name = "button2";
            button2.Size = new Size(60, 16);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 514);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(tabControl1_Firmador);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Load += Home_Load;
            tabControl1_Firmador.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1_Buscar_Documentos.ResumeLayout(false);
            groupBox1_Buscar_Documentos.PerformLayout();
            groupBox1_Doc_Selecionados.ResumeLayout(false);
            groupBox1_Doc_Selecionados.PerformLayout();
            groupBox2_Contrasenia.ResumeLayout(false);
            groupBox2_Contrasenia.PerformLayout();
            groupBox1_Buscar_Certificado.ResumeLayout(false);
            groupBox1_Buscar_Certificado.PerformLayout();
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1_Firmador;
        private TabPage tabPage1;
        private Label label1_Arrastre_Certificado;
        private Button button1_Buscar_Certificado;
        private Panel panel2;
        private GroupBox groupBox1_Buscar_Certificado;
        private GroupBox groupBox2_Contrasenia;
        private Label label1_Contrasenia;
        private TextBox textBox1_Contrasenia;
        private GroupBox groupBox1_Doc_Selecionados;
        private Label label1_Num_Docs;
        private Button button2_Limpiar;
        private Button button2_Firmar;
        private GroupBox groupBox1_Buscar_Documentos;
        private Label label1_Tambien_Busca_Doc;
        private Button button1;
        private Label label1_CertificadoP12;
        private Label label1_DocumentosPdf;
        private CheckBox checkBox1_Contrasenia;
        private Panel panel1;
        private MenuStrip menuStrip1;
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
        private Button button2;
    }
}
