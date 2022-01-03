
namespace DesktopApp
{ 
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSairPrincipal = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDataPrincipal = new System.Windows.Forms.Label();
            this.txtUsuarioNome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCli = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadEnt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadProd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCaixaPed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMonitorPed = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSairPrincipal);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.desktopPanel);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 578);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(853, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSairPrincipal
            // 
            this.btnSairPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSairPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnSairPrincipal.Image")));
            this.btnSairPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairPrincipal.Location = new System.Drawing.Point(961, 529);
            this.btnSairPrincipal.Name = "btnSairPrincipal";
            this.btnSairPrincipal.Size = new System.Drawing.Size(91, 38);
            this.btnSairPrincipal.TabIndex = 6;
            this.btnSairPrincipal.Text = "SAIR";
            this.btnSairPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairPrincipal.UseVisualStyleBackColor = true;
            this.btnSairPrincipal.Click += new System.EventHandler(this.btnSairPrincipal_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtDataPrincipal);
            this.panel3.Controls.Add(this.txtUsuarioNome);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(819, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 100);
            this.panel3.TabIndex = 5;
            // 
            // txtDataPrincipal
            // 
            this.txtDataPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataPrincipal.Location = new System.Drawing.Point(63, 65);
            this.txtDataPrincipal.Name = "txtDataPrincipal";
            this.txtDataPrincipal.Size = new System.Drawing.Size(163, 29);
            this.txtDataPrincipal.TabIndex = 5;
            // 
            // txtUsuarioNome
            // 
            this.txtUsuarioNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuarioNome.Location = new System.Drawing.Point(63, 28);
            this.txtUsuarioNome.Name = "txtUsuarioNome";
            this.txtUsuarioNome.Size = new System.Drawing.Size(163, 22);
            this.txtUsuarioNome.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "DATA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "USER:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(863, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bem Vindo!";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(853, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "SGP";
            // 
            // desktopPanel
            // 
            this.desktopPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.desktopPanel.Location = new System.Drawing.Point(3, 36);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(810, 540);
            this.desktopPanel.TabIndex = 1;
            this.desktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCad,
            this.menuCaixa,
            this.menuMonitor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCad
            // 
            this.menuCad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadCli,
            this.menuCadFunc,
            this.menuCadEnt,
            this.menuCadProd,
            this.clienteToolStripMenuItem});
            this.menuCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuCad.Image = ((System.Drawing.Image)(resources.GetObject("menuCad.Image")));
            this.menuCad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCad.Name = "menuCad";
            this.menuCad.Size = new System.Drawing.Size(126, 37);
            this.menuCad.Text = "Cadastro";
            // 
            // menuCadCli
            // 
            this.menuCadCli.Image = ((System.Drawing.Image)(resources.GetObject("menuCadCli.Image")));
            this.menuCadCli.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCadCli.Name = "menuCadCli";
            this.menuCadCli.Size = new System.Drawing.Size(185, 28);
            this.menuCadCli.Text = "Cliente";
            this.menuCadCli.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // menuCadFunc
            // 
            this.menuCadFunc.Image = ((System.Drawing.Image)(resources.GetObject("menuCadFunc.Image")));
            this.menuCadFunc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCadFunc.Name = "menuCadFunc";
            this.menuCadFunc.Size = new System.Drawing.Size(185, 28);
            this.menuCadFunc.Text = "Funcionário";
            this.menuCadFunc.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // menuCadEnt
            // 
            this.menuCadEnt.Image = ((System.Drawing.Image)(resources.GetObject("menuCadEnt.Image")));
            this.menuCadEnt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCadEnt.Name = "menuCadEnt";
            this.menuCadEnt.Size = new System.Drawing.Size(185, 28);
            this.menuCadEnt.Text = "Entregador";
            this.menuCadEnt.Click += new System.EventHandler(this.entregadorToolStripMenuItem_Click);
            // 
            // menuCadProd
            // 
            this.menuCadProd.Image = ((System.Drawing.Image)(resources.GetObject("menuCadProd.Image")));
            this.menuCadProd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCadProd.Name = "menuCadProd";
            this.menuCadProd.Size = new System.Drawing.Size(185, 28);
            this.menuCadProd.Text = "Produto";
            this.menuCadProd.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // menuCaixa
            // 
            this.menuCaixa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCaixaPed});
            this.menuCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuCaixa.Image = ((System.Drawing.Image)(resources.GetObject("menuCaixa.Image")));
            this.menuCaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCaixa.Name = "menuCaixa";
            this.menuCaixa.Size = new System.Drawing.Size(101, 37);
            this.menuCaixa.Text = "Caixa";
            // 
            // menuCaixaPed
            // 
            this.menuCaixaPed.Image = ((System.Drawing.Image)(resources.GetObject("menuCaixaPed.Image")));
            this.menuCaixaPed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCaixaPed.Name = "menuCaixaPed";
            this.menuCaixaPed.Size = new System.Drawing.Size(215, 36);
            this.menuCaixaPed.Text = "Gerar Pedidos";
            // 
            // menuMonitor
            // 
            this.menuMonitor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMonitorPed});
            this.menuMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuMonitor.Image = ((System.Drawing.Image)(resources.GetObject("menuMonitor.Image")));
            this.menuMonitor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMonitor.Name = "menuMonitor";
            this.menuMonitor.Size = new System.Drawing.Size(216, 37);
            this.menuMonitor.Text = "Monitor de Pedidos";
            // 
            // menuMonitorPed
            // 
            this.menuMonitorPed.Image = ((System.Drawing.Image)(resources.GetObject("menuMonitorPed.Image")));
            this.menuMonitorPed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMonitorPed.Name = "menuMonitorPed";
            this.menuMonitorPed.Size = new System.Drawing.Size(268, 36);
            this.menuMonitorPed.Text = "Historico de Pedidos";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 577);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCad;
        private ToolStripMenuItem menuCadFunc;
        private ToolStripMenuItem menuCadEnt;
        private ToolStripMenuItem menuCadProd;
        private ToolStripMenuItem menuCaixa;
        private ToolStripMenuItem menuCaixaPed;
        private ToolStripMenuItem menuMonitor;
        private ToolStripMenuItem menuMonitorPed;
        private Button btnSairPrincipal;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private ToolStripMenuItem menuCadCli;
        private PictureBox pictureBox1;
        public Label txtUsuarioNome;
        public Label txtDataPrincipal;
        private Panel desktopPanel;
        private ToolStripMenuItem clienteToolStripMenuItem;
    }
}