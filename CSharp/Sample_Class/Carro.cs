using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Class
{
    public class Carro
    {
        //get: retorna valor
        //set: atribuí valor

        ////Notação antiga
        //private string _cor;
        //public string Cor
        //{
        //    get { return _cor; }
        //    set { _cor = value; }
        //}

        ////Notação antiga com verificação na atribuição
        //private string _cor;
        //public string Cor
        //{
        //    get { return _cor; }
        //    set 
        //    {
        //        if (value.Contains("Prata Preto Branco"))
        //            _cor = value;
        //        else
        //            throw new Exception($"As cores disponíveis são: Prata, Preto e Branco");
        //    }
        //}

        //Pode ter vários construtores com parâmetros diferentes
        public Carro()
        {

        }

        public Carro(string cor)
        {
            this.Cor = cor; //this: a própria classe
        }

        public string Cor { get; set; }
        //public string Cor { get; private set; } //Somente leitura
        //public string Cor { private get; set; } //Somente atribuição

        public string Descricao()
        {
            return $"O carro é: {Cor}";
        }

        ////Destrutor: o garbage colector faz a mesma coisa
        //~Carro()
        //{ 
        //    //Instruções
        //}
    }
}
