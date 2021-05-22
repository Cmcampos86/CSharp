using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Reflection
{
    class Program
    {
        //A reflection é algo interessante que o.Net fornece, com ela podemos escrever código o qual lê as informações do metadado dos objeto em tempo de execução.
        //Essas informações são toda a estrutura existente na classe, portanto métodos, propriedades e até mesmo atributos de classes e métodos são visualizadas.

        static void Main(string[] args)
        {
            InstaciaAssembly();

            Console.ReadKey();
        }

        #region NomeAssembly

        public static void NomeAssembly()
        {
            var assembly = Assembly.GetExecutingAssembly();

            Console.WriteLine(assembly.FullName);
        }

        #endregion

        #region TipoAssembly

        public static void TipoAssembly()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine($"Type: {type.Name}");
            }
        }

        #endregion

        #region TipoBaseAssembly

        public static void TipoBaseAssembly()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine($"Type: {type.Name}, BaseType: {type.BaseType}");
            }
        }

        #endregion

        #region PropriedadeAssembly

        public static void PropriedadeAssembly()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine($"Tipo: {type.Name}");

                var props = type.GetProperties();

                foreach (var prop in props)
                {
                    Console.WriteLine($"Propriedade: {prop.Name}, Tipo: {prop.PropertyType}");
                }
            }
        }

        #endregion

        #region CamposAssembly

        public static void CamposAssembly()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine($"Tipo: {type.Name}");

                var fields = type.GetFields();
                foreach (var field in fields)
                {
                    Console.WriteLine($"Campos: {field.Name}");
                }
            }
        }

        #endregion

        #region MetodosAssembly

        public static void MetodosAssembly()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine($"Tipo: {type.Name}");

                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine($"Campos: {method.Name}");
                }
            }
        }

        #endregion

        #region InstaciaAssembly

        public static void InstaciaAssembly()
        {
            var cliente = new Cliente { Nome = "João", Idade = 25 };
            var tipo = typeof(Cliente);
            var propriedadeNome = tipo.GetProperty("Nome");

            Console.WriteLine($"O valor da propriedade Nome: {propriedadeNome.GetValue(cliente)}");
            
            //Exsecuta o método por Reflection
            var metodo = tipo.GetMethod("Mensagem");
            metodo.Invoke(cliente, null);

        }

        #endregion
    }
}
