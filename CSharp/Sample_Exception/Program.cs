namespace Sample_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Propriedades da classe Exception

            //Message – Uma descrição do erro.
            //Source – O nome da aplicação ou do objeto que causou o erro.
            //Stack Trace – A pilha de chamadas onde estava o programa no momento em que ocorreu o erro.
            //TargetSite – O método que disparou o erro.
            //HelpLink – Um link para a ajuda sobre esse erro.
            //InnerException – Uma instância da classe Exception que gerou a exceção atual.
            //Data – Coleção com informações adicionais sobre o erro.
            //ToString() – Método que retorna todos os detalhes do erro em formato string.

            //Todas as classes Exception são derivadas da classe base System.Exception.
            //Algumas classes comuns são:

            //System.FormatException – Usada para detectar formatos inválidos em conversões de dados.
            //System.DivideByZeroException – Quando ocorre uma divisão por zero.
            //System.IndexOutOfRangeException – Ocorre quando um índice de um array está fora dos limites permitidos.
            //System.InvalidCastException – Ocorre quando uma conversão direta(chamada de cast) não é possível.
            //System.OverFlowException – Um número muito grande ou muito pequeno foi atribuído a uma variável que não o suporta(erro bem conhecido pelos desenvolvedores).
            //System.IO.FileNotFoundException – Arquivo não encontrado.
            //System.Data.SqlClient.SqlException – Ocorre quando é detectado um problema em uma operação do SQL Server.
            //System.Data.OleDb.OleDbException – Ocorre quando é detectado um problema em uma operação com banco de dados conectado através do componente OleDb.
        }

        #region TratamentoExcecoes

        public static void TratamentoExcecoes()
        {
            try
            {
                Console.WriteLine($"Informe o valor do número 1");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Informe o valor do número 2");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int resultado = num1 / num2;

                Console.WriteLine($"{num1} / {num2} = {resultado}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Erro de formato de número inválido - {ex.Message}");
            }
            catch (DivideByZeroException ex) //Utilizar a Exception da mais específica para a mais genérica
            {
                Console.WriteLine($"Erro de divisão por zero - {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro! - {ex.Message}");
            }
            finally //Sempre será executado
            {
                Console.WriteLine($"Término do processo!");
            }
        }

        #endregion

        #region TratamentoExcecoes2

        public static void TratamentoExcecoes2()
        {
            string nome = null;

            if (nome == null)
            {
                //throw new dispara na hora uma exception sem passar pelo try catch finally
                throw new ArgumentNullException();
            }
            return;
        }

        #endregion

        #region TratamentoExcecoes3

        public static void TratamentoExcecoes3()
        {
            Calculo t = new Calculo();

            try
            {
                t.Teste();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        #endregion

        #region TratamentoExcecoes4
        public static void TratamentoExcecoes4()
        {
            Console.WriteLine($"Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 18)
            {
                throw new ExceptionIdadeInvalida($"Idade mínima: 18 anos");
            }

        }

        #endregion
    }
}
