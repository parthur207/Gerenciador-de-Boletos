using Gerenciador_de_Boletos.Funcionalidades___IO.IFuncions_IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Gerenciador_de_Boletos.IO.Features___IO;
using iTextSharp.text.pdf.parser;


namespace Gerenciador_de_Boletos.iTextSharp.Directory___Funcions
{
    internal class Reader_ITS : CreateDirectory, IDirectory_ITS
    {
        public string Reader_PDF(string path_arquivos_pdf)
        {
            using (PdfReader leitor = new PdfReader(path_arquivos_pdf))
            {
                string conteudo_pdf = string.Empty;

                for (int i = 1; i <= leitor.NumberOfPages; i++)
                {
                    conteudo_pdf += PdfTextExtractor.GetTextFromPage(leitor, i);
                }
                leitor.Close();
                return conteudo_pdf;
            }
        }
    }
}

