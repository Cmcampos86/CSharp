using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Enum
{
    enum Estado
    {
        Desligado = 0,
        Ligado = 5,
        Repouso = 10,
        Processando = Ligado + 10
    }
}
