using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LambdaDelegate();

            Console.ReadKey();
        }

        #region LambdaWhere

        public static void LambdaWhere()
        {
            List<int> numeros = new List<int> { 11, 37, 14, 52, 67, 99, 16 };
            List<int> impares = numeros.Where(x => x % 2 == 1).ToList();

            foreach (var impar in impares)
            {
                Console.WriteLine(impar);
            }
        }

        #endregion

        #region LambdaOrderBy

        public static void LambdaOrderBy()
        {
            List<int> numeros = new List<int> { 11, 37, 14, 52, 67, 99, 16 };

            foreach (var numero in numeros.OrderBy(x => x))
            {
                Console.WriteLine(numero);
            }
        }

        #endregion

        #region LambdaAll

        public static void LambdaAll()
        {
            List<int> numeros = new List<int> { 11, 37, 14, 52, 67, 99, 16 };

            //Verifica se TODOS os elementos satisfazem uma condição.
            bool resultado50 = numeros.All(x => x > 50);
            bool resultado500 = numeros.All(x => x < 500);

            Console.WriteLine(resultado50);
            Console.WriteLine(resultado500);
        }

        #endregion

        #region LambdaSelect

        public static void LambdaSelect()
        {
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa { Nome= "João", Idade = 25 },
                new Pessoa { Nome= "José", Idade = 26 },
                new Pessoa { Nome= "Maria", Idade = 35 },
                new Pessoa { Nome= "Antônio", Idade = 20 },
            };

            var listaNovasPessoas = pessoas.Select(x => new
            {
                //Tipo Anônimo: IdadePessoa e PrimeiraLetraNome
                IdadePessoa = x.Idade,
                PrimeiraLetraNome = x.Nome[0]
            });

            foreach (var listaNovasPessoa in listaNovasPessoas)
            {
                Console.WriteLine(listaNovasPessoa);
            }
        }

        #endregion

        #region LambdaDelegate

        public static void LambdaDelegate()
        {
            //Delegate Func
            Func<Aluno, string> verificaNome = aluno => aluno.Nome.StartsWith("J") ? aluno.Nome : "O aluno não atende o critério";

            Console.WriteLine(verificaNome(new Aluno() { Id = 25, Nome = "João" }));
            Console.WriteLine(verificaNome(new Aluno() { Id = 35, Nome = "José" }));
            Console.WriteLine(verificaNome(new Aluno() { Id = 20, Nome = "Maria" }));
        }

        #endregion
    }
}
