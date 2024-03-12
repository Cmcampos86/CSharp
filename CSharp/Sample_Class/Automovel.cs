namespace Sample_Class
{
    public class Automovel : Veiculo
    {
        //A classe Veiculo exiger um parametro no construtor. Dessa forma, fazmos a herança do construtor
        public Automovel(string tipo) : base(tipo)
        {

        }

        public override void Mover()
        {
            Console.WriteLine($"Acelerando o Veículo");
        }
    }
}
