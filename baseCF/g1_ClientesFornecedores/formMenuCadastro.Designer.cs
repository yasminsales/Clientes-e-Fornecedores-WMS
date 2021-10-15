
namespace baseCF
{
    partial class formMenuCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuCadastro));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.permissõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnTributo = new System.Windows.Forms.Button();
            this.btnTipoTributoAbrir = new System.Windows.Forms.Button();
            this.btnBanco = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnBairro = new System.Windows.Forms.Button();
            this.btnCIdade = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrDataHora = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1683, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.preferênciasToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Sistema";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.optionToolStripMenuItem.Text = "Sair";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // preferênciasToolStripMenuItem
            // 
            this.preferênciasToolStripMenuItem.Name = "preferênciasToolStripMenuItem";
            this.preferênciasToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.preferênciasToolStripMenuItem.Text = "Preferências";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem1,
            this.permissõesToolStripMenuItem});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.editarToolStripMenuItem.Text = "Usuário";
            // 
            // optionToolStripMenuItem1
            // 
            this.optionToolStripMenuItem1.Name = "optionToolStripMenuItem1";
            this.optionToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.optionToolStripMenuItem1.Text = "Ver matrícula";
            // 
            // permissõesToolStripMenuItem
            // 
            this.permissõesToolStripMenuItem.Name = "permissõesToolStripMenuItem";
            this.permissõesToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.permissõesToolStripMenuItem.Text = "Permissões";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem2});
            this.exibirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.exibirToolStripMenuItem.Text = "Ajuda";
            // 
            // optionToolStripMenuItem2
            // 
            this.optionToolStripMenuItem2.Name = "optionToolStripMenuItem2";
            this.optionToolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.optionToolStripMenuItem2.Text = "Suporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1439, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário: 00000000";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDataHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.Location = new System.Drawing.Point(582, 69);
            this.lblDataHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(173, 28);
            this.lblDataHora.TabIndex = 3;
            this.lblDataHora.Text = "19/05/2021, 00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1437, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "FAWS WMS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(1197, 783);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 37);
            this.button5.TabIndex = 10;
            this.button5.Text = "Menu Principal";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFornecedores);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.btnTributo);
            this.groupBox1.Controls.Add(this.btnTipoTributoAbrir);
            this.groupBox1.Controls.Add(this.btnBanco);
            this.groupBox1.Controls.Add(this.btnStatus);
            this.groupBox1.Controls.Add(this.btnBairro);
            this.groupBox1.Controls.Add(this.btnCIdade);
            this.groupBox1.Controls.Add(this.btnEstado);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(111, 213);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1117, 549);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFornecedores.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedores.Image")));
            this.btnFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedores.Location = new System.Drawing.Point(69, 488);
            this.btnFornecedores.Margin = new System.Windows.Forms.Padding(4);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(207, 47);
            this.btnFornecedores.TabIndex = 9;
            this.btnFornecedores.Text = "      Fornecedores";
            this.btnFornecedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedores.UseVisualStyleBackColor = false;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(69, 433);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(207, 47);
            this.btnCliente.TabIndex = 8;
            this.btnCliente.Text = "      Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnTributo
            // 
            this.btnTributo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTributo.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTributo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTributo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTributo.Image = ((System.Drawing.Image)(resources.GetObject("btnTributo.Image")));
            this.btnTributo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTributo.Location = new System.Drawing.Point(69, 378);
            this.btnTributo.Margin = new System.Windows.Forms.Padding(4);
            this.btnTributo.Name = "btnTributo";
            this.btnTributo.Size = new System.Drawing.Size(207, 47);
            this.btnTributo.TabIndex = 7;
            this.btnTributo.Text = "      Tributo";
            this.btnTributo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTributo.UseVisualStyleBackColor = false;
            this.btnTributo.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnTipoTributoAbrir
            // 
            this.btnTipoTributoAbrir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTipoTributoAbrir.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTipoTributoAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoTributoAbrir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoTributoAbrir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTipoTributoAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoTributoAbrir.Image")));
            this.btnTipoTributoAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoTributoAbrir.Location = new System.Drawing.Point(69, 323);
            this.btnTipoTributoAbrir.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoTributoAbrir.Name = "btnTipoTributoAbrir";
            this.btnTipoTributoAbrir.Size = new System.Drawing.Size(207, 47);
            this.btnTipoTributoAbrir.TabIndex = 6;
            this.btnTipoTributoAbrir.Text = "      Tipo Tributo";
            this.btnTipoTributoAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoTributoAbrir.UseVisualStyleBackColor = false;
            this.btnTipoTributoAbrir.Click += new System.EventHandler(this.btnTipoTributoAbrir_Click);
            // 
            // btnBanco
            // 
            this.btnBanco.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBanco.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanco.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBanco.Image = ((System.Drawing.Image)(resources.GetObject("btnBanco.Image")));
            this.btnBanco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanco.Location = new System.Drawing.Point(69, 268);
            this.btnBanco.Margin = new System.Windows.Forms.Padding(4);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(207, 47);
            this.btnBanco.TabIndex = 5;
            this.btnBanco.Text = "      Banco";
            this.btnBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanco.UseVisualStyleBackColor = false;
            this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStatus.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnStatus.Image")));
            this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.Location = new System.Drawing.Point(69, 213);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(207, 47);
            this.btnStatus.TabIndex = 4;
            this.btnStatus.Text = "      Status Cadastro";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnBairro
            // 
            this.btnBairro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBairro.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBairro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBairro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBairro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBairro.Image = ((System.Drawing.Image)(resources.GetObject("btnBairro.Image")));
            this.btnBairro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBairro.Location = new System.Drawing.Point(69, 158);
            this.btnBairro.Margin = new System.Windows.Forms.Padding(4);
            this.btnBairro.Name = "btnBairro";
            this.btnBairro.Size = new System.Drawing.Size(207, 47);
            this.btnBairro.TabIndex = 3;
            this.btnBairro.Text = "      Bairros";
            this.btnBairro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBairro.UseVisualStyleBackColor = false;
            this.btnBairro.Click += new System.EventHandler(this.btnBairro_Click);
            // 
            // btnCIdade
            // 
            this.btnCIdade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCIdade.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCIdade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCIdade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIdade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCIdade.Image = ((System.Drawing.Image)(resources.GetObject("btnCIdade.Image")));
            this.btnCIdade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCIdade.Location = new System.Drawing.Point(69, 103);
            this.btnCIdade.Margin = new System.Windows.Forms.Padding(4);
            this.btnCIdade.Name = "btnCIdade";
            this.btnCIdade.Size = new System.Drawing.Size(207, 47);
            this.btnCIdade.TabIndex = 2;
            this.btnCIdade.Text = "      Cidades";
            this.btnCIdade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCIdade.UseVisualStyleBackColor = false;
            this.btnCIdade.Click += new System.EventHandler(this.btnCIdade_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEstado.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnEstado.Image")));
            this.btnEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstado.Location = new System.Drawing.Point(69, 49);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(207, 47);
            this.btnEstado.TabIndex = 1;
            this.btnEstado.Text = "      Estados";
            this.btnEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(568, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "FATEC Warehouse System";
            // 
            // tmrDataHora
            // 
            this.tmrDataHora.Enabled = true;
            this.tmrDataHora.Interval = 1;
            this.tmrDataHora.Tick += new System.EventHandler(this.tmrDataHora_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1685, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox4.Location = new System.Drawing.Point(0, 770);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1685, 73);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // formMenuCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1701, 875);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "formMenuCadastro";
            this.Text = "FAWS WMS - Menu de Cadastros";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissõesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnTributo;
        private System.Windows.Forms.Button btnTipoTributoAbrir;
        private System.Windows.Forms.Button btnBanco;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnBairro;
        private System.Windows.Forms.Button btnCIdade;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrDataHora;
    }
}

