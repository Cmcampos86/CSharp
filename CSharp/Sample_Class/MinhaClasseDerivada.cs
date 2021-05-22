using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Class
{
    public class MinhaClasseDerivada : MinhaClasseBase
    {
        public string status = "Classeu derivada OK";

        private readonly int _idade = 25;
        public override int Idade
        {
            get { return _idade; }
        }

        public MinhaClasseDerivada()
        {
            Console.WriteLine($"Construtor sem parâmetro");
        }

        public MinhaClasseDerivada(int idade) : base(idade)//base serve para indicar qual o construtor base será usado de acordo com a assinatura do construtor base
        {
            Console.WriteLine($"Minha idade é (Classe derivada): {idade}");
        }

        //new public void Imprimir()
        public override void Imprimir()
        {
            Console.WriteLine("Eu sou a classe derivada");
        }
    }
}
