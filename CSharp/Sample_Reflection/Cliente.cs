namespace Sample_Reflection
{
    public class Cliente
    {

        public string Nome { get; set; }
        public int Idade { get; set; }


        //Utilizado pelo compilador para informar que o método esta obsoleto
        //[Obsolete("Método depreciado. Use o novo método.")]
        public void Mensagem()
        {
            Console.WriteLine($"Seja bem vindo!");
        }
    }
}
