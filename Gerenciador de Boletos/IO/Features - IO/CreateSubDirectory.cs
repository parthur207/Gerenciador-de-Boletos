using Gerenciador_de_Boletos.IO.Features___IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Boletos.IO.IFuncions_IO
{
    internal class CreateSubDirectory : CreateDirectory, IDirectory_IO
    {
        private string Folder_Pendentes { get;} = "Pendentes";
        private string Folder_Pagos { get;} = "Pagos";
        private string Folder_Vencidos { get;} = "Vencidos";

        public string Path_Pendentes()
        {
            string path_FolderPendentes =Path.Combine(base.GetPath(), Folder_Pendentes);

           return path_FolderPendentes;// 'C:\Boletos\Sem_Atribuição\Pendentes'
        }

        public string Path_Pagos()
        {
            string path_FolderPagos= Path.Combine(base.GetPath(), Folder_Pagos);

            return path_FolderPagos;// 'C:\Boletos\Sem_Atribuição\Pagos'
        }

        public string Path_Vencidos()
        {
            string path_FolderVencidos = Path.Combine(base.GetPath(), Folder_Vencidos);

            return path_FolderVencidos;// 'C:\Boletos\Sem_Atribuição\Vencidos'
        }

        protected void CreateSubDirectory_IO()
        {
            try 
            {
                if (!Directory.Exists(Path_Pendentes()) && !Directory.Exists(Path_Pagos()) && !Directory.Exists(Path_Pagos()))
                {
                    Directory.CreateDirectory(Path_Pendentes());
                    Directory.CreateDirectory(Path_Pagos());
                    Directory.CreateDirectory(Path_Vencidos());
                    Console.WriteLine($"\nAs Pastas '{Folder_Pendentes}', '{Folder_Pagos}' e '{Folder_Vencidos}' foram criadas em: {base.GetPath}");
                }
                else
                {
                    Console.WriteLine("\nAs pastas ja existem.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado na tentativa de criação das subpastas.\nErro: {ex.Message}");

            }

        }


    }
}
