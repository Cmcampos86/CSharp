using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method intentionally left empty.
        }

        #region Contains

        public static void Contains()
        {
            string texto = "Claudio Marcos de Campos";

            if (texto.ToLower().Contains("Claudio Marcos de CampoS".ToLower()))
            {
                Console.WriteLine("OK");
            }
        }

        #endregion

        #region Substring

        public static void Substring()
        {
            string texto = "Claudio Marcos de Campos";

            Console.WriteLine(texto.Substring(8, 6));
        }

        #endregion

        #region StringBuilder

        public static void StringBuilder()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString());
            }

            Console.WriteLine(sb.ToString());
        }

        #endregion

        #region Combine

        public static void Combine()
        {
            string pathArquivo = @"C:\inetpub\wwwroot\SGT2\REMESSAS\2146605156_VPAR20150112103905.xls";
            pathArquivo = Path.Combine(pathArquivo.Substring(0, pathArquivo.LastIndexOf("wwwroot")), "wwwroot", "GTC");

            Console.WriteLine(pathArquivo);
        }

        #endregion

        #region Insert

        public static void Insert()
        {
            string linha = "Claudio Marcos de";
            string resultado = string.Empty;

            resultado = linha.Insert(17, " Campos");

            Console.WriteLine(resultado);
        }

        #endregion

        #region IndexOf

        public static void IndexOf()
        {
            string value = "Claudio Marcos de Campos";

            if (value.IndexOf("Marcos") != -1)
            {
                Console.WriteLine("string contém Marcos!");
            }
        }

        #endregion

        #region EscapeCharacter

        public static void EscapeCharacter()
        {
            string a = "Teste\nString\nCSharp"; //pula linha
            string b = "Teste\tString\tCSharp"; //tabulação
            string c = "McDonald\'s"; //apóstrofo

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        #endregion
    }
}
