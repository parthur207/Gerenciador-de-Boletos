using Gerenciador_de_Boletos.Funcionalidades___IO.IFuncions_IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Gerenciador_de_Boletos.IO.Features___IO;


namespace Gerenciador_de_Boletos.iTextSharp.Directory___Funcions
{
    internal class Reader_ITS: CreateDirectory, IDirectory_ITS
    {
        bool validacao_reader = true;
        public string conteudo_pdf { get; protected set; }

        protected string Path;
        public void Reader_PDF()
        {
            Path = GetPath();


        }


    }
}
