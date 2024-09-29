using System;
using System.IO;
using Gerenciador_de_Boletos.IO.IFuncions_IO;

namespace Gerenciador_de_Boletos.IO.Features___IO
{
    internal class  CreateDirectory : IDirectory_IO
    {
        private string folderName = "Boletos"; 
        private string path_complete { get; set; }

        private string SetPath()
        {
            Console.WriteLine("\nDigite o caminho da partição onde a pasta com os boletos será criada:");
            string path_Directory = Console.ReadLine().Trim();

            path_complete = Path.Combine(path_Directory, folderName);
            return path_complete;
        }

        protected virtual string GetPath()
        {
            string path = SetPath();

            return path;
        }

        public void CreateDirectory_IO()
        {
            string path_string = SetPath();
            try
            {
                Directory.CreateDirectory(path_string);
                Console.WriteLine($"Pasta '{folderName}' criada em '{path_string}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha na criação da pasta pelo caminho informado. Certifique-se de que o mesmo esteja correto. \nErro: {ex.Message}");
                SetPath();
            }
        }
    }
}
