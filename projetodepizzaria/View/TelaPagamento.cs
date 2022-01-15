using System.Globalization;



namespace DesktopApp
{
    public partial class TelaPagamento : Form
    {
        public TelaPagamento()
        {
            InitializeComponent();
        }


        public static double valorRecebido;


        private void button1_Click(object sender, EventArgs e)
        {
           
            TelaGerarPedido.pedido.FormaPagamento = "";
            TelaGerarPedido.pedido.TotalPedido = 0;
            TelaGerarPedido.pedido.TrocoPedido = 0;
            TelaGerarPedido.listaProdutos.Clear(); //Limpar a lista Produtos    
            TelaGerarPedido.listaQuantidade.Clear(); //Limpar a lista quantidade
            
            Close();
        }

        private void TelaPagamento_Load_1(object sender, EventArgs e)
        {

            //Quando for carregado irá exibir algumas informações
            txtNomeCliente.Text = TelaGerarPedido.nomeCliente;

            //seta o valor total;
            txtValorTotal.Text = (TelaGerarPedido.pedido.TotalPedido + TelaGerarPedido.pedido.TaxaEntrega).ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));



        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaGerarPedido.pedido.FormaPagamento = cboTipoPagamento.SelectedItem.ToString();
            //CHAMAR INSERT DO PEDIDO
            DAOPedidos.CriarPedido(TelaGerarPedido.pedido.TotalPedido, TelaGerarPedido.pedido.PedidoDescricao, TelaGerarPedido.pedido.TaxaEntrega, TelaGerarPedido.pedido.TipoDeVenda, TelaGerarPedido.pedido.FormaPagamento, TelaGerarPedido.pedido.TrocoPedido, TelaGerarPedido.pedido.CodigoCliente, TelaGerarPedido.pedido.CodigoFuncionario, TelaGerarPedido.pedido.CodigoEntregador, TelaGerarPedido.pedido.CodigoEndereco);


            //PEGAR CODIGO DO ULTIMO PEDIDO GERADO
            DAOPedidos.ResgatarCodigoPedido();

            //INSERIR PROTUOS AO PEDIDO (PEDIDO_PRODUTO)  COM BASE NA LISTA
            //LISTA DE PRODUTOS
            //LISTA DE QUANTIDADE;
            int i =0;
            while (i <= (TelaGerarPedido.listaProdutos.Count - 1)){

                DAOPedidos.InserirProdutos(TelaGerarPedido.listaProdutos[i], TelaGerarPedido.listaQuantidade[i]);
                i++;
            }


            //Limpar todos os campos
            TelaGerarPedido.pedido.FormaPagamento = "";
            TelaGerarPedido.pedido.TotalPedido = 0;
            TelaGerarPedido.pedido.TrocoPedido = 0;
            TelaGerarPedido.listaProdutos.Clear(); //Limpar a lista Produtos    
            TelaGerarPedido.listaQuantidade.Clear(); //Limpar a lista quantidade
   
        }

        private void cboTipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoPagamento.SelectedIndex.ToString() == "1" || cboTipoPagamento.SelectedIndex.ToString() == "2")
            {
                TelaGerarPedido.pedido.TrocoPedido = 0.0;
                txtTroco.Text = TelaGerarPedido.pedido.TrocoPedido.ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR"));
                txtValorRec.Text = (TelaGerarPedido.pedido.TotalPedido + TelaGerarPedido.pedido.TaxaEntrega).ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR"));
                txtValorRec.Enabled = false;
                txtTroco.Enabled = false;

            }
            else
            {
                txtTroco.Text = "";
                txtValorRec.Text = "";
                txtValorRec.Enabled = true;
                txtTroco.Enabled = true;
            }
        }


        //------------EVENTOS PARA CONVERSÃO MODEDA-----------------------

        private void txtValorRec_Leave(object sender, EventArgs e)
        {
            if (txtValorRec.Text != "" || txtValorRec.Text == null)
            {

                valorRecebido = Convert.ToDouble(txtValorRec.Text);


                TelaGerarPedido.pedido.TrocoPedido = (valorRecebido) - (TelaGerarPedido.pedido.TotalPedido + TelaGerarPedido.pedido.TaxaEntrega);

                if (TelaGerarPedido.pedido.TrocoPedido < 0)
                {

                    MessageBox.Show("Valor informado menor que o total do pedido");
                    button2.Enabled = false;

                }
                else
                {
                    txtTroco.Text = TelaGerarPedido.pedido.TrocoPedido.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
                    button2.Enabled = true;
                    TelaGerarPedido.pedido.TrocoPedido = 0;
                    txtValorRec.Text = valorRecebido.ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR"));


                }

            } else
            {
                MessageBox.Show("Valor informado não lido.");
            }


        }


    }

}


 
 