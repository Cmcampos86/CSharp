using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Generic
{
    public class Cliente : ICliente<Cliente>
    {
        public string Nome { get; set; }
        public int CodCliente { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}
