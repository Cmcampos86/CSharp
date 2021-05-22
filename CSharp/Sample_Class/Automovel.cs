using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
