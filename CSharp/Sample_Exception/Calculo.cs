namespace Sample_Exception
{
    public class Calculo
    {
        public void Teste()
        {
            try
            {
                int[] MeuVetor = new int[5];

                for (int i = 0; i < 10; i++)
                {
                    MeuVetor[i] = i;
                }
            }
            catch (Exception)
            {
                //Console.WriteLine($"Ocorreu o erro: {ex.Message}");
                Exception exception = new Exception($"Índice do array excede o tamanho do mesmo");
                throw exception; //Vai jogar a exception para o bloco que o chamou
            }
        }
    }
}
