namespace Sample_Class
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Pessoa()
        {
            Console.WriteLine($"Construtor da classe Pessoa");
        }
    }
}
