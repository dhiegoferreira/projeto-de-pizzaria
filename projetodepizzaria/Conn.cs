using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace projetodepizzaria
{
    class Conn
    {
        static public string servidor = "localhost";
        static public string bancoDados = "bancoteste";
        static public string usuario = "root";
        static public string senha = "";

        static public string strConn = $"server={servidor}; User Id={usuario};database={bancoDados};password={senha}";

        public static bool Conectar()
        {
            var result = false;

            try
            {

                using (var conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    result = true;
                }
            }
            catch (Exception ex)
            {

                result = false;
                MessageBox.Show("Falha: " + ex.Message);
            }
            return result;
        }

    }





    }

