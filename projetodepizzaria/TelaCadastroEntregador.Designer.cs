
namespace DesktopApp
{
    partial class TelaCadastroEntregador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroEntregador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tblEntregador = new System.Windows.Forms.DataGridView();
            this.txtEntNome = new System.Windows.Forms.TextBox();
            this.txtEntTelefone = new System.Windows.Forms.TextBox();
            this.txtEntStatus = new System.Windows.Forms.TextBox();
            this.txtEntPesquisar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEntregador)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.tblEntregador);
            this.panel1.Controls.Add(this.txtEntNome);
            this.panel1.Controls.Add(this.txtEntTelefone);
            this.panel1.Controls.Add(this.txtEntStatus);
            this.panel1.Controls.Add(this.txtEntPesquisar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 504);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(618, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "*Campos Obrigatórios";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(501, 419);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(80, 71);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(363, 419);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 71);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(222, 419);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 71);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tblEntregador
            // 
            this.tblEntregador.AllowUserToAddRows = false;
            this.tblEntregador.AllowUserToDeleteRows = false;
            this.tblEntregador.AllowUserToResizeColumns = false;
            this.tblEntregador.AllowUserToResizeRows = false;
            this.tblEntregador.Location = new System.Drawing.Point(43, 242);
            this.tblEntregador.MultiSelect = false;
            this.tblEntregador.Name = "tblEntregador";
            this.tblEntregador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblEntregador.RowTemplate.Height = 25;
            this.tblEntregador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblEntregador.Size = new System.Drawing.Size(700, 137);
            this.tblEntregador.TabIndex = 8;
            this.tblEntregador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tblEntregador_MouseClick);
            // 
            // txtEntNome
            // 
            this.txtEntNome.Location = new System.Drawing.Point(126, 48);
            this.txtEntNome.Name = "txtEntNome";
            this.txtEntNome.Size = new System.Drawing.Size(365, 29);
            this.txtEntNome.TabIndex = 7;
            // 
            // txtEntTelefone
            // 
            this.txtEntTelefone.Location = new System.Drawing.Point(126, 139);
            this.txtEntTelefone.Name = "txtEntTelefone";
            this.txtEntTelefone.Size = new System.Drawing.Size(237, 29);
            this.txtEntTelefone.TabIndex = 6;
            // 
            // txtEntStatus
            // 
            this.txtEntStatus.Location = new System.Drawing.Point(126, 94);
            this.txtEntStatus.Name = "txtEntStatus";
            this.txtEntStatus.Size = new System.Drawing.Size(365, 29);
            this.txtEntStatus.TabIndex = 5;
            // 
            // txtEntPesquisar
            // 
            this.txtEntPesquisar.Location = new System.Drawing.Point(43, 207);
            this.txtEntPesquisar.Name = "txtEntPesquisar";
            this.txtEntPesquisar.Size = new System.Drawing.Size(365, 29);
            this.txtEntPesquisar.TabIndex = 4;
            this.txtEntPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntPesquisar_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(74, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 47);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Nome:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(39, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 24);
            this.label14.TabIndex = 28;
            this.label14.Text = "*";
            // 
            // TelaCadastroEntregador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 501);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroEntregador";
            this.ShowIcon = false;
            this.Text = "Tela Cadastro Entregador";
            this.Load += new System.EventHandler(this.Tela_CadastroEntregador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEntregador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView tblEntregador;
        private TextBox txtEntNome;
        private TextBox txtEntTelefone;
        private TextBox txtEntStatus;
        private TextBox txtEntPesquisar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDeletar;
        private Button btnAlterar;
        private Button btnAdicionar;
        private Label label8;
        private Label label14;
        private PictureBox pictureBox1;
    }
}