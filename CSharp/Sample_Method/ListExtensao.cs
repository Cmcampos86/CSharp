using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Method
{
    public static class ListExtensao
    {
        public static void AumentaValorLista(this IList<int> lista, int quantidade)
        {
            for (int i = 0; i < lista.Count(); i++)
                lista[i] += quantidade;
        }
    }
}
