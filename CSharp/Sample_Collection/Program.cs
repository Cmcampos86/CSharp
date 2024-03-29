﻿using System.Collections;

namespace Sample_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList();
        }

        //Boxing: É a conversão de um Value Type para um Reference Type 
        //Unboxing: É quando um Reference Type(object) volta a ser um value Type

        #region ArrayList

        public static void ArrayList()
        {
            //Aceita valores object(qualquer valor)
            //Para recuperar os valores, precisa fazer umast no tipo correspondente
            ArrayList colecao = new ArrayList();
            colecao.Add("Teste");
            colecao.Add(100);
        }

        #endregion

        #region HashTable

        public static void HashTable()
        {
            //Deve incluir uma chave e valor para a hash table
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "Teste");
            hashTable.Add(2, 100);

            foreach (var item in hashTable.Keys)
            {
                // percorre dados pela chave
            }
        }

        #endregion

        #region Queue

        public static void Queue()
        {
            //Queue: Fila (FIFO)
            Queue fila = new Queue();

            //Inclui elemento
            fila.Enqueue("Teste");
            fila.Enqueue(100);

            foreach (Queue item in fila)
                //Retira elemento
                item.Dequeue();
        }

        #endregion

        #region Stack

        public static void Stack()
        {
            //Queue: Fila (LIFO)
            Stack pilha = new Stack();

            //Inclui elemento
            pilha.Push("Teste");
            pilha.Push(100);

            foreach (Stack item in pilha)
                //Remove e retorna o obejto no topo da coleção
                item.Pop();
        }

        #endregion

        #region Dictionary

        public static void Dictionary()
        {
            //var dicionario = new Dictionary<int, string>();
            var dicionario = new Dictionary<int, string>()
            {
                {5, "Teste"},
                {6, "Teste 6"}
            };

            dicionario.Add(1, "Claudio");
            dicionario[50] = "Curso"; //Outra forma de adicionar um valor ao dicionário

            var nome = dicionario[1]; //Utiliza a key para buscar o valor
        }

        #endregion
    }
}
