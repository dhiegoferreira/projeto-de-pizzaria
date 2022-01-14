
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Globalization;
using System.Diagnostics;

namespace DesktopApp
{
    public class DAOCadastroCliente
    {

        public static string codigoEndereco;
        public static string codigoCliente;
        //Definindo a string de conexão fora da função obter dados
        private static string StringDeConexao = "server=localhost;uid=root;pwd=;database=bancoteste";
        

        //-------------------------------INSERÇÃO------------------------------------

  
        //Obter Dados
        public static void ObterDados(DataGridView tblClientes)
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            string sql = "SELECT c.cli_cod AS Código, c.cli_nome AS Nome, e.end_cod AS endCódigo, e.end_bairro AS Bairro, e.end_rua AS Rua, e.end_numero AS Numero, c.cli_telefone AS Telefone, c.cli_sexo AS Sexo FROM clientes AS c LEFT OUTER JOIN endereco AS e ON c.cli_cod = e.cliente_end_fk";

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
            } finally
            {
                conn.Close();

            }

        }

        //Método para adicionar o endereço
        public static void CadastrarEndereco(string bairro, string rua, string numero)
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);
            string sql = "INSERT INTO endereco(end_bairro, end_rua, end_numero, cliente_end_fk) VALUES(@endbairro, @endrua, @endnumero, @cliente_end_fk)";

          

            try
            {
                conn.Open();

                

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@endbairro", bairro);
                cmd.Parameters.AddWithValue("@endrua", rua);
                cmd.Parameters.AddWithValue("@endnumero", numero);
                cmd.Parameters.AddWithValue("@cliente_end_fk", codigoCliente);


                cmd.ExecuteNonQuery();



            } catch (MySqlException ex)
               
            {
                MessageBox.Show(ex.Message);

            } finally
            {
                //vamos fechar apenas quando clicado no botão fechar janela.
                conn.Close();

            }

        }


        //Pegando o último código de endereço gerado.
        public static void ResgatarCodigoEndereco()
        {

            MySqlConnection conn = new MySqlConnection(StringDeConexao);
            string sql = "SELECT end_cod FROM endereco WHERE end_cod ORDER BY end_cod DESC LIMIT 1";

          
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();


                if (rdr.Read())
                {
                    codigoEndereco = rdr[0].ToString();
                    
                } else
                {
                    MessageBox.Show("Não encontramos o código");
                }

            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            } finally
            {
                conn.Close();
            }

        }

        //Cadastra os dados do cliente separadamente.
        public static void CadastrarCliente(string nome, string telefone, string sexo) 
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            string sql = "INSERT INTO clientes(cli_nome, cli_telefone, cli_sexo) VALUES(@nome, @telefone, @sexo)";
          
            try
            {
                //Abrindo conexão com o BD
                conn.Open();

                
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //Passando os valores para a string sql
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@sexo", sexo);
               

                //ExecuteNonQuery para inserção, atualização e exclusão de dados 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente adicionado com sucesso!");

            //passando as excessões para uma varivável local ex
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());

            } finally
            {
                //Fechando a conexão
                conn.Close();

            }

        }

        //Pegando o último código do cliente gerado.
        public static void ResgatarCodigoCliente()
        {

            MySqlConnection conn = new MySqlConnection(StringDeConexao);
            string sql = "SELECT cli_cod FROM clientes WHERE cli_cod ORDER BY cli_cod DESC LIMIT 1";


            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();


                if (rdr.Read())
                {  
                    codigoCliente = rdr[0].ToString();
                }
                else
                {
                    MessageBox.Show("Não encontramos o código");
                }

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


       

        //----------------------ATUALIZAÇÃO---------------------
  

        
       

        public static void AtualizarEndereco(String bairro, String rua, String numero)
        {

            MySqlConnection conn = new MySqlConnection(StringDeConexao);
            string sql = "UPDATE endereco SET end_bairro=@end_bairro, end_rua=@end_rua, end_numero=@end_numero WHERE end_cod=@end_cod";

            try
            {

                //Abrindo a conexão
                conn.Open();
                

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@end_bairro", bairro);
                cmd.Parameters.AddWithValue("@end_rua", rua);
                cmd.Parameters.AddWithValue("@end_numero", numero);
                cmd.Parameters.AddWithValue("@end_cod", codigoEndereco);

                int atualizar = cmd.ExecuteNonQuery();
                if (atualizar > 0)
                {
                    MessageBox.Show("Cliente atualizado com sucesso!");

                }


            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            } finally {
                conn.Close();

            }

        }


        public static void AtualizarCliente(String nome, String telefone, String sexo, string clientecod)
        {

            MySqlConnection conn = new MySqlConnection(StringDeConexao);
            string sql = "UPDATE clientes SET cli_nome=@cli_nome, cli_telefone=@cli_telefone, cli_sexo=@cli_sexo WHERE cli_cod=@cli_cod";

           

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cli_nome", nome);
                cmd.Parameters.AddWithValue("@cli_telefone", telefone);
                cmd.Parameters.AddWithValue("@cli_sexo", sexo);
                cmd.Parameters.AddWithValue("@cli_cod", clientecod);

                cmd.ExecuteNonQuery();

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


        //Verificar se existe um cliente com o mesmo nome E telefone.
        public static bool VerificaDuplicados(string nome, string telefone)
        {

            MySqlConnection conn = new MySqlConnection(StringDeConexao);
            string sql = "SELECT cli_nome, cli_telefone FROM clientes WHERE cli_nome=@cli_nome and cli_telefone=@cli_telefone";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cli_nome", nome);
                cmd.Parameters.AddWithValue("@cli_telefone", telefone);
                
                MySqlDataReader rdr = cmd.ExecuteReader();

                //Se ele encontrar nome, telefone e sexo corresepondentes, então
                if (rdr.Read())
                {
                    Debug.Write("Cliente encontrado!");
                    return true;

                } else
                {
                    return false;
                }
               

            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                conn.Close();
            }
            
        }


        //Recupara o código do cliente pelo nome
        public static void recupararCodCliente(string nomeCli)
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            string sql = "SELECT cli_cod FROM clientes WHERE cli_nome=@cli_nome";

            try
            {
                //Abrir conexão
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cli_nome", nomeCli);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    codigoCliente = rdr[0].ToString();


                }


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





        //--------------------------- PESQUISA -----------------------------------

        public static void ObterClientePesquisa(DataGridView tblClientes)
        {
            MySqlConnection conn = new MySqlConnection(StringDeConexao);
            MessageBox.Show("O código do cliente é:" + codigoCliente);
            string sql = "SELECT c.cli_cod AS Código, c.cli_nome AS Nome, e.end_cod AS endCódigo, end_bairro AS Bairro, end_rua AS Rua, end_numero AS Numero, c.cli_telefone AS Telefone, c.cli_sexo AS Sexo FROM clientes AS c LEFT OUTER JOIN endereco AS e ON c.cli_cod = e.cliente_end_fk WHERE c.cli_cod=@cli_cod";

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cli_cod", codigoCliente);

                MySqlDataAdapter AdatadorDeDados = new MySqlDataAdapter(cmd);

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


    }





}
     
