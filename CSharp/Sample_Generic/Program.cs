using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generics: coleção tipada
            //O parâmetro <T> na declaração da lista é obrigatório e indica qual o tipo de dados que poderá ser incluído na coleção
        }

        #region AdicionaItem

        public static void AdicionaItem()
        {
            List<string> listaString = new List<string>();
            List<int> listaInteiro = new List<int>();
            List<Cliente> cliente = new List<Cliente>();

            //Somente vai aceita a classe Cliente com base na restrição da classe ListaGenerica
            ListaGenerica<Cliente> ListaCliente = new ListaGenerica<Cliente>();

            listaString.Add("String1");
            listaString.Add("String2");
            listaInteiro.Add(100);

            cliente.Add(new Cliente("Teste"));
        }

        #endregion
    }
}
