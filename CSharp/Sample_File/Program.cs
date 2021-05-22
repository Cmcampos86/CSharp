using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sample_File
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method intentionally left empty.
        }

        #region ConverterEnconding

        public static void ConverterEnconding()
        {
            string descricao = "Ferrovial CorporaciÃ³n (DDIs FREE)";
            byte[] bytes = Encoding.Default.GetBytes(descricao);

            descricao = Encoding.UTF8.GetString(bytes);

            Console.WriteLine(descricao);
        }

        #endregion

        #region RetirarProtecaoSeguranca

        public static void RetirarProtecaoSeguranca()
        {
            Process runcommd = new Process();

            //Caminho do executável
            runcommd.StartInfo.FileName = @"C:\Fontes\BackEnd\CSharp\Sample_File\Files\streams\streams.exe";

            //-s: busca os subdiretórios
            //-d: exclui a flag
            runcommd.StartInfo.Arguments = @" -d C:\Fontes\BackEnd\CSharp\Sample_File\Files\streams\LockedFiles\*.zip";

            runcommd.StartInfo.UseShellExecute = false;
            runcommd.StartInfo.CreateNoWindow = false;

            runcommd.StartInfo.RedirectStandardError = true;
            runcommd.StartInfo.RedirectStandardOutput = true;
            runcommd.StartInfo.RedirectStandardInput = true;

            runcommd.Start();

            runcommd.StandardInput.Flush();
            runcommd.StandardInput.Close();
        }

        #endregion

        #region LerArquivoDelimitado

        public static void LerArquivoDelimitado()
        {
            try
            {
                StreamReader rd = new StreamReader(@"C:\Fontes\BackEnd\CSharp\Sample_File\Files\FileDelimited\C2ImportGroupsSample.csv");
                string linha = null;
                string[] linhaseparada = null;

                while ((linha = rd.ReadLine()) != null)
                {
                    linhaseparada = linha.Split(',');
                    //TODO
                }
                rd.Close();
            }
            catch
            {
                Console.WriteLine("Erro ao executar Leitura do Arquivo");
            }
        }

        #endregion

        #region LerArquivoPDF

        public static string LerArquivoPDF(string path)
        {
            using (PdfReader reader = new PdfReader(path))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i < reader.NumberOfPages; i++)
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));

                return text.ToString();
            }
        }

        #endregion

        #region ConvertXMLtoJSON

        public static string ConvertXMLtoJSON()
        {
            string xml = @"<AvaliarExposicaoPoliticaRequest>
	                            <PessoasFisicas>        
		                            <PessoaFisica>     
			                            <CPF>24580941802</CPF>
		                            </PessoaFisica>  
		                            <PessoaFisica>
			                            <CPF>20017696879</CPF>
		                            </PessoaFisica>
	                            </PessoasFisicas>
                            </AvaliarExposicaoPoliticaRequest>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string json = JsonConvert.SerializeXmlNode(doc);

            return json;
        }

        #endregion
    }
}
