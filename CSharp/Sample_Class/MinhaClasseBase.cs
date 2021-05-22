using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Class
{
    public class MinhaClasseBase
    {
        private readonly int _idade = 15;

        public virtual int Idade
        {
            get { return _idade; }
        }

        public MinhaClasseBase()
        {
            Console.WriteLine($"Construtor sem parâmetro");
        }

        public MinhaClasseBase(int idade)
        {
            Console.WriteLine($"Minha idade é (Classe base): {idade}");
        }

        //Virtual significa sobrescrever o método da classe base, ou seja, passa a valer o método da classe derivada
        public virtual void Imprimir()
        {
            Console.WriteLine("Eu sou a classe base");
        }
    }
}
