using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Class
{
    public partial class ClasseParcial
    {
        //Usando o conceito de partial class você pode dividir a definição de sua classe em mais 
        //de um arquivo físico.

        //Para funcionar, podemos criar duas classes com nomes dos arquivos diferentes, porém, o nome das classes
        //dentro do arquivo pode ser o mesmo, desde que, contenha a palavra partial.
        //Quando instanciar a classe partial, todos os métodos, propriedades e etc da classe, estará acessível.

        public void Metodo1()
        {
            Console.WriteLine("Método1");
        }

        public void Metodo2()
        {
            Console.WriteLine("Método2");
        }
    }
}
