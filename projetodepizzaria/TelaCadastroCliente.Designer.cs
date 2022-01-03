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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroCliente));
            this.maskTextCliTel = new System.Windows.Forms.MaskedTextBox();
            this.dataGrid_Clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtCliNome = new System.Windows.Forms.TextBox();
            this.txtCliBairro = new System.Windows.Forms.TextBox();
            this.txtCliNumero = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pbSexoImagem = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCliRua = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSexoImagem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskTextCliTel
            // 
            this.maskTextCliTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskTextCliTel.Location = new System.Drawing.Point(496, 291);
            this.maskTextCliTel.Margin = new System.Windows.Forms.Padding(4);
            this.maskTextCliTel.Mask = "(00)00000-0000";
            this.maskTextCliTel.Name = "maskTextCliTel";
            this.maskTextCliTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskTextCliTel.Size = new System.Drawing.Size(268, 26);
            this.maskTextCliTel.TabIndex = 5;
            // 
            // dataGrid_Clientes
            // 
            this.dataGrid_Clientes.AccessibleName = "dataGrid_Clientes";
            this.dataGrid_Clientes.AllowUserToAddRows = false;
            this.dataGrid_Clientes.AllowUserToDeleteRows = false;
            this.dataGrid_Clientes.AllowUserToResizeColumns = false;
            this.dataGrid_Clientes.AllowUserToResizeRows = false;
            this.dataGrid_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Clientes.Location = new System.Drawing.Point(19, 65);
            this.dataGrid_Clientes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_Clientes.MultiSelect = false;
            this.dataGrid_Clientes.Name = "dataGrid_Clientes";
            this.dataGrid_Clientes.ReadOnly = true;
            this.dataGrid_Clientes.RowTemplate.Height = 25;
            this.dataGrid_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Clientes.Size = new System.Drawing.Size(751, 176);
            this.dataGrid_Clientes.TabIndex = 1;
            this.dataGrid_Clientes.TabStop = false;
            this.dataGrid_Clientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_Clientes_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rua:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(404, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(398, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(9, 4);
            this.rbFeminino.Margin = new System.Windows.Forms.Padding(4);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(92, 24);
            this.rbFeminino.TabIndex = 7;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(9, 26);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbMasculino.TabIndex = 8;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtCliNome
            // 
            this.txtCliNome.AcceptsTab = true;
            this.txtCliNome.Location = new System.Drawing.Point(79, 294);
            this.txtCliNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliNome.Name = "txtCliNome";
            this.txtCliNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCliNome.Size = new System.Drawing.Size(268, 26);
            this.txtCliNome.TabIndex = 1;
            // 
            // txtCliBairro
            // 
            this.txtCliBairro.AcceptsTab = true;
            this.txtCliBairro.Location = new System.Drawing.Point(79, 328);
            this.txtCliBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliBairro.Name = "txtCliBairro";
            this.txtCliBairro.Size = new System.Drawing.Size(268, 26);
            this.txtCliBairro.TabIndex = 2;
            // 
            // txtCliNumero
            // 
            this.txtCliNumero.Location = new System.Drawing.Point(496, 325);
            this.txtCliNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliNumero.Name = "txtCliNumero";
            this.txtCliNumero.Size = new System.Drawing.Size(268, 26);
            this.txtCliNumero.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(218, 448);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 80);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(351, 448);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(80, 80);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(474, 448);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(80, 80);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(429, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sexo:";
            // 
            // pbSexoImagem
            // 
            this.pbSexoImagem.Location = new System.Drawing.Point(667, 358);
            this.pbSexoImagem.Name = "pbSexoImagem";
            this.pbSexoImagem.Size = new System.Drawing.Size(110, 110);
            this.pbSexoImagem.TabIndex = 20;
            this.pbSexoImagem.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFeminino);
            this.panel1.Controls.Add(this.rbMasculino);
            this.panel1.Location = new System.Drawing.Point(496, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 55);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(79, 248);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(149, 29);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCliRua
            // 
            this.txtCliRua.AcceptsTab = true;
            this.txtCliRua.Location = new System.Drawing.Point(79, 370);
            this.txtCliRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliRua.Name = "txtCliRua";
            this.txtCliRua.Size = new System.Drawing.Size(268, 26);
            this.txtCliRua.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(763, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 41);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 26);
            this.textBox1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // TelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSexoImagem);
            this.Controls.Add(this.maskTextCliTel);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtCliNumero);
            this.Controls.Add(this.txtCliRua);
            this.Controls.Add(this.txtCliBairro);
            this.Controls.Add(this.txtCliNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_Clientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroCliente";
            this.ShowIcon = false;
            this.Text = "Cadastro Cliente";
            this.Activated += new System.EventHandler(this.TelaCadastroCliente_Activated);
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSexoImagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public  DataGridView dataGrid_Clientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private TextBox txtCliNome;
        private TextBox txtCliBairro;
        private TextBox txtCliNumero;
        private Button btnAdicionar;
        private Button btnAtualizar;
        private Button btnDeletar;
        private Label label6;
        private MaskedTextBox maskTextCliTel;
        private PictureBox pbSexoImagem;
        private Panel panel1;
        private Button btnLimpar;
        private TextBox txtCliRua;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}