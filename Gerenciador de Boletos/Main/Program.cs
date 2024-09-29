using Gerenciador_de_Boletos.DB.Connect_db;
using MySql.Data.MySqlClient;
using System.Linq.Expressions;

namespace Gerenciador_de_Boletos.Main
{
    internal class Program : Connect_db
    {
        static void Main(string[] args)
        {

            int op=1;
            Console.WriteLine("Gerenciador de Boletos");

            //incremento do método de criação de pastas e subpastas.
            Console.WriteLine("1 - Reorganizar boletos.");
            Console.WriteLine("2 - Exibir quantidade e listar boletos totais.");
            Console.WriteLine("3 - Exibir boletos por status (Pagos | Não Pagos).");
            Console.WriteLine("4 - Exibir boletos conforme data de pagamento.");
            Console.WriteLine("5 - Sair");

            while (!int.TryParse(Console.ReadLine(), out  op) || op<1 || op>5)
            {
                Console.WriteLine("Opção inválida. Digite um numero sendo de 1 a 5.");
            }

            switch (op)
            {
                case 1:

                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;
                case 5:
                    Connect_db cnn = new Connect_db();
                    using (var conexao=new MySqlConnection(cnn.ConnectionString))
                    {
                        conexao.Close();
                        Console.WriteLine("Aplicação encerrada.");
                    }
                    return;
            }

        }
    }
}
