using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Delegate
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public int Idade { get; set; }

        public static List<Funcionario> GetFuncionarios()
        {
            return new List<Funcionario>()
            {
                new Funcionario()
                {
                    Nome = "João",
                    Nascimento = Convert.ToDateTime("25/09/1985")
                },
                new Funcionario()
                {
                    Nome = "José",
                    Nascimento = Convert.ToDateTime("18/05/1981")
                },
                new Funcionario()
                {
                    Nome = "Maria",
                    Nascimento = Convert.ToDateTime("01/11/1980")
                }
            };
        }

    }
}
