using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;

namespace DesktopApp
{
    public partial class TelaEntrega : Form
    {
        public TelaEntrega()
        {
            InitializeComponent();
        }


        public static double TaxaEnt;
        public static TelaPagamento telapagamento;


     
        private void TelaEntrega_Load(object sender, EventArgs e)
        {
            //Quando a tela entrega for carregada
            //Método para SETAR cliente selecionado
            txtNomeCliente.Text = TelaGerarPedido.nomeCliente;

            //BUSCAR ENDEREÇOS
            DAOPedidos.ObterEndereco(tblClientesEnd);


            //BUSCAR ENTREGADORES
            DAOCadastroEntregador.ObterDados(tblEntregador);



        }

        private void tblEntregador_MouseClick(object sender, MouseEventArgs e)
        {

            DialogResult entregadorselecionado = MessageBox.Show("Deseja selecionar o entregador :" + tblEntregador.CurrentRow.Cells["Nome"].Value.ToString(), "Atenção", MessageBoxButtons.YesNo);


            if (entregadorselecionado == DialogResult.Yes)
            {
                
                TelaGerarPedido.pedido.CodigoEntregador = tblEntregador.CurrentRow.Cells["Código"].Value.ToString();


                //FECHA E NÃO SELECIONA NADA
            }
            else
            {

            }



        }



        private void tblClientesEnd_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult enderecoselecionado = MessageBox.Show("Deseja selecionar este endereço? ", "Atenção", MessageBoxButtons.YesNo);

            if (enderecoselecionado == DialogResult.Yes)
            {
                //Pegando o código do endereco selecionado 
                TelaGerarPedido.pedido.CodigoEndereco = tblClientesEnd.CurrentRow.Cells["Código"].Value.ToString();


            }
            else
            {


            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult fecharJanela = MessageBox.Show("Deseja cancelar o pedido e fechar a janela? ", "Atenção", MessageBoxButtons.YesNo);
            if (fecharJanela == DialogResult.Yes)
            {
                TelaGerarPedido.pedido.FormaPagamento = "";
                TelaGerarPedido.pedido.TotalPedido = 0;
                TelaGerarPedido.pedido.TrocoPedido = 0;
                TelaGerarPedido.listaProdutos.Clear(); //Limpar a lista Produtos    
                TelaGerarPedido.listaQuantidade.Clear(); //Limpar a lista quantidade
                this.Dispose();
            }

        }

 

        private void btnProximo_Click_1(object sender, EventArgs e)
        {
            if (txtTaxaEnt.Text != "" || Convert.ToDouble(txtTaxaEnt) != 0)
            {
                TelaGerarPedido.pedido.TaxaEntrega = TaxaEnt;

                //Aqui iremos abri a tela pagamento
                telapagamento = new TelaPagamento();
                telapagamento.TopLevel = false;
                telapagamento.Dock = DockStyle.Fill;
                TelaLogin.telaprincipal.desktopPanel.Controls.Add(telapagamento);
                telapagamento.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("Um ou mais itens não foram preechidos corretamente");

            }
        }

        private void txtTaxaEnt_MouseClick(object sender, MouseEventArgs e)
        {
            txtTaxaEnt.Text = "";
        }

        private void txtPesquisarNomeEnt_Leave(object sender, EventArgs e)
        {
            txtPesquisarNomeEnt.Text = "Pesquisar entregador por nome";
        }

        private void txtPesquisarEndereco_Leave(object sender, EventArgs e)
        {
            txtPesquisarEndereco.Text = "Pesquisar endereco";
        }

        private void txtTaxaEnt_Leave(object sender, EventArgs e)
        {

            TaxaEnt = double.Parse(txtTaxaEnt.Text);

            txtTaxaEnt.Text = TaxaEnt.ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR"));
            


        }

        private void txtPesquisarEndereco_TextChanged(object sender, EventArgs e)
        {
            txtPesquisarEndereco.Text = "";
        }

        private void txtPesquisarNomeEnt_TextChanged(object sender, EventArgs e)
        {
            txtPesquisarNomeEnt.Text = "";
        }
    }
}
