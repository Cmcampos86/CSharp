using System.Runtime.InteropServices;

namespace Sample_Method
{
    //Incluído a classe como estática para estender o método
    static class Program
    {
        static void Main(string[] args)
        {
            string frase = "Esta é uma frase de exemplo";
            int numeroCaracteres = frase.MetodoExtensaoContaCaracteres();

            List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };
            numeros.AumentaValorLista(10);
            foreach (var numero in numeros)
                Console.WriteLine(numero);

            Console.ReadKey();
        }

        #region PorValor

        public static void PorValor(int valor) =>
            //Uma cópia é feita para o valor
            valor *= 10;

        #endregion

        #region PorReferencia

        public static void PorReferencia(ref int valor)
        {
            //Modifica a variável original, mas ref é utilizado para variáveis já inicializadas
            valor = valor * 10;
        }

        #endregion

        #region PorReferenciaOut

        public static void PorReferenciaOut(out int valor)
        {
            //Modifica a variável original, mas out é utilizado para variáveis não inicializadas.
            //Essas podem ser inicializadas dentro do método
            valor = 5;
            valor = valor * valor;
        }

        #endregion

        #region ExecutaMetodos

        public static void ExecutaMetodos()
        {
            int numero = 100;
            Console.WriteLine($"O valor original do número é: {numero}");

            //PorValor(numero)// numero = 100;
            //PorReferencia(ref numero);
            PorReferenciaOut(out numero);

            Console.WriteLine($"O valor após chamar o método é: {numero}");
        }

        #endregion

        #region SobrecagaMetodo

        public static void SobrecagaMetodo()
        {
            //Métodos com o mesmo nome, mas com parâmetros diferentes
            Somar(10, 20);
            Somar(10, 20, new int[] { 30, 40, 50 });
        }

        public static void Somar(int n1, int n2)
        {
            Somar(n1, n2, null);
        }

        public static void Somar(int n1, int n2, int[] numeros)
        {
            int resultado = n1 + n2;

            if (numeros != null)
            {
                foreach (int i in numeros)
                {
                    resultado += i;
                }
            }

            Console.WriteLine($"Soma = {resultado}");
        }

        #endregion

        #region ParametrosParams

        public static void ParametrosParams()
        {
            SomarParams(10, 20);//Array opcional
        }

        public static void SomarParams(int n1, int n2, params int[] numeros)
        {
            //params: é um array de parâmetros
            //O parâmetro é opcional
            //Deve ser o ultimo parâmetro da lista
            //Usado somente uma vez

            int resultado = n1 + n2;

            if (numeros != null)
            {
                foreach (int i in numeros)
                {
                    resultado += i;
                }
            }

            Console.WriteLine($"Soma = {resultado}");
        }

        #endregion

        #region ParametrosNamedParameters

        public static void ParametrosNamedParameters()
        {
            //Array opcional
            SomarNamedParameters(10, 20);
        }

        public static void SomarNamedParameters(int n1, int n2, int[] numeros = null)
        {
            //Named Parameters: define um valor padrão utilizando um simbolo de igual e o torna opcional
            int resultado = n1 + n2;

            if (numeros != null)
            {
                foreach (int i in numeros)
                {
                    resultado += i;
                }
            }

            Console.WriteLine($"Soma = {resultado}");
        }

        #endregion

        #region ParametrosOptional

        public static void ParametrosOptional()
        {
            SomarOptional(10, 20);//Array opcional
        }

        public static void SomarOptional(int n1, int n2, [Optional] int[] numeros)
        {
            //Optional: torna o parâmetro opcional
            //Deve utilizar a referência System.Runtime.InteropServices
            int resultado = n1 + n2;

            if (numeros != null)
            {
                foreach (int i in numeros)
                {
                    resultado += i;
                }
            }

            Console.WriteLine($"Soma = {resultado}");
        }

        #endregion

        #region MetodoExtensaoContaCaracteres

        public static int MetodoExtensaoContaCaracteres(this string texto)
        {
            //Definir em uma classe estática
            //Definir o método estático e público
            //O parâmetro deve conter o this

            var contador = texto.Length;

            return contador;
        }

        #endregion

        #region MetodoExtensaoContaPalavras

        public static int MetodoExtensaoContaPalavras(this string texto)
        {
            return texto.Split(new char[] {' ',',','?','!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        #endregion
    }
}
