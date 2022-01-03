using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Globalization;


namespace DesktopApp
{
    public class DAOCadastroEntregador
    {
        //definindo fora da função obter dados
        public static string StringDeConexao = "server=localhost;uid=root;pwd=;database=bancoteste";

        public static MySqlConnection conn = new MySqlConnection(StringDeConexao);



        //Método para popular os dados do BD na DataGriView
        public static void ObterDados(DataGridView tblEntregador)
        {
            string sql = "SELECT ent_cod AS Código, ent_nome AS Nome, ent_status AS Status, ent_telefone AS Telefone  FROM entregador";

         

            try
            {
                conn.Open();

                //Criando um objeto do tipo adaptador de dados e passando a string de consulta e a string de conexao
                MySqlDataAdapter AdatadorDeDados = new MySqlDataAdapter(sql, StringDeConexao);

                //populando dados na tabela
                DataTable table = new DataTable();

                AdatadorDeDados.Fill(table);

                tblEntregador.DataSource = table;



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

        public static void CadastrarEntregador(String nome, String status, String telefone)
        {
            string sql = "INSERT INTO entregador(ent_nome, ent_status, ent_telefone) VALUES (@ent_nome, @ent_status, @ent_telefone)";


            try
            {
                //Abrindo conexão
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ent_nome", telefone);
                cmd.Parameters.AddWithValue("@ent_status", status);
                cmd.Parameters.AddWithValue("@ent_telefone", status);

                int adicionar = cmd.ExecuteNonQuery();
                if (adicionar > 0)
                {
                    MessageBox.Show("Entregador adicionado com sucesso.");
                }
                

            } catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            } finally
            {

                conn.Close();
            }

        }


        public static void AtualizarEntregador(String codigoEntregador, String nome, String status, String telefone)
        {
            string sql = "UPDATE entregador SET ent_nome=@ent_nome, ent_status=@ent_status, ent_telefone=@ent_telefone WHERE ent_cod=@ent_cod ";

            try
            {

                //Abrindo a conexão
                conn.Open();


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ent_cod", codigoEntregador);


                int atualizar = cmd.ExecuteNonQuery();

                if(atualizar > 0 )
                {
                    MessageBox.Show("Entregador atualizado com sucesso!");

                }




            } catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);


            } finally
            {

                conn.Close();
            }
            






        }














    }
}
