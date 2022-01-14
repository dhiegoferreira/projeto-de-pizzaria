using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace DesktopApp
{
    public class DAOPedidos
    {
       
        //----------DEINIÇÃO DE VARIÁVEIS FORA DO ESCOPO DOS MÉTODOS------------
        ///definindo fora da função obter dados
        private static string StringDeConexao = "server=localhost;uid=root;pwd=;database=bancoteste";
        public static string data;
        




        //------------------------SEÇÃO DECONSULTAS--------------------



                                    //TelaGerarPedido

        //Retorna os dados da tabela cliente
        public static void ObterDadosCliente(DataGridView tblClientes)
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);
            string sql = "SELECT c.cli_cod AS Código, c.cli_nome AS Nome, c.cli_telefone AS Telefone FROM clientes AS c";
            try
            {
                conn.Open();

                //Criando um objeto do tipo adaptador de dados e passando a string de consulta e a string de conexao
               MySqlDataAdapter AdatadorDeDados = new MySqlDataAdapter(sql, StringDeConexao);

                //populando dados na tabela
                DataTable table = new DataTable();

                AdatadorDeDados.Fill(table);

                tblClientes.DataSource = table;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }

        }


        public static void PesquisarClienteNome(DataGridView tblClientes, string clienteNome)
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            string sql = "SELECT c.cli_cod AS Código, c.cli_nome AS Nome, c.cli_telefone AS Telefone FROM clientes AS c WHERE c.cli_nome LIKE @clienteNome";

            try
            {
                //CONEXÃO ABERTAR
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@clienteNome", clienteNome);

                MySqlDataAdapter AdatadorDeDados = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                AdatadorDeDados.Fill(table);

                tblClientes.DataSource = table;

            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            } finally
            {
                conn.Close();
            }
        }


        //Busca os dados da tabela produtos do BD e popula na dataGridView

        public static void ObterDadosProdutos(DataGridView tblProdutos)
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);
            string sql = "SELECT prod_cod AS Código, prod_nome AS Nome, prod_categoria AS Categoria, prod_valor_unitario AS Valor, prod_unidademedida AS Medida FROM produtos";

            try
            {
                //Abrindo a conexão com o BD
                conn.Open();

                //Criando um objeto do tipo adaptador de dados e passando a string de consulta e a string de conexao
                MySqlDataAdapter AdatadorDeDados = new MySqlDataAdapter(sql, StringDeConexao);

                //populando dados na tabela
                DataTable table = new DataTable();

                AdatadorDeDados.Fill(table);

                tblProdutos.DataSource = table;
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            } finally
            {
                conn.Close();

            }



        }


        //TELA HISTÓRICO PEDIDO

        //Responsável por retornar o histórico dos pedidos gerados para Tela Histórico Pedidos
        public static void ObterHistorico(DataGridView tblHistorico)
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            string sql = "SELECT p.ped_cod AS Código, p.ped_hora AS Data_Hora, c.cli_nome AS Nome, (p.ped_total + p.ped_taxa_ent) AS ValorTotal, p.ped_tipo_venda AS TipoVenda, f.fun_nome as Funcionario, ent.ent_nome AS Entregador FROM pedidos as p LEFT OUTER JOIN clientes as c ON p.cliente_cli_cod = c.cli_cod LEFT OUTER JOIN funcionarios AS f ON p.funcionario_fun_cod = f.fun_cod LEFT OUTER JOIN entregador as ent ON p.entregador_ent_cod = ent.ent_cod ORDER BY p.ped_cod";


            try
            {
                conn.Open();


                MySqlDataAdapter AdatadorDeDados = new MySqlDataAdapter(sql, conn);

                //populando dados na tabela
                DataTable table = new DataTable();

                AdatadorDeDados.Fill(table);

                tblHistorico.DataSource = table;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }


        }


        public static void VisualizarProdutos(DataGridView tblHistorico, string codigoPedido)
        {
            string sql = "SELECT p.ped_cod AS Código, c.cli_nome AS Nome, i.pedido_cod_produtos AS CodProduto, prod.prod_nome AS Produto, prod.prod_valor_unitario AS Valor FROM pedidos as p LEFT OUTER JOIN clientes as c ON p.cliente_cli_cod = c.cli_cod LEFT OUTER JOIN  pedido_produto AS i ON p.ped_cod = i.pedido_cod_pedidos LEFT OUTER JOIN produtos AS prod ON i.pedido_cod_pedidos = prod.prod_cod WHERE ped_cod=@codigoPedido";

            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@codigoPedido", codigoPedido);

                MySqlDataAdapter AdatadorDeDados = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                AdatadorDeDados.Fill(table);

                tblHistorico.DataSource = table;

            } catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conn.Close();
            }


        }

        //TELA ENTREGA

        public static void ObterEndereco(DataGridView tblClientEnd)
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            string sql = "SELECT end_cod AS Código, end_bairro as Bairro, end_rua AS Rua, end_numero AS Número FROM endereco WHERE cliente_end_fk=@cli_cod";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cli_cod", TelaGerarPedido.pedido.CodigoCliente);

                MySqlDataAdapter AdatadorDeDados = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                AdatadorDeDados.Fill(table);

                tblClientEnd.DataSource = table;


            } catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            } finally
            {
                conn.Close();
            }
        }


        //TELA PAGAMENTO

        
        //Método de inserir o pedido
        public static void CriarPedido(double pedidoTotal, string pedidoDescricao, double pedidoTaxaEnt, string pedidoTipoVenda, string pedidoFormaPag, double pedidoTroco, int clienteCodigo, int funcionarioCodigo, string entregadorCodigo, string enderecoCodigo)
        {

            data = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            string sql = "INSERT INTO pedidos(ped_total, ped_desc, ped_taxa_ent, ped_tipo_venda, ped_forma_pag, ped_troco, ped_status, ped_hora, cliente_cli_cod, funcionario_fun_cod, entregador_ent_cod, endereco_end_cod) VALUES (@pedidoTotal, @pedidoDescricao, @pedidoTaxaEnt, @pedidoTipoVenda, @pedidoFormaPag, @pedidoTroco, @pedidoStatus, @pedidoHora, @clienteCodigo, @funcionarioCodigo, @entregadorCodigo, @enderecoCodigo)";

            try
            {
                //Abrir conexão
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);    
                cmd.Parameters.AddWithValue("@pedidoTotal", pedidoTotal);
                cmd.Parameters.AddWithValue("@pedidoDescricao", pedidoDescricao);
                cmd.Parameters.AddWithValue("@pedidoTaxaEnt", pedidoTaxaEnt);
                cmd.Parameters.AddWithValue("@pedidoTipoVenda", pedidoTipoVenda);
                cmd.Parameters.AddWithValue("@pedidoFormaPag", pedidoFormaPag);
                cmd.Parameters.AddWithValue("@pedidoTroco", pedidoTroco);
                cmd.Parameters.AddWithValue("@pedidoStatus", "Em andamento");
                cmd.Parameters.AddWithValue("@pedidoHora", data);
                cmd.Parameters.AddWithValue("@clienteCodigo", clienteCodigo);
                cmd.Parameters.AddWithValue("@funcionarioCodigo", funcionarioCodigo);
                cmd.Parameters.AddWithValue("@entregadorCodigo", entregadorCodigo);
                cmd.Parameters.AddWithValue("@enderecoCodigo", enderecoCodigo);

                int adicionar = cmd.ExecuteNonQuery();
                if(adicionar > 0)
                {
                    MessageBox.Show("Pedido adicionado com sucesso!");

                }

            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conn.Close();
            }


        }

        //Método para resgatar o último pedido gerado
        public static void ResgatarCodigoPedido() {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            string sql = "SELECT ped_cod from pedidos WHERE ped_cod ORDER BY ped_cod DESC LIMIT 1";

            try
            {
                //Abrir conexão
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    TelaGerarPedido.pedido.CodigoPedido = Convert.ToInt32(rdr[0].ToString());

                }


                rdr.Close();
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conn.Close();
            }





        }

        //Inserindo produtos ao pedido

        public static void InserirProdutos(int codigoProduto, int pedidoQtd)
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            string sql = "INSERT INTO pedido_produto(pedido_cod_pedidos, pedido_cod_produtos, prod_qtd) VALUES(@pedidoCodigo, @codigoProduto, @produtoQtd)";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@pedidoCodigo", TelaGerarPedido.pedido.CodigoPedido);
                cmd.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                cmd.Parameters.AddWithValue("@produtoQtd", pedidoQtd);

                cmd.ExecuteNonQuery();


            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conn.Close();
            }




        }

    }
}
