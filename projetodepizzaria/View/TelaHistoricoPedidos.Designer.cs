
namespace DesktopApp
{
    partial class TelaHistoricoPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaHistoricoPedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHistorico = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tblHistorico = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHistorico
            // 
            this.panelHistorico.Controls.Add(this.btnVoltar);
            this.panelHistorico.Controls.Add(this.button2);
            this.panelHistorico.Controls.Add(this.tblHistorico);
            this.panelHistorico.Controls.Add(this.label1);
            this.panelHistorico.Location = new System.Drawing.Point(0, -1);
            this.panelHistorico.Name = "panelHistorico";
            this.panelHistorico.Size = new System.Drawing.Size(815, 640);
            this.panelHistorico.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Enabled = false;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(379, 565);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(64, 64);
            this.btnVoltar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnVoltar, "Botão volta para histórico inicial");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(773, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 44);
            this.button2.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button2, "Botão fechar; fechar janela");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tblHistorico
            // 
            this.tblHistorico.AllowUserToAddRows = false;
            this.tblHistorico.AllowUserToDeleteRows = false;
            this.tblHistorico.AllowUserToResizeRows = false;
            this.tblHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblHistorico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblHistorico.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblHistorico.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblHistorico.Location = new System.Drawing.Point(12, 62);
            this.tblHistorico.Name = "tblHistorico";
            this.tblHistorico.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblHistorico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblHistorico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tblHistorico.RowTemplate.Height = 25;
            this.tblHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblHistorico.ShowCellErrors = false;
            this.tblHistorico.ShowCellToolTips = false;
            this.tblHistorico.ShowEditingIcon = false;
            this.tblHistorico.ShowRowErrors = false;
            this.tblHistorico.Size = new System.Drawing.Size(786, 492);
            this.tblHistorico.TabIndex = 1;
            this.tblHistorico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblHistorico_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Histórico de pedidos";
            // 
            // TelaHistoricoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(815, 640);
            this.Controls.Add(this.panelHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaHistoricoPedidos";
            this.Text = "TelaHistoricoPedidos";
            this.Load += new System.EventHandler(this.TelaHistoricoPedidos_Load);
            this.panelHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHistorico;
        private Label label1;
        private DataGridView tblHistorico;
        private Button button2;
        private ToolTip toolTip1;
        private Button btnVoltar;
    }
}