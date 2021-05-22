using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Generic
{
    interface ICliente<T>
    {
        int CodCliente { get; set; }
    }
}
