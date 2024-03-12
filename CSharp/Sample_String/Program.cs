using System.Text;

namespace Sample_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method intentionally left empty.

            Range();
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

        #region Range

        public static void Range()
        {
            string nomeArquivo = "2022_12_01_backup.bak";

            string ano = nomeArquivo[..4]; //Vai pegar os 4 primeiros caracteres
            string extensao = nomeArquivo[^3..]; //Vai pegar os últimos 3 caracteres
            string nome = nomeArquivo[11..^4]; //Vai pegar a partir da posição 11 eliminando os 4 últimos caracteres
            string apenasNome = nomeArquivo[11..^4]; //Vai pegar tudo eliminando os 4 últimos caracteres

            Console.WriteLine(ano);
            Console.WriteLine(extensao);
            Console.WriteLine(nome);
            Console.WriteLine(apenasNome);
        }

        #endregion
    }
}
