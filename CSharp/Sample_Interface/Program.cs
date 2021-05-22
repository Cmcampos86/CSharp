using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface: é um tipo de classe que só contem as declarações de propriedades, métodos e etc
            //Se uma classe herda de outra que esta contenha um interface, a classe que esta herdando deve ter o objetos da interface
            //Modificadores de acesso não são permitidos nas interfaces

            //Em uma interface nenhum método tem corpo e são implicitamente abstratos e publicos
            //Uma interface não pode conter constantes, construtores, variáveis de instância, destrutores, membros estáticos ou interfaces aninhadas.
            //Uma classe pode implementar mais de uma interface; (herança múltipla)
            //Uma interface pode estender de uma ou mais interfaces básicas.
            //Ao criar uma classe usando uma interface, devem ser implementados todos os métodos da interface, caso contrario deverá ser criada uma classe abstrata.
            //Uma interface não pode ser instanciada mas pode ser referenciada pelo objeto da classe que a implementa.A referência da interface funciona como objeto de 
            //referência e se comporta como o objeto.
            //Uma classe que implementa uma interface pode marcar qualquer método da interface como virtual e este método pode ser sobrescrito pelas classes derivadas.

            //Quando usar interfaces:
            //Necessidade de fornecer funcionalidade comum para as classes não relacionadas.
            //Necessidade de agrupar objetos com base em comportamentos comuns.
            //Necessidade de introduzir o comportamento polimórfico às classes desde que uma classe pode implementar mais de uma interface.
            //Necessidade de fornecer uma visão abstrata de um modelo que é imutável.
            //Necessidade de criar componentes de baixo acoplamento, fácil manutenção e componentes conectáveis, visto que a implementação de uma interface é separada de si mesmo.

            //Desvantagens das interfaces
            //O principal problema das interfaces é que quando você adiciona novos membros a uma interface você tem que implementar esses membros em todas as classes que implementam esta interface;
            //Interfaces são mais lentas pois elas necessitam de um esforço extra para encontrar o método na classe atual;

            //Referenciando uma classe em uma interface wusndo herdada da classe
            ITransacao transacao = new Transacao();

            Transacao t1 = new Transacao("001", "01/04/2020", 787900.00);
            Transacao t2 = new Transacao("002", "02/04/2020", 55986.00);

            t1.ExibirTransacao();

            Console.WriteLine("----------------------------------------");

            t2.ExibirTransacao();
        }
    }
}
