namespace Sample_Struct
{
    public struct Pessoa
    {
        public double Altura;
        public double Peso;
        public double IMC;

        public Pessoa(double _altura, double _peso, double _imc)
        {
            //constructor => Pessoa p = new Pessoa(1.98, 90, 26.45)
            Altura = _altura;
            Peso = _peso;
            IMC = _imc;
        }
    }
}
