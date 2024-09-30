using System;
using System.IO;
using Gerenciador_de_Boletos.IO.IFuncions_IO;

namespace Gerenciador_de_Boletos.IO.Features___IO
{
    internal class CreateDirectory :  IDirectory_IO
    {
        private string folderName1 = "Boletos";
        private string folderName2 = "SemAtribuição";
        private string path_complete { get; set; }



        private string SetPath()
        {
            Console.WriteLine("\nDigite o caminho da partição onde a pasta com os boletos será criada:");
            string path_Directory = Console.ReadLine().Trim();

            path_complete = Path.Combine(path_Directory, folderName1, folderName2);//'C:\Boletos\SemAtribuição'
            return path_complete;
        }

        protected string GetPath()
        {
            return path_complete;
        }

        public void CreateDirectory_IO()
        {
            try
            {
                if (!Directory.Exists(path_complete))
                {
                    Directory.CreateDirectory(path_complete);
                    Console.WriteLine($"Pastas '{folderName1} e {folderName2}' criada em '{path_complete}'.");
                }
                else
                {
                    Console.WriteLine($"\nAs pastas {folderName1} e {folderName2} já estão criadas em '{path_complete}'.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nFalha na criação da pasta pelo caminho informado. Certifique-se de que o mesmo esteja correto. \nErro: {ex.Message}");
                SetPath();
            }
        }
    }
}
