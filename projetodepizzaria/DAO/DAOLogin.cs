using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;



//Esta classe é responsável por fazer a conexao com o banco de dados

namespace DesktopApp
{
   
    public class DAOLogin
    {
        //------------DECLARANDO VARIÁVEIS -----------------

        public static string nomeFunLogado; //Para armazenar o nome do funcionário logado
        public static string data;
        public static string funPerfil;
     
        
       

        
        public static string StringDeConexao = "server=localhost;uid=root; " +
            "pwd=;database=bancoteste";

        //Criando um objeto de conexao do MySqlConnection e passando a string de conexao
        public static MySqlConnection conn = new MySqlConnection(StringDeConexao);





        //-------------MÉTODOS DE CONSULTA AO BANCO -----------------------

        //Método responsável pela autenticação do usuário no BD
        public static bool AutenticarFuncionario(string usuario, string senha){

            //Passando a string SQL para consulta
            string sql = "SELECT fun_cod, fun_nome, fun_usuario, fun_senha, fun_perfil FROM funcionarios WHERE fun_usuario=@funusuario and fun_senha=@funsenha";

            try
            {
                Console.WriteLine("Conectando ao BD e fazendo a autenticação...");
                conn.Open();//Conexão aberta

                //Criando uma instancia do MySqlCommand
                MySqlCommand cmd = new(sql, conn);

                cmd.Parameters.AddWithValue("@funusuario", usuario);
                cmd.Parameters.AddWithValue("@funsenha", senha);

                MySqlDataReader rdr = cmd.ExecuteReader();

                //Se rdr.Read() retornar true = encontrar usuário e senha correspondentes, então...

                if (rdr.Read())
                {
                    // Armazenando a data atual
                     data = DateTime.Now.ToString("dd/MM/yyyy");

                    TelaGerarPedido.pedido.CodigoFuncionario = Convert.ToInt32(rdr[0].ToString());

                    nomeFunLogado = rdr[1].ToString();

                    funPerfil = rdr[4].ToString();

                    if (funPerfil.Equals("admin"))
                    {
                        TelaLogin.telaprincipal.txtUsuarioNome.Text = nomeFunLogado;
                        TelaLogin.telaprincipal.txtUsuarioNome.ForeColor = System.Drawing.Color.Red;
                       



                    } else
                    {
                        TelaLogin.telaprincipal.txtUsuarioNome.Text = nomeFunLogado;
                        TelaLogin.telaprincipal.menuCadFunc.Enabled = false;
                        TelaLogin.telaprincipal.menuCadEnt.Enabled = false;
                        TelaLogin.telaprincipal.menuCadProd.Enabled = false;

                    }

                    
                    TelaLogin.telaprincipal.txtDataPrincipal.Text = data;
                    return true;
                } else
                {
                   
                    return false;
                }


                rdr.Close(); //Encerra a leitura

                
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            } finally
            {
                //Finalizar a conexão
                conn.Close();
              

            }
        }



        //Método booleano para alterar o status da sessão do funcionário
        public static void AtualizarStatusAtivado()
        {
            String sql = "UPDATE funcionarios SET fun_status=@fun_status WHERE fun_usuario=@fun_usuario";

            try
            {
                //Abrindo a conexao
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@fun_status", "Conectado");
                cmd.Parameters.AddWithValue("@fun_usuario", nomeFunLogado);
                cmd.ExecuteNonQuery();
            } catch (MySqlException ex)
            {

            } finally
            {
                conn.Close();

            }

        }


        public static void AtualizarStatusDesativado()
        {
            String sql = "UPDATE funcionarios SET fun_status=@fun_status WHERE fun_usuario=@fun_usuario";

            try
            {
                //Abrindo a conexao
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@fun_status", "Desconectado");
                cmd.Parameters.AddWithValue("@fun_usuario", nomeFunLogado);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                conn.Close();

            }





        }


       







    }
}
