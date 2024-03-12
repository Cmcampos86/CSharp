namespace Sample_Delegate
{
    class Program
    {
        static FileStream fs;
        static StreamWriter sw;

        delegate void SimplesDelegate(string texto);
        delegate void ImprimirTexto(string texto);

        static void Main(string[] args)
        {
            //Delegate é um ponteiro para um método
            //Referencia um método
            //Pode ser passado como um parâmetro para um método
            //O Delegate e o método devem possuir a mesma assinatura

        }

        #region Delegate

        public static void Exemplo_Delegate()
        {
            SimplesDelegate sd = ImprimeTexto;
            sd("Imprime Delegate");
        }

        public static void Exemplo_Delegate2()
        {
            ImprimirTexto it1 = ImprimeNoConsole;
            ImprimirTexto it2 = ImprimeEmArquivo;

            Console.WriteLine("Imprime no console");
            it1("Texto Console");

            Console.WriteLine("Imprime no arquivo");
            it2("Texto no arquivo");
        }

        #endregion

        #region Delegate Func

        //Delegate Func: Pode retornar qualquer tipo de dado

        public static void Exemplo_Delegate_Func()
        {
            //Func aceita até 16 parâmetros e abaixo o ultimo parâmetro é sempre o retorno
            Func<int, int, int, long> delMult = Multiplicar;

            ////Método anônimo
            //Func<int, int, int, long> delmut = delegate (int a, int b, int c)
            //{
            //    return a * b * c;
            //};

            ////Expressão Lambda
            //Func<int, int, int, long> delmut = (a,b,c) =>
            //{
            //    return a * b * c;
            //};

            Console.WriteLine(delMult(2, 3, 4));
        }

        public static void Exemplo_Delegate_Func2()
        {
            Func<string, string> ConverterDelegate = CaixaAlta;
            Console.WriteLine(ConverterDelegate("Delegate Func"));
        }

        #endregion

        #region Delegate Action

        public static void Exemplo_Delegate_Action()
        {
            //Delegate Action: Não retorna nenhum valor e pode receber até 16 parâmetros
            double n1 = 100;
            double n2 = 200;

            Action<double, double> dividir = Dividir;
            dividir(n1, n2);
        }

        public static void Exemplo_Delegate_Action2()
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////Outra forma de declarar o delegate Action
            //Action<int> delegateAction = new Action<int>(CalcularPotencia);
            Action<int> delegateAction = CalcularPotencia;

            Array.ForEach(numeros, delegateAction);

            ////Usando Lambda para percorrer o Array
            Array.ForEach(numeros, n => Console.WriteLine(n * n));
        }

        public static void Exemplo_Delegate_Action3()
        {
            List<Funcionario> funcionarios = Funcionario.GetFuncionarios();

            Action<Funcionario> actionFuncionario = new Action<Funcionario>(CalculaIdade);

            funcionarios.ForEach(actionFuncionario);

            ////Com expressão Lambda(Não precisaria da Action)
            //funcionarios.ForEach(f => f.Idade = DateTime.Now.Year - f.Nascimento.Year);

            foreach (var func in funcionarios)
            {
                Console.WriteLine($"{func.Nome} {func.Idade}");
            }
        }

        #endregion

        #region Delegate Predicate

        public static void Exemplo_Delegate_Predicate()
        {
            //Delegate Predicate: Encapsula um método que recebe apenas um parâmetro e retorna um booleano

            int[] numeros = { 2343, 5349, 6039, 4326, 3038, 1987, 8762, 1098 };

            Predicate<int> predicateNumeros = EncontraNumeros;

            int numero = Array.Find(numeros, predicateNumeros);

            ////Com expressão Lambda (não precisa do delegate predicate)
            //int numero = Array.Find(numeros, n => n > 7000);

            Console.WriteLine($"Encontrado: {numero}");
        }

        #endregion

        #region Métodos Delegate

        public static bool EncontraNumeros(int n1)
        {
            return n1 > 7000;
        }

        public static string CaixaAlta(string texto)
        {
            return texto.ToUpper();
        }

        public static void ImprimeTexto(string texto)
        {
            Console.WriteLine(texto);
        }

        public static void ImprimeNoConsole(string texto)
        {
            Console.WriteLine(texto);
        }

        public static void ImprimeEmArquivo(string texto)
        {
            fs = new FileStream(@"c:\teste.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(texto);

            sw.Flush();
            sw.Close();
            fs.Close();
        }

        static private long Multiplicar(int n1, int n2, int n3)
        {
            return n1 * n2 * n3;
        }

        static private void Dividir(double n1, double n2)
        {
            double resultado = n1 / n2;
            Console.WriteLine($"Divisão: {resultado}");
        }

        static private void CalcularPotencia(int n)
        {
            Console.WriteLine($"{n} Ao quadrado = { n * n }");
        }

        static public void CalculaIdade(Funcionario funcionario)
        {
            funcionario.Idade = DateTime.Now.Year - funcionario.Nascimento.Year;
        }

        #endregion
    }
}
