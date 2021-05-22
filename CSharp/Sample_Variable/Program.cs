using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method intentionally left empty.
        }

        #region Conversoes

        public static void Conversoes()
        {
            //Tipo valor(aponta um valor direto já existente no framework. Trabalha com Stack.): 
            //+ Todos os tipos númericos
            //+ Boolean, Char, e Date
            //+ Todas as estruturas
            //+ Enumerações

            //Tipo Referência(Endereça uma referência para um valor. Não chega a ser um valor normal existente. Trabalha com Heap.):
            //+ String
            //+ Todos os arrays
            //+ Classes
            //+ Delegates

            int numeroPequeno = 1234;

            //Conversão implícita: O valor é copiado e a conversão feita
            //automaticamente, uma vez que, um int cabe dentro de um long
            long numeroGrandeImplicito = numeroPequeno;

            //Conversão Explícita: O resultado é o mesmo que está acima, mas eu
            //forço a conversão. O compilador te aobriga a definir explicitamente
            // que é isso que voce deseja fazer.
            long numeroGrandeExplicito = (long)numeroPequeno;

            //Com relação a conversão de classes, eu posso converter uma classe derivada em uma classe
            //base implicitamente, mas para converter uma classe base em uma derivada, será necessário
            //fazer um cast
            Quadrado q = new Quadrado();

            Retangulo r = q;// Implícito
            Quadrado q1 = (Quadrado)r; //Explícito
        }

        #endregion

        #region TipoNullable

        public static void TipoNullable()
        {
            int? valor = 0; //Conversão implícita
            int valor2 = (int)valor; //Conversão Explícita

            //Declaração de variáveis nulas
            int?[] array = new int?[10];
            DateTime? data = null;

            try
            {
                //Verificar se o valor é null
                if (valor != null)
                {
                    Console.WriteLine(valor);
                }

                if (data.HasValue) //Verifica se tem valor
                {
                    // Se não tive valor quando declaro do Value, lança uma Exception
                    Console.WriteLine(data.Value);
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Var

        public static void Var()
        {
            //Só pode ser utilizada quando o valor for inicializado
            //Não pode inicializar com null
            //Não pode ser usada em propriedades de classe
            //Não aceita declarar um expressa se a variavel declarada for usada
            //Não aceita múltiplas declarações
            //Pode usar quando o nome da classe for muito grande
            //Pode usar tiver que retornar um conjunto de dados

            //int x = 0; //Definição explícita ou direta do tipo da variável
            //var y = 0; //Definição implícita ou indireta. O compilador identifica o tipo.
        }

        #endregion

        #region TipoAnonimo

        public static void TipoAnonimo()
        {
            var prod = new { Id = 1, Nome = "Caneta", Preco = 1.25 };

            Console.WriteLine(prod.Id);
            Console.WriteLine(prod.Nome);
            Console.WriteLine(prod.Preco);
        }

        #endregion
    }
}
