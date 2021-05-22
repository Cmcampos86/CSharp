using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Interface
{
    public class Transacao : Juros, ITransacao, IImposto
    {
        public string Codigo { get; set; }
        public string Data { get; set; }
        public double Valor { get; set; }

        public Transacao()
        {
            Codigo = string.Empty;
            Data = string.Empty;
            Valor = 0.0;
        }

        public Transacao(string codigo, string data, double valor)
        {
            Codigo = codigo;
            Data = data;
            Valor = valor;
        }

        public void ExibirTransacao()
        {
            Console.WriteLine($"Transação : {Codigo}");
            Console.WriteLine($"Data      : {Data}");
            Console.WriteLine($"Valor     : {GetValor()}");
            Console.WriteLine($"Imposto   : {CalcularImposto()}");
            Console.WriteLine($"Juros     : {CalcularJuros(Valor, 0.25)}");
        }

        public double GetValor()
        {
            return Valor;
        }

        public virtual double CalcularImposto()
        {
            return Valor * 0.15;
        }
    }
}
