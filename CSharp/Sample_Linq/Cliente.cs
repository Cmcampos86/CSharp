using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Linq
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
