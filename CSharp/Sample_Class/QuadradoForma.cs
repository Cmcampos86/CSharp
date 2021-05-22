using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Class
{
    public class QuadradoForma : Forma
    {
        public double Lado { get; set; }

        public override void CalcularArea()
        {
            this.Area = Lado * Lado;
        }

        public override void CalcularPerimetro()//Implementando o método abstrato da classe base(deve conter override uma vez que o método abstract é virtual)

        {
            this.Perimetro = 4 * Lado;
        }
    }
}
