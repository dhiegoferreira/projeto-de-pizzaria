namespace DesktopApp
{
    partial class TelaCadastroCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroCliente));
            this.maskTextCliTel = new System.Windows.Forms.MaskedTextBox();
            this.tblClientes = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtCliNome = new System.Windows.Forms.TextBox();
            this.txtCliBairro = new System.Windows.Forms.TextBox();
            this.txtCliNumero = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.pbSexoImagem = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCliRua = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSexoImagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // maskTextCliTel
            // 
            this.maskTextCliTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskTextCliTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskTextCliTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTextCliTel.Location = new System.Drawing.Point(105, 156);
            this.maskTextCliTel.Margin = new System.Windows.Forms.Padding(4);
            this.maskTextCliTel.Mask = "(00)00000-0000";
            this.maskTextCliTel.Name = "maskTextCliTel";
            this.maskTextCliTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskTextCliTel.Size = new System.Drawing.Size(298, 26);
            this.maskTextCliTel.TabIndex = 5;
            // 
            // tblClientes
            // 
            this.tblClientes.AccessibleName = "dataGrid_Clientes";
            this.tblClientes.AllowUserToAddRows = false;
            this.tblClientes.AllowUserToDeleteRows = false;
            this.tblClientes.AllowUserToResizeColumns = false;
            this.tblClientes.AllowUserToResizeRows = false;
            this.tblClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tblClientes.Location = new System.Drawing.Point(7, 45);
            this.tblClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tblClientes.MultiSelect = false;
            this.tblClientes.Name = "tblClientes";
            this.tblClientes.ReadOnly = true;
            this.tblClientes.RowTemplate.Height = 25;
            this.tblClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblClientes.ShowEditingIcon = false;
            this.tblClientes.Size = new System.Drawing.Size(712, 151);
            this.tblClientes.TabIndex = 1;
            this.tblClientes.TabStop = false;
            this.tblClientes.VirtualMode = true;
            this.tblClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_Clientes_MouseClick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNome.Location = new System.Drawing.Point(7, 11);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblBairro.Location = new System.Drawing.Point(7, 46);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(64, 24);
            this.lblBairro.TabIndex = 3;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.BackColor = System.Drawing.Color.Transparent;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRua.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblRua.Location = new System.Drawing.Point(7, 81);
            this.lblRua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(49, 24);
            this.lblRua.TabIndex = 4;
            this.lblRua.Text = "Rua:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNumero.Location = new System.Drawing.Point(4, 119);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(84, 24);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Numero:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTelefone.Location = new System.Drawing.Point(4, 155);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(90, 24);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(9, 4);
            this.rbFeminino.Margin = new System.Windows.Forms.Padding(4);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(92, 24);
            this.rbFeminino.TabIndex = 6;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            this.rbFeminino.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbFeminino_MouseClick);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(9, 26);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbMasculino.TabIndex = 7;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // txtCliNome
            // 
            this.txtCliNome.AcceptsTab = true;
            this.txtCliNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliNome.Location = new System.Drawing.Point(105, 11);
            this.txtCliNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliNome.Name = "txtCliNome";
            this.txtCliNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCliNome.Size = new System.Drawing.Size(298, 26);
            this.txtCliNome.TabIndex = 1;
            // 
            // txtCliBairro
            // 
            this.txtCliBairro.AcceptsTab = true;
            this.txtCliBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliBairro.Location = new System.Drawing.Point(105, 47);
            this.txtCliBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliBairro.Name = "txtCliBairro";
            this.txtCliBairro.Size = new System.Drawing.Size(298, 26);
            this.txtCliBairro.TabIndex = 2;
            // 
            // txtCliNumero
            // 
            this.txtCliNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliNumero.Location = new System.Drawing.Point(105, 119);
            this.txtCliNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliNumero.Name = "txtCliNumero";
            this.txtCliNumero.Size = new System.Drawing.Size(298, 26);
            this.txtCliNumero.TabIndex = 4;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSexo.Location = new System.Drawing.Point(7, 205);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(59, 24);
            this.lblSexo.TabIndex = 7;
            this.lblSexo.Text = "Sexo:";
            // 
            // pbSexoImagem
            // 
            this.pbSexoImagem.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbSexoImagem.InitialImage")));
            this.pbSexoImagem.Location = new System.Drawing.Point(560, 37);
            this.pbSexoImagem.Name = "pbSexoImagem";
            this.pbSexoImagem.Size = new System.Drawing.Size(141, 133);
            this.pbSexoImagem.TabIndex = 20;
            this.pbSexoImagem.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbFeminino);
            this.panel1.Controls.Add(this.rbMasculino);
            this.panel1.Location = new System.Drawing.Point(105, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 55);
            this.panel1.TabIndex = 21;
            // 
            // txtCliRua
            // 
            this.txtCliRua.AcceptsTab = true;
            this.txtCliRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliRua.Location = new System.Drawing.Point(105, 82);
            this.txtCliRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliRua.Name = "txtCliRua";
            this.txtCliRua.Size = new System.Drawing.Size(298, 26);
            this.txtCliRua.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(769, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(43, 43);
            this.btnSair.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnSair, "Botão fechar. ação: fechar a janela interna.");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnDeletar);
            this.panel2.Controls.Add(this.btnAtualizar);
            this.panel2.Controls.Add(this.btnAdicionar);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 640);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblNome);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtCliNome);
            this.panel3.Controls.Add(this.lblBairro);
            this.panel3.Controls.Add(this.txtCliBairro);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pbSexoImagem);
            this.panel3.Controls.Add(this.lblSexo);
            this.panel3.Controls.Add(this.lblRua);
            this.panel3.Controls.Add(this.txtCliRua);
            this.panel3.Controls.Add(this.lblNumero);
            this.panel3.Controls.Add(this.txtCliNumero);
            this.panel3.Controls.Add(this.lblTelefone);
            this.panel3.Controls.Add(this.maskTextCliTel);
            this.panel3.Location = new System.Drawing.Point(32, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 255);
            this.panel3.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "";
            this.pictureBox1.AccessibleName = "";
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(421, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "clique para limpar os campos de inserção de dados");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnPesquisar);
            this.panel4.Controls.Add(this.txtPesquisar);
            this.panel4.Controls.Add(this.tblClientes);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(32, 336);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(731, 198);
            this.panel4.TabIndex = 40;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(386, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(40, 33);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnPesquisar, "Clique para pesquisar por nome");
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(7, 12);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(373, 26);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.Text = "Pesquisar por nome";
            this.toolTip1.SetToolTip(this.txtPesquisar, "campo pesquisa por nome");
            this.txtPesquisar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPesquisar_MouseClick);
            this.txtPesquisar.Leave += new System.EventHandler(this.txtPesquisar_Leave);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Brown;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(536, 551);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(166, 74);
            this.btnDeletar.TabIndex = 37;
            this.btnDeletar.Text = "EXCLUIR";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(318, 551);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(167, 74);
            this.btnAtualizar.TabIndex = 36;
            this.btnAtualizar.Text = "EDITAR";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAtualizar, "Clique para editar os dados do cliente selecionado.");
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(91, 551);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(177, 74);
            this.btnAdicionar.TabIndex = 35;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAdicionar, "clique para adicionar um novo cliente ou endereço. Não esqueça de preencher todos" +
        " os campos");
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Tela Cadastro Cliente";
            // 
            // TelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(812, 640);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro Cliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSexoImagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public  DataGridView tblClientes;
        private Label lblNome;
        private Label lblBairro;
        private Label lblRua;
        private Label lblNumero;
        private Label lblTelefone;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private TextBox txtCliNome;
        private TextBox txtCliBairro;
        private TextBox txtCliNumero;
        private Label lblSexo;
        private MaskedTextBox maskTextCliTel;
        private PictureBox pbSexoImagem;
        private Panel panel1;
        private TextBox txtCliRua;
        private Button btnSair;
        private Panel panel2;
        private Button btnDeletar;
        private Button btnAtualizar;
        private Button btnAdicionar;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel3;
        private ToolTip toolTip1;
        private PictureBox btnPesquisar;
        private TextBox txtPesquisar;
    }
}