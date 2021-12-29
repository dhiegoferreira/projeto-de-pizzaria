using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Esta classe é responsável por fazer a conexao com o banco de dados

namespace projetodepizzaria
{
    class Conexao
    {
        MySql.Data.MySqlClient.MySqlConnection conn;

        public static string conexaoString = "server=localhost;uid=root; " +
            "pwd=;database=bancoteste";

        public void conectar(){
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = conexaoString;
                conn.Open();


            } catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

       







    }
}
