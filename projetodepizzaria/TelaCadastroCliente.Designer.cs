namespace projetodepizzaria
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
            this.txtCliRua = new System.Windows.Forms.TextBox();
            this.txtCliNumero = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCliTelefone = new System.Windows.Forms.MaskedTextBox();
            this.pbSexoImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSexoImagem)).BeginInit();
            this.SuspendLayout();
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
            this.dataGrid_Clientes.Location = new System.Drawing.Point(13, 13);
            this.dataGrid_Clientes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_Clientes.MultiSelect = false;
            this.dataGrid_Clientes.Name = "dataGrid_Clientes";
            this.dataGrid_Clientes.ReadOnly = true;
            this.dataGrid_Clientes.RowTemplate.Height = 25;
            this.dataGrid_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Clientes.Size = new System.Drawing.Size(768, 163);
            this.dataGrid_Clientes.TabIndex = 1;
            this.dataGrid_Clientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_Clientes_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rua:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(406, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(400, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(479, 325);
            this.rbFeminino.Margin = new System.Windows.Forms.Padding(4);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(92, 24);
            this.rbFeminino.TabIndex = 8;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(479, 357);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbMasculino.TabIndex = 9;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtCliNome
            // 
            this.txtCliNome.Location = new System.Drawing.Point(79, 213);
            this.txtCliNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliNome.Name = "txtCliNome";
            this.txtCliNome.Size = new System.Drawing.Size(268, 26);
            this.txtCliNome.TabIndex = 10;
            // 
            // txtCliBairro
            // 
            this.txtCliBairro.Location = new System.Drawing.Point(79, 254);
            this.txtCliBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliBairro.Name = "txtCliBairro";
            this.txtCliBairro.Size = new System.Drawing.Size(268, 26);
            this.txtCliBairro.TabIndex = 11;
            // 
            // txtCliRua
            // 
            this.txtCliRua.Location = new System.Drawing.Point(79, 294);
            this.txtCliRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliRua.Name = "txtCliRua";
            this.txtCliRua.Size = new System.Drawing.Size(268, 26);
            this.txtCliRua.TabIndex = 12;
            // 
            // txtCliNumero
            // 
            this.txtCliNumero.Location = new System.Drawing.Point(479, 266);
            this.txtCliNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliNumero.Name = "txtCliNumero";
            this.txtCliNumero.Size = new System.Drawing.Size(268, 26);
            this.txtCliNumero.TabIndex = 13;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.AutoSize = true;
            this.btn_Adicionar.Image = global::DesktopApp.Properties.Resources.icone_criar;
            this.btn_Adicionar.Location = new System.Drawing.Point(158, 441);
            this.btn_Adicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(103, 107);
            this.btn_Adicionar.TabIndex = 16;
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Image = global::DesktopApp.Properties.Resources.icone_atualizar;
            this.btn_Atualizar.Location = new System.Drawing.Point(309, 441);
            this.btn_Atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(103, 107);
            this.btn_Atualizar.TabIndex = 17;
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Enabled = false;
            this.btn_Deletar.Image = global::DesktopApp.Properties.Resources.icone_deletar;
            this.btn_Deletar.Location = new System.Drawing.Point(466, 441);
            this.btn_Deletar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(103, 107);
            this.btn_Deletar.TabIndex = 18;
            this.btn_Deletar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(426, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sexo:";
            // 
            // txtCliTelefone
            // 
            this.txtCliTelefone.Location = new System.Drawing.Point(479, 210);
            this.txtCliTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliTelefone.Mask = "(##) #####-####";
            this.txtCliTelefone.Name = "txtCliTelefone";
            this.txtCliTelefone.Size = new System.Drawing.Size(268, 26);
            this.txtCliTelefone.TabIndex = 19;
            // 
            // pbSexoImagem
            // 
            this.pbSexoImagem.Location = new System.Drawing.Point(590, 300);
            this.pbSexoImagem.Name = "pbSexoImagem";
            this.pbSexoImagem.Size = new System.Drawing.Size(157, 139);
            this.pbSexoImagem.TabIndex = 20;
            this.pbSexoImagem.TabStop = false;
            // 
            // TelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 561);
            this.Controls.Add(this.pbSexoImagem);
            this.Controls.Add(this.txtCliTelefone);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txtCliNumero);
            this.Controls.Add(this.txtCliRua);
            this.Controls.Add(this.txtCliBairro);
            this.Controls.Add(this.txtCliNome);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_Clientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaCadastroCliente";
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSexoImagem)).EndInit();
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
        private TextBox txtCliRua;
        private TextBox txtCliNumero;
        private Button btn_Adicionar;
        private Button btn_Atualizar;
        private Button btn_Deletar;
        private Label label6;
        private MaskedTextBox txtCliTelefone;
        private PictureBox pbSexoImagem;
    }
}