namespace Sample_Class
{
    public class Aeronave : Veiculo
    {
        //A classe Veiculo exiger um parametro no construtor. Dessa forma, fazmos a herança do construtor
        public Aeronave(string tipo) : base(tipo)
        {

        }

        public override void Mover()
        {
            Console.WriteLine($"Decolando a Aeronave");
        }
    }
}
