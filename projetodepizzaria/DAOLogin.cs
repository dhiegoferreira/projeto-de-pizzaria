using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;



//Esta classe é responsável por fazer a conexao com o banco de dados

namespace projetodepizzaria
{
    public class DAOLogin
    {
        
        //Preparando a string de conexão
        //O local, o tipo e o 
        public static string StringDeConexao = "server=localhost;uid=root; " +
            "pwd=;database=bancoteste";

        //Criando um objeto de conexao do MySqlConnection e passando a string de conexao
        public static MySqlConnection conn = new MySqlConnection(StringDeConexao);


        //Método responsável pela autenticação do usuário no BD
        public static void autenticarFuncionario(string usuario, string senha){
            try
            {
                Console.WriteLine("Conectando ao BD e fazendo a autenticação...");
                conn.Open();//Conexão aberta

                //Passando a string SQL para consulta
                string sql = "SELECT * FROM funcionarios WHERE fun_usuario=@funusuario and fun_senha=@funsenha";

                //Criando uma instancia do MySqlCommand
                MySqlCommand cmd = new(sql, conn); //simplicada de new MySqlComman(sql, conn);

                cmd.Parameters.AddWithValue("@funusuario", usuario);
                cmd.Parameters.AddWithValue("@funsenha", senha);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Usuário encontrado com sucesso!");
                    
                    
                } else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
                rdr.Close();

                
            } catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

            //Finalizar a conexão
            conn.Close();
            Console.WriteLine("Conexão finalizada");

        }



       







    }
}
