using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DesktopApp
{
    class DAOCadastroProduto
    {
        //definindo fora da função obter dados
        public static string StringDeConexao = "server=localhost;uid=root;pwd=;database=bancoteste";
        public static MySqlConnection conn = new MySqlConnection(StringDeConexao);

        public static void CadastrarProduto(String nome, String categoria, string valor_unitario, string descricao,
            string unidademedida)
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            try
            {
                //Abrindo conexão com o BD
                conn.Open();


                string sql = "INSERT INTO produtos(prod_nome, prod_categoria, prod_valor_unitario, prod_descricao, " +
                    "prod_unidademedida) VALUES(@prod_nome, @prod_categoria, @prod_valor_unitario, @prod_descricao, " +
                    "@prod_unidademedida)";


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //Passando os valores para a string sql
                cmd.Parameters.AddWithValue("@prod_nome", nome);
                cmd.Parameters.AddWithValue("@prod_categoria", categoria);
                cmd.Parameters.AddWithValue("@prod_valor_unitario", valor_unitario);
                cmd.Parameters.AddWithValue("@prod_descricao", descricao);
                cmd.Parameters.AddWithValue("@prod_unidademedida", unidademedida);


                //ExecuteNonQuery para inserção, atualização e exclusão de dados 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto adicionado com sucesso!");

                //passando as excessões para uma varivável local ex
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                //Fechando a conexão
                conn.Close();

            }

        }
        
        
        
        public static void AlterarProduto(String nome, String categoria, String valor_unitario, String descricao, string unidademedida, string codigoproduto)
        {

            String sql = "UPDATE produtos SET prod_nome=@prod_nome, prod_categoria=@prod_categoria, prod_valor_unitario=@prod_valor_unitario, prod_descricao=@prod_descricao, prod_unidademedida=@prod_unidademedida WHERE prod_cod=@prod_cod";

            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@prod_nome", nome);
                cmd.Parameters.AddWithValue("@prod_categoria", categoria);
                cmd.Parameters.AddWithValue("@prod_valor_unitario", valor_unitario);
                cmd.Parameters.AddWithValue("@prod_descricao", descricao);
                cmd.Parameters.AddWithValue("@prod_unidademedida", unidademedida);
                cmd.Parameters.AddWithValue("@prod_cod", codigoproduto);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto alterado com sucesso!");



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
        
        
        
        public static void ObterDados(DataGridView tblProduto)
        {
            string sql = "SELECT prod_cod AS Código, prod_nome as Nome, prod_categoria AS Categoria, prod_valor_unitario AS Valor, prod_descricao AS Descrição, prod_unidademedida AS Medida FROM produtos";

            try
            {
                conn.Open();

                MySqlDataAdapter AdaptadorDeDados = new MySqlDataAdapter(sql, conn);

                DataTable tabela = new DataTable();

                AdaptadorDeDados.Fill(tabela);

                tblProduto.DataSource = tabela;


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    
        public static void PesquisarPorNome(DataGridView tblProdutos, string produtoNome)
        {

            string sql = "SELECT prod_cod AS Código, prod_nome as Nome, prod_categoria AS Categoria, prod_valor_unitario AS Valor, prod_descricao AS Descrição, prod_unidademedida AS Medida FROM produtos WHERE prod_nome=@produtoNome";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@produtoNome", produtoNome);

                MySqlDataAdapter AdatadorDeDados = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                AdatadorDeDados.Fill(table);

                tblProdutos.DataSource = table;

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


    }
}

