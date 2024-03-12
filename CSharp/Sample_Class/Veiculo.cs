namespace Sample_Class
{
    public class Veiculo
    {
        public string Tipo { get; set; }

        public Veiculo(string tipo)
        {
            Tipo = tipo;
        }

        public virtual void Mover()
        {

        }
    }
}
