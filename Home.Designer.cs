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
            tabControl1_Firmador = new TabControl();
            tabPage1 = new TabPage();
            button2_Limpiar = new Button();
            button2_Firmar = new Button();
            groupBox1_Buscar_Documentos = new GroupBox();
            label1_Tambien_Busca_Doc = new Label();
            button1 = new Button();
            groupBox1_Doc_Selecionados = new GroupBox();
            label1_Num_Docs = new Label();
            groupBox2_Contrasenia = new GroupBox();
            label1_Contrasenia = new Label();
            textBox1_Contrasenia = new TextBox();
            groupBox1_Buscar_Certificado = new GroupBox();
            label1_Buscar_Certififcado = new Label();
            button1_Buscar_Certificado = new Button();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            cambiarTemaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeLaAppToolStripMenuItem = new ToolStripMenuItem();
            tabControl1_Firmador.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1_Buscar_Documentos.SuspendLayout();
            groupBox1_Doc_Selecionados.SuspendLayout();
            groupBox2_Contrasenia.SuspendLayout();
            groupBox1_Buscar_Certificado.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1_Firmador
            // 
            tabControl1_Firmador.Controls.Add(tabPage1);
            tabControl1_Firmador.Location = new Point(12, 27);
            tabControl1_Firmador.Name = "tabControl1_Firmador";
            tabControl1_Firmador.SelectedIndex = 0;
            tabControl1_Firmador.Size = new Size(776, 433);
            tabControl1_Firmador.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2_Limpiar);
            tabPage1.Controls.Add(button2_Firmar);
            tabPage1.Controls.Add(groupBox1_Buscar_Documentos);
            tabPage1.Controls.Add(groupBox1_Doc_Selecionados);
            tabPage1.Controls.Add(groupBox2_Contrasenia);
            tabPage1.Controls.Add(groupBox1_Buscar_Certificado);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SignaBG v00.1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // button2_Limpiar
            // 
            button2_Limpiar.Location = new Point(658, 362);
            button2_Limpiar.Name = "button2_Limpiar";
            button2_Limpiar.Size = new Size(75, 23);
            button2_Limpiar.TabIndex = 10;
            button2_Limpiar.Text = "Limpiar";
            button2_Limpiar.UseVisualStyleBackColor = true;
            button2_Limpiar.Click += button2_Limpiar_Click;
            // 
            // button2_Firmar
            // 
            button2_Firmar.Location = new Point(545, 362);
            button2_Firmar.Name = "button2_Firmar";
            button2_Firmar.Size = new Size(75, 23);
            button2_Firmar.TabIndex = 9;
            button2_Firmar.Text = "Firmar";
            button2_Firmar.UseVisualStyleBackColor = true;
            button2_Firmar.Click += btn_Firmar_Documento;
            // 
            // groupBox1_Buscar_Documentos
            // 
            groupBox1_Buscar_Documentos.Controls.Add(label1_Tambien_Busca_Doc);
            groupBox1_Buscar_Documentos.Controls.Add(button1);
            groupBox1_Buscar_Documentos.Location = new Point(316, 22);
            groupBox1_Buscar_Documentos.Name = "groupBox1_Buscar_Documentos";
            groupBox1_Buscar_Documentos.Size = new Size(430, 196);
            groupBox1_Buscar_Documentos.TabIndex = 8;
            groupBox1_Buscar_Documentos.TabStop = false;
            // 
            // label1_Tambien_Busca_Doc
            // 
            label1_Tambien_Busca_Doc.AutoSize = true;
            label1_Tambien_Busca_Doc.Location = new Point(126, 123);
            label1_Tambien_Busca_Doc.Name = "label1_Tambien_Busca_Doc";
            label1_Tambien_Busca_Doc.Size = new Size(178, 15);
            label1_Tambien_Busca_Doc.TabIndex = 0;
            label1_Tambien_Busca_Doc.Text = "También lo puedes arrastrar aquí";
            // 
            // button1
            // 
            button1.Location = new Point(126, 62);
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
            groupBox1_Doc_Selecionados.Location = new Point(31, 239);
            groupBox1_Doc_Selecionados.Name = "groupBox1_Doc_Selecionados";
            groupBox1_Doc_Selecionados.Size = new Size(702, 71);
            groupBox1_Doc_Selecionados.TabIndex = 7;
            groupBox1_Doc_Selecionados.TabStop = false;
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
            groupBox2_Contrasenia.Controls.Add(label1_Contrasenia);
            groupBox2_Contrasenia.Controls.Add(textBox1_Contrasenia);
            groupBox2_Contrasenia.Location = new Point(31, 145);
            groupBox2_Contrasenia.Name = "groupBox2_Contrasenia";
            groupBox2_Contrasenia.Size = new Size(266, 73);
            groupBox2_Contrasenia.TabIndex = 6;
            groupBox2_Contrasenia.TabStop = false;
            // 
            // label1_Contrasenia
            // 
            label1_Contrasenia.AutoSize = true;
            label1_Contrasenia.Location = new Point(6, 32);
            label1_Contrasenia.Name = "label1_Contrasenia";
            label1_Contrasenia.Size = new Size(67, 15);
            label1_Contrasenia.TabIndex = 3;
            label1_Contrasenia.Text = "Contraseña";
            // 
            // textBox1_Contrasenia
            // 
            textBox1_Contrasenia.Location = new Point(118, 29);
            textBox1_Contrasenia.Name = "textBox1_Contrasenia";
            textBox1_Contrasenia.Size = new Size(100, 23);
            textBox1_Contrasenia.TabIndex = 2;
            textBox1_Contrasenia.UseSystemPasswordChar = true;
            textBox1_Contrasenia.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1_Buscar_Certificado
            // 
            groupBox1_Buscar_Certificado.Controls.Add(label1_Buscar_Certififcado);
            groupBox1_Buscar_Certificado.Controls.Add(button1_Buscar_Certificado);
            groupBox1_Buscar_Certificado.Location = new Point(30, 22);
            groupBox1_Buscar_Certificado.Name = "groupBox1_Buscar_Certificado";
            groupBox1_Buscar_Certificado.Size = new Size(267, 117);
            groupBox1_Buscar_Certificado.TabIndex = 5;
            groupBox1_Buscar_Certificado.TabStop = false;
            groupBox1_Buscar_Certificado.Enter += groupBox1_Buscar_Certificado_Enter;
            // 
            // label1_Buscar_Certififcado
            // 
            label1_Buscar_Certififcado.AutoSize = true;
            label1_Buscar_Certififcado.Location = new Point(41, 84);
            label1_Buscar_Certififcado.Name = "label1_Buscar_Certififcado";
            label1_Buscar_Certififcado.Size = new Size(178, 15);
            label1_Buscar_Certififcado.TabIndex = 0;
            label1_Buscar_Certififcado.Text = "También lo puedes arrastrar aquí";
            label1_Buscar_Certififcado.Click += label1_Buscar_Certififcado_Click;
            // 
            // button1_Buscar_Certificado
            // 
            button1_Buscar_Certificado.Location = new Point(76, 31);
            button1_Buscar_Certificado.Name = "button1_Buscar_Certificado";
            button1_Buscar_Certificado.Size = new Size(117, 37);
            button1_Buscar_Certificado.TabIndex = 1;
            button1_Buscar_Certificado.Text = "Buscar Certificado";
            button1_Buscar_Certificado.UseVisualStyleBackColor = true;
            button1_Buscar_Certificado.Click += button1_Buscar_Certificado_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, configuraciónToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            cambiarTemaToolStripMenuItem.Name = "cambiarTemaToolStripMenuItem";
            cambiarTemaToolStripMenuItem.Size = new Size(150, 22);
            cambiarTemaToolStripMenuItem.Text = "Cambiar Tema";
            cambiarTemaToolStripMenuItem.Click += cambiarTemaToolStripMenuItem_Click;
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
            acercaDeLaAppToolStripMenuItem.Name = "acercaDeLaAppToolStripMenuItem";
            acercaDeLaAppToolStripMenuItem.Size = new Size(163, 22);
            acercaDeLaAppToolStripMenuItem.Text = "Acerca de la App";
            acercaDeLaAppToolStripMenuItem.Click += acercaDeLaAppToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(tabControl1_Firmador);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "SignaBG v00.1";
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1_Firmador;
        private TabPage tabPage1;
        private Label label1_Buscar_Certififcado;
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem cambiarTemaToolStripMenuItem;
        private ToolStripMenuItem acercaDeLaAppToolStripMenuItem;
    }
}
