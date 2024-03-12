namespace Sample_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method intentionally left empty.
        }

        #region IncrementaPrefixoSufixo

        public static void IncrementaPrefixoSufixo()
        {
            //Prefixo
            int valor1Prefixo;
            int valor2Prefixo = 10;
            valor1Prefixo = ++valor2Prefixo;

            Console.WriteLine($"Valor1Prefixo é = {valor1Prefixo}");
            Console.WriteLine($"Valor2Prefixo é = {valor2Prefixo}");

            //Sufixo
            int Valor1Sufixo;
            int Valor2Sufixo = 10;
            Valor1Sufixo = Valor2Sufixo++;

            Console.WriteLine($"Valor1Sufixo é = {Valor1Sufixo}");
            Console.WriteLine($"Valor2Sufixo é = {Valor2Sufixo}");

            Console.ReadLine();
        }

        #endregion

        #region OperadoresExpressaoBits

        public static void OperadoresExpressaoBits()
        {
            bool condicao1 = true, condicao2 = true;

            //Verifica a primeira expressão para então ir a segunda
            if (condicao1 && condicao2)
                Console.WriteLine("Primeiro if - OK");

            //Verifica todas as expressões (bitwise)
            if (condicao1 & condicao2)
                Console.WriteLine("Segundo if - OK");
        }

        #endregion
    }
}
