using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
