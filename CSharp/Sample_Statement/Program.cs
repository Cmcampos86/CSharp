namespace Sample_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method intentionally left empty.
        }

        #region SwitchCase

        public static void SwitchCase()
        {
            string carro;
            string fabrica;

            Console.Write("Informe a marca do seu carro: ");
            carro = Console.ReadLine();

            switch (carro)
            {
                case "Civic":
                case "Fit":
                case "City":
                    fabrica = "Honda";
                    break;
                case "Focus":
                case "Fiesta":
                    fabrica = "Ford";
                    break;
                //goto case "Corolla"; //Substitui o break e vai para um case específico
                case "Corolla":
                    fabrica = "Toyota";
                    break;
                default:
                    fabrica = "Desconhecido";
                    break;
            }

            Console.WriteLine($"O fabricante do seu carro é: {fabrica}");
            Console.ReadKey();
        }

        #endregion

        #region Goto

        public static void Goto()
        {
            //Estrutura de laço com goto que não é tão usada
            int i = 0;

        repetir:
            Console.WriteLine($"i = {i}");
            i++;

            if (i < 10)
                goto repetir;

            Console.ReadKey();
        }

        #endregion

        #region While

        public static void While()
        {
            //While sempre verifica primeiro e então, excuta ou não
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"i = {i}");
                i++;
            }
        }

        #endregion

        #region DoWhile

        public static void DoWhile()
        {
            //Do While vai executar ao menos um vez e depois continua ou não
            int i = 10;
            do
            {
                Console.WriteLine($"i = {i}");
                i--;
            } while (i > 0);
        }

        #endregion

        #region For
        public static void For()
        {
            for (int i = 0; i <= 40; i++)
            {
                Console.Write($"{i} ");

                if (i % 10 == 0)
                    // \t é o caracter de tabulação
                    Console.WriteLine($"\t\t {i}");
            }

            Console.ReadKey();
        }
        #endregion

        #region ForEach

        public static void ForEach()
        {
            int[] numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Percorre arrays e listas
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }

        #endregion

        #region BreakContinue

        public static void BreakContinue()
        {
            while (true)
            {
                Console.WriteLine("Informe um número: ");
                int valor = int.Parse(Console.ReadLine());

                if ((valor % 3) == 0)
                    continue; //Volta para o while

                if ((valor % 5) == 0)
                    break; //sai do while

                Console.WriteLine("O número não é divisível por 3 ou 5");
            }

            Console.WriteLine("O número é divisível por 5");
            Console.ReadLine();
        }

        #endregion
    }
}
