using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DesktopApp
{
    public partial class TelaGerarPedido : Form
    {
        public TelaGerarPedido()
        {
            InitializeComponent();
        }

        //Definindo listas e instanciando um objeto do tipo ModelPedido.
        public static ModelPedido pedido = new ModelPedido();
        public static List<Int32> listaProdutos = new List<Int32>();
        public static string nomeCliente;
        public static List<Int32> listaQuantidade = new List<Int32>();

        //Irei fazer um foreach para o comprimento da lista poduto iremos fazer um insert 
     
        
        
        
        //Estrutura condicional para as imagens dos produtos
        public void ImagemProdutos()
        {
            string nomeProduto = tblProdutos.CurrentRow.Cells["Nome"].Value.ToString();

            if (nomeProduto == "Pizza Catupiry")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/Icone-Catupiry.png");

            } else if (nomeProduto == "Pizza Calabresa") {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/Icone-PizzaCalabresa.png");
            } else if (nomeProduto == "Pizza Mussarela")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/Icone-PizzaMussarela.png");

            } else if (nomeProduto == "Pizza Marguerita")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-PizzaMarguerita.png");
            }
            else if (nomeProduto == "Pizza Carne De Sol")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-PizzaCarneSol.png");
            }
            else if (nomeProduto == "Pizza Frango com Bacon")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-PizzaFrangoComBacon.png");
            }
            else if (nomeProduto == "Pizza Palmito")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-PizzaPalmito.png");
            }
            else if (nomeProduto == "Pizza Paulista")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-PizzaPaulista.png");
            }
            else if (nomeProduto == "Pizza Quatro Queijos")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-PizzaQuatroQueijos.png");
            }
            else if (nomeProduto == "Pizza Strongoff de Carne")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-PizzaStrongonoffCarne.png");
            }
            else if (nomeProduto == "Hamburger")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-Hamburger.png");
            }
            else if (nomeProduto == "Pizza Vegetariana")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-PizzaVegetariana.png");
            }
            else if (nomeProduto == "Porção Batata Frita.png")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-PorçãoBatata.png");
            }
            else if (nomeProduto == "Porção de Carne")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-PorçãoCarne.png");

            }
            else if (nomeProduto == "Suco de Laranja")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-SucoLaranja.png");
            }
            else if (nomeProduto == "Suco de Maracujá")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-SucoMaracuja.png");
            }
            else if (nomeProduto == "Suco de Morango")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-SucoMorango.png");
            }
            else if (nomeProduto == "Coca Cola 2L")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-CocaCola.png");
            }
            else if (nomeProduto == "Coca Cola Lata")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-CocaColaLata.png");
            }
            else if (nomeProduto == "Guaraná 2L")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-Guarana");
            }
            else if (nomeProduto == "Guaraná Lata")
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-GuaranaLata.png");
            }
            else if (nomeProduto == "Coca Cola KS")
            {

                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-cocacola290.png");
            }
            else
            {
                pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-fotoproduto.png");
            }
        }


        private void btnSair_Click(object sender, EventArgs e)
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

        private void TelaGerarPedido_Load(object sender, EventArgs e)
        {
            //Quando iniciar a tela devemos ter as informações de cliente e produtos preparadas
            DAOPedidos.ObterDadosCliente(tblClientes);
            DAOPedidos.ObterDadosProdutos(tblProdutos);
            cboTipoVenda.SelectedIndex = 0;
            pbImagem.Image = Image.FromFile(@"C:../../Debug/icone-fotoproduto.png");


        }


        //Ao clicar em alguma linha da tabela iremos pegar o cliente
        private void tblClientes_MouseClick(object sender, MouseEventArgs e)
        {
          DialogResult clienteselecionado = MessageBox.Show("Deseja selecionar o cliente: " + tblClientes.CurrentRow.Cells["Nome"].Value.ToString(), "Atenção", MessageBoxButtons.YesNo);
     
            if(clienteselecionado == DialogResult.Yes)
            {
                pedido.CodigoCliente = Convert.ToInt32(tblClientes.CurrentRow.Cells["Código"].Value.ToString());
                nomeCliente = tblClientes.CurrentRow.Cells["Nome"].Value.ToString();
                
            } else
            {

                //CLIENTE NÃO SELECIONADO
            }
           

        }

        private void tblProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            ImagemProdutos();

            //Quando clicar, teremos que pedir a quatidade do produto
            string qtd = Convert.ToString(Interaction.InputBox("Informe a quantidade \n *Utilize números inteiros", "Atenção"));

            if (qtd != "")
            {

                //Se for diferente de zero então ele vai atualizar o valor e armazenar
                if(Convert.ToDouble(qtd) != 0)
                {
                    pedido.TotalPedido += (Convert.ToDouble(qtd) * Convert.ToDouble(tblProdutos.CurrentRow.Cells["Valor"].Value.ToString()));

                    //Vai adiconar o código de cada produto selecionado na lista de produtos
                    listaProdutos.Add(Convert.ToInt32(tblProdutos.CurrentRow.Cells["Código"].Value.ToString()));

                    //Mostrando na label o valor do pedido até o momento
                    lblValorTotal.Text = pedido.TotalPedido.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));


                    //Começa a adicionar na lista de quantidades cada quantidade do produto selecionado.
                    listaQuantidade.Add(Convert.ToInt32(qtd));


                    //Se não, ele irá receber o próprio valor
                } else
                {
                    pedido.TotalPedido = pedido.TotalPedido;
                }
            } else
            {
                //NENHUM VALOR RECEBIDO
            }

            
        }


       
        //Ao clicar no campos descição o campos é limpado
        private void txtDescricao_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pedido.TipoDeVenda = cboTipoVenda.SelectedItem.ToString();
            pedido.PedidoDescricao = txtDescricao.Text;

            if (pedido.CodigoCliente == null || listaProdutos.Count == 0 || cboTipoVenda.SelectedItem == "Tipo de venda")
            {
                MessageBox.Show("Um ou mais campos não foram preenchidos corretamente");

            }
            else
            {
                //Tela Retirada
                if (cboTipoVenda.SelectedItem == "Retirada")
                {

                    pedido.CodigoEndereco = null;
                    pedido.CodigoEntregador = null;
                    TelaPagamento telapagamento = new TelaPagamento();
                    telapagamento.TopLevel = false;
                    telapagamento.Dock = DockStyle.Fill;
                    TelaLogin.telaprincipal.desktopPanel.Controls.Add(telapagamento);     
                    telapagamento.Show();
                    this.Close();

                }
                else
                {
                    TelaEntrega telaentrega = new TelaEntrega();
                    telaentrega.TopLevel = false;
                    telaentrega.FormBorderStyle = FormBorderStyle.None;
                    telaentrega.Dock = DockStyle.Fill;
                    TelaLogin.telaprincipal.desktopPanel.Controls.Add(telaentrega);
                    telaentrega.Show();
                    this.Close();

                }
            }
        }

        private void txtPesquisaNome_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisaNome.Text = "";

        }

        private void txtPesquisaProd_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisaProd.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DAOPedidos.PesquisarClienteNome(tblClientes, txtPesquisaNome.Text);

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DAOCadastroProduto.PesquisarPorNome(tblProdutos, txtPesquisaProd.Text);
        }

        private void txtPesquisaProd_Leave(object sender, EventArgs e)
        {
            txtPesquisaProd.Text = "Pesquisar por nome";

        }

        private void txtPesquisaNome_Leave(object sender, EventArgs e)
        {
            txtPesquisaNome.Text = "Pesquisar por nome";
        }
    }
}

