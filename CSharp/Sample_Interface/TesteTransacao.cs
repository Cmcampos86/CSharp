using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Interface
{
    public class TesteTransacao : Transacao
    {
        public override double CalcularImposto() //sobrescreve o método
        {
            return GetValor() * 30;
        }
    }
}
