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
    public partial class TelaHistoricoPedidos : Form
    {
        public TelaHistoricoPedidos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void TelaHistoricoPedidos_Load(object sender, EventArgs e)
        {
            //Chamar o método do Histórico
            DAOPedidos.ObterHistorico(tblHistorico);



        }

        private void tblHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esse evento serve para mudar a visualização dos pedidos;
            DAOPedidos.VisualizarProdutos(tblHistorico, tblHistorico.CurrentRow.Cells["Código"].Value.ToString());

            btnVoltar.Enabled = true;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DAOPedidos.ObterHistorico(tblHistorico);
            btnVoltar.Enabled = false;
        }
    }
}
