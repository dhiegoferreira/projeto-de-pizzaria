namespace projetodepizzaria
{
    partial class TelaLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBancoStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBancoStatus
            // 
            this.txtBancoStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBancoStatus.Location = new System.Drawing.Point(655, 291);
            this.txtBancoStatus.Name = "txtBancoStatus";
            this.txtBancoStatus.Size = new System.Drawing.Size(80, 80);
            this.txtBancoStatus.TabIndex = 1;
            this.txtBancoStatus.Text = "Imagem banco";
            this.txtBancoStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 380);
            this.Controls.Add(this.txtBancoStatus);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Label txtBancoStatus;
    }
}