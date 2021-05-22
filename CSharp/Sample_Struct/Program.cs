using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct é um tipo de valor e passa uma cópia dela mesma
            //Posso criar multiplas instancia do mesmo tipo e também usar como array
            //Usado para tamanhos pequenos de até 20 bytes(usado para dados que não pretendem ser modificados)
            //Pode conter métodos, construtores, constantes, propriedades, operadores e eventos
            //Pode implementar interfaces
            //Não pode herdar de outra struct
            //Não podem ter um construtor padrão
            //Não pode usar abstract
            //Não pode conter construtores sem parâmetros
            //Não pode conter métodos como protected
            //As estruturas nunca são finalizadas no sentido do garbage colector ser executado
            //Todos os elementos da struct são public por padrão


        }

        #region Structs

        public static void Structs()
        {
            //Pessoa pessoa; //Outra forma de instanciar uma struct
            Pessoa pessoa = new Pessoa();

            Console.WriteLine($"Informe a sua altura em metros: ");
            pessoa.Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Informe o seu peso em quilos: ");
            pessoa.Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A sua altura é {pessoa.Altura} Kg e seu peso é {pessoa.Peso}");

            pessoa.IMC = pessoa.Peso / (Math.Pow(pessoa.Altura, 2));
            Console.WriteLine($"Seu IMC é igual a {pessoa.IMC}");

            if (pessoa.IMC < 18.5)
                Console.WriteLine($"Você esta ABAIXO do seu peso");
            else if (pessoa.IMC >= 18.5 && pessoa.IMC <= 25)
                Console.WriteLine($"Seu peso esta NORMAL");
            else if (pessoa.IMC > 25 && pessoa.IMC <= 30)
                Console.WriteLine($"Você esta ACIMA do peso");
            else if (pessoa.IMC > 30)
                Console.WriteLine($"Você está OBESO");
        }

        #endregion

        #region StructsArray

        public static void StructsArray()
        {
            Pessoa[] dadosPessoa = new Pessoa[3];
            int i = 0;
            do
            {
                Console.WriteLine($"Informe a sua altura em metros: ");
                dadosPessoa[i].Altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Informe o seu peso em quilos: ");
                dadosPessoa[i].Peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"A sua altura é {dadosPessoa[i].Altura} Kg e seu peso é {dadosPessoa[i].Peso}");

                dadosPessoa[i].IMC = dadosPessoa[i].Peso / (Math.Pow(dadosPessoa[i].Altura, 2));
                Console.WriteLine($"Seu IMC é igual a {dadosPessoa[i].IMC}");

                if (dadosPessoa[i].IMC < 18.5)
                    Console.WriteLine($"Você esta ABAIXO do seu peso");
                else if (dadosPessoa[i].IMC >= 18.5 && dadosPessoa[i].IMC <= 25)
                    Console.WriteLine($"Seu peso esta NORMAL");
                else if (dadosPessoa[i].IMC > 25 && dadosPessoa[i].IMC <= 30)
                    Console.WriteLine($"Você esta ACIMA do peso");
                else if (dadosPessoa[i].IMC > 30)
                    Console.WriteLine($"Você está OBESO");

                i++;

            } while (i < dadosPessoa.Length);

            Console.WriteLine($"=================================================================");
            for (int x = 0; x < dadosPessoa.Length; x++)
                Console.WriteLine($"Altura: {dadosPessoa[x].Altura}\nPeso: {dadosPessoa[x].Peso}\nIMC: {dadosPessoa[x].IMC}");
        }

        #endregion

        #region StructsConstrutor

        public static void StructsConstrutor()
        {
            Console.WriteLine($"Instanciando uma struct com construtor");
            Pessoa pessoa = new Pessoa(1.75, 90, 26.5);

            Console.WriteLine($"Exibindo os valores atribuindo no construtor");

            Console.WriteLine($"Altura: {pessoa.Altura}");
            Console.WriteLine($"Peso: {pessoa.Peso}");
            Console.WriteLine($"IMC: {pessoa.IMC}");
        }

        #endregion
    }
}
