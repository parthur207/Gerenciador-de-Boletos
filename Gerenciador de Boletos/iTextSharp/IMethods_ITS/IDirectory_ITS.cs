using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Boletos.Funcionalidades___IO.IFuncions_IO
{
    internal interface IDirectory_ITS
    {
        void DeleteFilesPago_PDF() { }

        void DeleteFilesExpirados_PDF() { }

        void DeleteAll_PDF() { }

        void Reader_Path_NoAt() { }

        void Reader_Path_Pendente() { }

        void Reader_Path_Pagos() { }

        void Reader_Path_Vencidos() { }

        string Reader_PDF(string path_arquivos_pdf) { return string.Empty; }

        void Reorganizar_PDF() { }

       

    }
}
