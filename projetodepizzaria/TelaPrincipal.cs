using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            CenterToScreen();
        }


        //EVENTO DE INICIALIZAÇÃO DA TELA PRRINCIPAL
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ABRIR TELA CADASTRO CLIENTE
            TelaCadastroCliente telacadcli = new TelaCadastroCliente();
            telacadcli.TopLevel = false;
            desktopPanel.Controls.Add(telacadcli);
            telacadcli.FormBorderStyle = FormBorderStyle.None;
            telacadcli.Show();
            
            
           


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncionario telacadfunc= new TelaCadastroFuncionario();
            telacadfunc.TopLevel = false;
            desktopPanel.Controls.Add(telacadfunc);
            telacadfunc.Show();
            
        }

        private void entregadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroEntregador telacadent = new TelaCadastroEntregador();
            telacadent.TopLevel = false;
            desktopPanel.Controls.Add(telacadent);
            telacadent.Show();

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto telacadprod = new TelaCadastroProduto();
            telacadprod.TopLevel = false;
            desktopPanel.Controls.Add(telacadprod);
            telacadprod.Show();
        }

        private void btnSairPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
