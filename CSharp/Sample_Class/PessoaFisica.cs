using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Class
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public PessoaFisica()
        {
            Console.WriteLine($"Construtor da classe Pessoa Física");
        }

        public string Descricao()
        {
            return $"Sou o método Descricao da classe PessoaFisica";
        }
    }
}
