using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Class
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Pessoa()
        {
            Console.WriteLine($"Construtor da classe Pessoa");
        }
    }
}
