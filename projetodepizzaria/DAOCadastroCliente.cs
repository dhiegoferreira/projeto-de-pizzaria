using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Globalization;

namespace projetodepizzaria
{
    public class DAOCadastroCliente
    {
       

        //definindo fora da função obter dados
        public static string StringDeConexao = "server=localhost;uid=root;pwd=;database=bancoteste";

      
        public static void ObterDados(string sqlString, DataGridView datagrid1)
        {
            //Lançando o try-catch

            try
            {
                //Criando um objeto do tipo adaptador de dados e passando a string de consulta e a string de conexao
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlString, StringDeConexao);


                //populando dados na tabela
                DataTable table = new DataTable();

                dataAdapter.Fill(table);

                datagrid1.DataSource = table;



            } catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        //MÉTODO QUE VAI INSERIR O CLIENTE NO BANCO DE DADOS.


    }
     
}