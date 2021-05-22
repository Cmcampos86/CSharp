using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sample_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq: mecanismo de busca de dados

            //from: fonte de dados
            //where: condição
            //select: o que deseja selecionar

            var xml = LinqXMLXElement();

            Console.ReadKey();
        }

        #region LinqString

        public static void LinqString()
        {
            string[] saudacoes = { "Olá mundo", "Olá Linq", "Olá Teste" };

            var item = from s in saudacoes
                       where s.EndsWith("Linq")
                       orderby s
                       select s;

            foreach (var i in item)
                Console.WriteLine(i);
        }

        #endregion

        #region LinqInt

        public static void LinqInt()
        {
            int[] numeros = { 1, 2, 8, 9, 6, 78, 55, 36, 985, 41, 25, 66, 7854, 51 };

            var todosNumeros = from n in numeros
                               where n > 40
                               select n;

            foreach (var n in todosNumeros)
                Console.WriteLine($"{n}");
        }

        #endregion

        #region LinqClass

        public static void LinqClass()
        {
            var pessoas = new List<PessoaLinq>
            {
                new PessoaLinq{ Idade = 15, Nome = "João" },
                new PessoaLinq{ Idade = 20, Nome = "José" },
                new PessoaLinq{ Idade = 50, Nome = "Maria" },
                new PessoaLinq{ Idade = 18, Nome = "Claudio" },
            };

            var adolescentes = from p in pessoas
                               where p.Idade > 14 && p.Idade < 20
                               select p;

            foreach (var a in adolescentes)
            {
                Console.WriteLine($"{a.Nome}");
            }
        }

        #endregion

        #region LinqArquivos

        public static void LinqArquivos()
        {
            var arquivos = from arquivo in new DirectoryInfo(@"C:\Fontes\GIT").GetFiles()
                           orderby arquivo.CreationTime
                           where arquivo.Name.Contains(".md")
                           select arquivo;

            foreach (var arquivo in arquivos)
            {
                Console.WriteLine($"Data de criação {arquivo.CreationTime} - Nome: {arquivo.Name}");
            }
        }

        #endregion

        #region LinqIEnumerable

        public static void LinqIEnumerable()
        {
            int[] numeros = { 90, 71, 82, 93, 75, 82 };

            IEnumerable<int> consulta = from n in numeros
                                        where n > 80
                                        orderby n descending
                                        select n;

            foreach (var resultado in consulta)
            {
                Console.WriteLine(resultado);
            }
        }

        #endregion

        #region LinqMultiploFrom

        public static void LinqMultiploFrom()
        {
            int[] numeros = { 1, 2, 3 };
            char[] letras = { 'a', 'b', 'c' };

            var consulta = from numero in numeros
                           from letra in letras
                           select new { numero, letra };

            foreach (var combinacao in consulta)
            {
                Console.WriteLine($"{combinacao.numero} X {combinacao.letra}");
            }
        }

        #endregion

        #region LinqMultiploFrom2

        public static void LinqMultiploFrom2()
        {
            List<Cliente> clientes = new List<Cliente>();

            Cliente cliente1 = new Cliente()
            {
                NomeCliente = "João",
                Pedidos = new List<Pedido>()
                {
                    new Pedido() { NomePedido = "Pizza", Quantidade = 3 },
                    new Pedido() { NomePedido = "Frango", Quantidade = 2 },
                    new Pedido() { NomePedido = "Salada", Quantidade = 1 },
                }
            };

            Cliente cliente2 = new Cliente()
            {
                NomeCliente = "Maria",
                Pedidos = new List<Pedido>()
                {
                    new Pedido() { NomePedido = "Refrigerante", Quantidade = 1 },
                    new Pedido() { NomePedido = "Frango", Quantidade = 2 },
                    new Pedido() { NomePedido = "Salada", Quantidade = 2 },
                    new Pedido() { NomePedido = "Lasanha", Quantidade = 1 },
                }
            };

            clientes.Add(cliente1);
            clientes.Add(cliente2);

            var resultado = from cli in clientes
                            from ped in cli.Pedidos
                            select new
                            {
                                cli.NomeCliente,
                                ped.NomePedido,
                                ped.Quantidade
                            };

            foreach (var res in resultado)
            {
                Console.WriteLine($"Nome: {res.NomeCliente}, Pedido: {res.NomePedido}, Quantidade: {res.Quantidade}");
            }
        }

        #endregion

        #region LinqXMLDocument

        public static XDocument LinqXMLDocument()
        {
            XDocument clientes = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                                 new XComment("Criando XML via LINQ to XML - XDocument"),
                                 new XElement("clientes",
                                 new XElement("cliente", new XAttribute("codigo", 1), new XElement("nome", "João"), new XElement("email", "joao@gmail.com")),
                                 new XElement("cliente", new XAttribute("codigo", 2), new XElement("nome", "Maria"), new XElement("email", "Maria@gmail.com"))));

            clientes.Save(@"C:\Fontes\BackEnd\CSharp\Sample_Linq\XML\Clientes_XDocument.xml");

            return clientes;
        }

        #endregion

        #region LinqXMLXElement

        public static XElement LinqXMLXElement()
        {
            XElement clientes =  new XElement("clientes",
                                 new XElement("cliente", new XAttribute("codigo", 1), new XElement("nome", "João"), new XElement("email", "joao@gmail.com")),
                                 new XElement("cliente", new XAttribute("codigo", 2), new XElement("nome", "Maria"), new XElement("email", "Maria@gmail.com")));

            clientes.Save(@"C:\Fontes\BackEnd\CSharp\Sample_Linq\XML\Clientes_XElement.xml");

            return clientes;
        }

        #endregion
    }
}
