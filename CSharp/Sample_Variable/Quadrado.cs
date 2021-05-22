using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Variable
{
    class Quadrado : Retangulo
    {
        public int getPerimetro()
        {
            return (2 * x + 2 * y);
        }
    }
}
