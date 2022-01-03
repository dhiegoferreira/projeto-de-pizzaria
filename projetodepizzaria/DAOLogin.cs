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
        public static string nomeFunLogado; //Para armazenar o nome do funcionário logado
        public static string data;
        public static string funPerfil;

        //Preparando a string de conexão
        //O local, o tipo e o 
        public static string StringDeConexao = "server=localhost;uid=root; " +
            "pwd=;database=bancoteste";

        //Criando um objeto de conexao do MySqlConnection e passando a string de conexao
        public static MySqlConnection conn = new MySqlConnection(StringDeConexao);




        //Método responsável pela autenticação do usuário no BD
        public static void AutenticarFuncionario(string usuario, string senha){

            //Passando a string SQL para consulta
            string sql = "SELECT fun_usuario, fun_senha, fun_nome, fun_perfil FROM funcionarios WHERE fun_usuario=@funusuario and fun_senha=@funsenha";

            try
            {
                Console.WriteLine("Conectando ao BD e fazendo a autenticação...");
                conn.Open();//Conexão aberta

                //Criando uma instancia do MySqlCommand
                MySqlCommand cmd = new(sql, conn); //simplicada de new MySqlComman(sql, conn);

                cmd.Parameters.AddWithValue("@funusuario", usuario);
                cmd.Parameters.AddWithValue("@funsenha", senha);

                MySqlDataReader rdr = cmd.ExecuteReader();

                //Se rdr.Read() retornar true = encontrar usuário e senha correspondentes, então...

                if (rdr.Read())
                {
                   
                    data = DateTime.Now.ToString("dd/MM/yyyy"); 
                    nomeFunLogado = rdr[2].ToString();
                    funPerfil = rdr[3].ToString();
                    TelaPrincipal telaprincipal = new TelaPrincipal();
                    telaprincipal.Show();

                    if(funPerfil.Equals("admin"))
                    {
                        telaprincipal.txtUsuarioNome.Text = nomeFunLogado;
                        telaprincipal.txtUsuarioNome.ForeColor = System.Drawing.Color.Red;


                    } 

                    telaprincipal.txtDataPrincipal.Text = data;
                    

                } else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
                rdr.Close(); //Encerra a leitura

                
            } catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            } finally
            {
                //Finalizar a conexão
                conn.Close();
              

            }

            

        }



        //Método booleano para alterar o status da sessão do funcionário
        public static bool AtualizarStatus()
        {
            String sql = "UPDATE funcionarios SET fun_status=@fun_status WHERE fun_usuario=@fun_usuario";

            try
            {
                //Abrindo a conexao
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@fun_status", "Conectado");
                cmd.Parameters.AddWithValue("@fun_usuario", nomeFunLogado);


                int adicionar = cmd.ExecuteNonQuery();

                if(adicionar > 0){
                   

                }




                return true;
            } catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            } finally
            {

                conn.Close();

            }

        }



       







    }
}
