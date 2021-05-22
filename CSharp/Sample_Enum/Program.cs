using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method intentionally left empty.
        }

        #region RetornoSimples

        public static void RetornoSimples()
        {
            DiaSemana dia = DiaSemana.Dom;
            int x = (int)DiaSemana.Dom;

            Console.WriteLine($"Hoje é dia: {dia}"); //Dom
            Console.WriteLine($"Hoje é o dia: {x}"); //6
        }

        #endregion

        #region RetornaNome

        public static void RetornaNome()
        {
            //Retorna o nome da constante da enumeração
            string s = Enum.GetName(typeof(DiaSemana), 4);
            Console.WriteLine($"Hoje é o dia da semana: {s}"); //Sex
        }

        #endregion

        #region RetornaValores

        public static void RetornaValores()
        {
            //Percorre um enum mostrando os seus valores
            Console.WriteLine($"Os valores da enumeração (Getvalues) DiaSemana são:\n");
            foreach (int i in Enum.GetValues(typeof(DiaSemana)))
                Console.WriteLine(i); //0, 1, 2, 3, 4, 5, 6
        }

        #endregion

        #region RetornaNomes

        public static void RetornaNomes()
        {
            Console.WriteLine($"Os nomes dos dias no Enum (GetNames) são:\n");
            foreach (string str in Enum.GetNames(typeof(DiaSemana)))
                Console.WriteLine(str); //Seg, Ter, Qua, Qui, Sex, Sab, Dom
        }

        #endregion

        #region RetornoSwitchCase

        public static void RetornoSwitchCase()
        {
            EstadoCivil estadoCivil = EstadoCivil.Solteiro;

            switch (estadoCivil)
            {
                case EstadoCivil.Casado:
                    Console.WriteLine("Casado\n");
                    break;
                case EstadoCivil.Divorciado:
                    Console.WriteLine("Divorciado\n");
                    break;
                case EstadoCivil.Solteiro:
                    Console.WriteLine("Solteiro\n");
                    break;
                case EstadoCivil.Viuvo:
                    Console.WriteLine("Viuvo\n");
                    break;
                default:
                    Exception exception = new Exception("O valor informado esta fora do escopo da Enumeration");
                    throw exception;
            }
        }

        #endregion
    }
}
