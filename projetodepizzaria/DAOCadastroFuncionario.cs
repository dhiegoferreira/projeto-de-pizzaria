using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using static System.Data.DataTable;
using System.Data;

namespace DesktopApp
{
    public class DAOCadastroFuncionario
    {

        //Definindo a string de conexão
        public static string StringDeConexao = "server=localhost;uid=root;pwd=;database=bancoteste";

        //Passando a string de conexão para o objeto MySqlConnectio conn
        public static MySqlConnection conn = new MySqlConnection(StringDeConexao);




        public static void InserirFuncionario(string nome, string cargo, string usuario, string senha, string perfil, string sexo)
        {


            string sql = "INSERT INTO FUNCIONARIOS(fun_nome, fun_cargo, fun_usuario, fun_senha, fun_perfil, fun_sexo) VALUES(@fun_nome,@fun_cargo, @fun_usuario, @fun_senha, @fun_perfil, @fun_sexo)";



            try
            {

                //Abrindo a conexão
                conn.Open();

                //Criando um objeto MySqlCommand responsável pelas instruções
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@fun_nome", nome);
                cmd.Parameters.AddWithValue("@fun_cargo", cargo);
                cmd.Parameters.AddWithValue("@fun_usuario", usuario);
                cmd.Parameters.AddWithValue("@fun_senha", senha);
                cmd.Parameters.AddWithValue("@fun_perfil", perfil);
                cmd.Parameters.AddWithValue("@fun_sexo", sexo);

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



        public static void AlterarFuncionario(string nome, string cargo, string usuario, string senha, string perfil, string sexo, String codigoFuncionario)
        {



            string sql = "UPDATE FUNCIONARIOS SET fun_nome = @fun_nome, fun_cargo = @fun_cargo, " +
                "fun_usuario = @fun_usuario, fun_senha = @fun_senha, fun_perfil = @fun_perfil, fun_sexo=@fun_sexo WHERE fun_cod=@fun_cod ";

           

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fun_nome", nome);
                cmd.Parameters.AddWithValue("@fun_cargo", cargo);
                cmd.Parameters.AddWithValue("@fun_usuario", usuario);
                cmd.Parameters.AddWithValue("@fun_senha", senha);
                cmd.Parameters.AddWithValue("@fun_perfil", perfil);
                cmd.Parameters.AddWithValue("@fun_sexo", sexo);
                cmd.Parameters.AddWithValue("@fun_cod", codigoFuncionario);
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

        public static void ObterDados(DataGridView tblFuncionario)
        {


            string sql = " SELECT fun_cod AS Código, fun_nome as Nome, fun_cargo AS Cargo, fun_usuario AS Usuário, fun_senha AS Senha, fun_perfil AS Perfil, fun_sexo AS Sexo FROM funcionarios";

          

            try
            {
                conn.Open();

                MySqlDataAdapter AdaptadorDeDados = new MySqlDataAdapter(sql, conn);

                DataTable tabela = new DataTable();

                AdaptadorDeDados.Fill(tabela);

                tblFuncionario.DataSource = tabela;


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
















        /*

        public static void pesquisarFuncionario(string nome)
        {

            string sql = " SELECT * FROM FUNCIONARIOS WHERE fun_nome = @fun_nome";

            MySqlConnection conn = new MySqlConnection(StringDeConexao);

            try
            {
                //Abrindo a conexão
                conn.Open();


                //Criando um objeto MySqlCommand responsável pelas instruções
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@fun_nome", nome);

                //Criando um objeto do tipo MySqlDataReader
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    nome = Convert.ToString(rdr["Nome"]);
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

        */
    }

}


