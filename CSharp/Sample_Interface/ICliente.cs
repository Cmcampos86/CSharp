using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Interface
{
    public interface ICliente
    {
        string Versao { get; set; }
        void Teste();
        event EventHandler ValorChanged;
    }
}
