using Gerenciador_de_Boletos.Funcionalidades___IO.IFuncions_IO;
using Gerenciador_de_Boletos.IO.IFuncions_IO;
using Gerenciador_de_Boletos.iTextSharp.Directory___Funcions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gerenciador_de_Boletos.iTextSharp.Features___ITS
{
    internal class Reader_Path_ITS: Reader_ITS, IDirectory_ITS
    {    
        CreateSubDirectory csd=new CreateSubDirectory();
        #region conteudos_pdfs
        protected string? conteudo_pdf_NoAt { get; private set; }
        protected string? conteudo_pdf_Pendente {  get; private set; }
        protected string? conteudo_pdf_Pagos {  get; private set; }
        protected string? conteudo_pdf_Vencidos { get; private set; }
        #endregion

        public void Reader_Path_NoAt()
        {
            string Path_NoAt = GetPath();
            string[] Path_NoAt_arquivosPdf = Directory.GetFiles(Path_NoAt, "*.pdf");

            foreach (var caminho_arquivo in Path_NoAt_arquivosPdf)
            {
                try
                {
                    conteudo_pdf_NoAt = Reader_PDF(caminho_arquivo);
                    //incremento de um método passando 'conteudo_pdf_NoAt'
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro inesperado na tentativa de leitura do arquivo '{caminho_arquivo}'. \nErro: {ex.Message}");
                }
            }
        }

        public void Reader_Path_Pendente()
        {
            string Path_pendentes= csd.Path_Pendentes();

            string[] Path_Pendentes_arquivosPdf = Directory.GetFiles(Path_pendentes, "*.pdf");
            
            foreach(var caminho_arquivo in Path_Pendentes_arquivosPdf)
            {
                try
                {
                    conteudo_pdf_Pendente = Reader_PDF(caminho_arquivo);
                    //incremento de um método passando 'conteudo_pdf_Pendente'
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"\nOcorreu um erro inesperado na tentativa de leitura do arquivo presente no caminho '{caminho_arquivo}'. \nErro: {ex.Message}"); 
                }
            }
        }
        public void Reader_Path_Pagos()
        {
            string Path_Pagos=csd.Path_Pagos();
            string[] Path_Pagos_arquivosPDF=Directory.GetFiles(Path_Pagos);

          
            foreach (var caminho_arquivo in Path_Pagos_arquivosPDF)
            {
                try
                {
                    conteudo_pdf_Pagos = Reader_PDF(caminho_arquivo);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"\nOcorreu um erro inesperado na tentativa de leitura do arquivo presente no caminho '{caminho_arquivo}'. \nErro: {ex.Message}");
                }
            }
        }
        

        public void Reader_Path_Vencidos()
        {
            string Path_Vencidos=csd.Path_Vencidos();

            string[] Path_Vencidos_arquivosPdf =Directory.GetFiles(Path_Vencidos);

            foreach (var caminho_arquivo in Path_Vencidos_arquivosPdf)
            {
                try
                {
                    conteudo_pdf_Vencidos = Reader_PDF(caminho_arquivo);

                    //incremento de um método para regra de negócio 
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"\nOcorreu um erro inesperado na tentativa de leitura do arquivo presente no caminho '{caminho_arquivo}'. \nErro: {ex.Message}");
                }
            }
        }
    }
}
