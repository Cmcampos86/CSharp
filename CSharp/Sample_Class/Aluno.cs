namespace Sample_Class
{
    public class Aluno : PessoaFisica
    {
        public string Matricula { get; set; }

        public Aluno()
        {
            Console.WriteLine($"Construtor da classe Aluno");
        }

        //Método Hiding
        //Quando temos um mesmo nome de objeto (método, propriedades e etc) na classe base e derivada, o objeto
        //da classe base será ocultado e será usado o método da classe derivada
        //Por mais que o compilador aceite isso, é aconselhável colocar a palavra new na frente do objeto da 
        //classe derivada.

        //new public string Descricao()
        public new string Descricao()
        {
            return $"Sou o método Descricao da classe Aluno";
        }

        public string Mostrar()
        {
            //Usando a palavra base, eu consigo acessar o método ocultado
            return base.Descricao();
        }

    }
}
