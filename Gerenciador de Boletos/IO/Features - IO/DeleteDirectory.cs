using Gerenciador_de_Boletos.IO.Features___IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Boletos.IO.IFuncions_IO
{
    internal class DeleteDirectory: CreateDirectory, IDirectory_IO
    {

        protected override string GetPath()
        {

            return base.GetPath();
        }

        public void DeleteDirectory_IO()
        {
            try
            {
                if (Directory.Exists(GetPath())) 
                {
                    Directory.Delete(GetPath());
                    Console.WriteLine("\nTodas as pastas e boletos foram deletados.");
                }
                else
                {
                    Console.WriteLine($"\nNão foi encontrado nenhuma pasta/arquivo no caminho informado. Caminho: {GetPath()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado na tentativa de exclusão de todas as pastas e boletos. Erro: {ex.ToString()}");
            }

        }

    }
}
