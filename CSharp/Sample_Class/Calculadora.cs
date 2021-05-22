using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Class
{
    public static class Calculadora
    {
        public static int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public static int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }
}
