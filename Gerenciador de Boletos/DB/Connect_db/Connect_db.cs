using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_Boletos.DB.Connect_db
{
    internal class Connect_db
    {

        public const string ConnectionString= @"Server=127.0.0.0.1;Port=3306;DataBase=Boletos DB;User ID=root;Password=Admin;";
        public MySqlConnection? cnn { get; private set; }

        protected void Connection()
        {
            try
            {
                using (cnn = new MySqlConnection(ConnectionString))
                {
                    cnn.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nOcorreu um erro na tentativa de conexão com o banco de dados: {ex.ToString()}");
            }
        }
    }
}
