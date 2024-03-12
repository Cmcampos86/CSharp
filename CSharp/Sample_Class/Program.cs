using AutoMapper;

namespace Sample_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulamento: significa que um grupo de propriedades, métodos e outros membros relacionados é tratado 
            //como uma única unidade ou objeto.

            //Herança: descreve a capacidade de criar novas classes com base em uma classe existente.

            //Polimorfismo: significa que você pode ter várias classes que podem ser usadas de forma intercambiável, 
            //ainda que cada classe implemente as mesmas propriedades ou métodos de maneiras diferentes.

            //public: O acesso pode ser feito de qualquer lugar
            //protected: membros acessado a partir da classe (this) ou das classes que herdam dessa classe(derivadas)
            //internal: membros podem ser acessados só no mesmo assembly
            //private: Só permite acesso dentro do corpo da classe
            //protected internal: Pode ser acessado por todos membros do assembly e/ou por membros derivados

            AutoMapper();

            Console.ReadKey();
        }

        #region InstanciaClasse

        public static void InstanciaClasse()
        {
            //Carro carro; //Cria a referencia
            //carro = new Carro(); //Aloca na memória Heap com o new

            Carro carro = new Carro("Preto");

            //carro.Cor = "Preto"; //Atribuído o valor se não for direto pelo construtor
            Console.WriteLine($"{carro.Descricao()}");
        }

        #endregion

        #region HerancaClasse

        public static void HerancaClasse()
        {
            //Uma classe só pode herdar de uma classe

            //PessoaFisica pessoaFisica = new PessoaFisica();
            //pessoaFisica.nome = "Claudio";

            //PessoaJuridica pessoaJuridica = new PessoaJuridica();
            //pessoaJuridica.endereco = "Rua Teste";

            Aluno aluno = new Aluno();//Quando criamos a instancia da classe derivada, criamos da classe base também
            aluno.Matricula = "123456";
            aluno.Descricao();
            Console.WriteLine();
        }

        #endregion

        #region HerancaClasseConstrutor

        public static void HerancaClasseConstrutor()
        {
            MinhaClasseDerivada classeDerivada = new MinhaClasseDerivada(33);
            //MinhaClasseBase classeBase = (MinhaClasseBase)classeDerivada;

            classeDerivada.Imprimir();
            //classeBase.Imprimir();
        }

        #endregion

        #region EstaticaClasse

        public static void EstaticaClasse()
        {
            //Static
            //É executado sem criar instância, basta chamar a classe e seguido do ponto, chamar o método
            //A classe estática só pode ter membros estáticos
            //Uma clássica estática não pode ser herdada
            //Uma classe estática só possui construtores privados

            Console.WriteLine($"Adição= {Calculadora.Somar(7, 2)}");
            Console.WriteLine($"Subtração= {Calculadora.Subtrair(7, 2)}");
            Console.WriteLine($"Multiplicação= {Calculadora.Multiplicar(7, 2)}");
            Console.WriteLine($"Divisão= {Calculadora.Dividir(7, 2)}");
        }

        #endregion

        #region AbstrataClasse

        public static void AbstrataClasse()
        {
            //O modificador abstract pode ser usado em classes, métodos, propriedades, eventos, indexadores e eventos.
            //Quando o modificador abstract é usado em uma declaração de classe ele sinaliza que a classe não pode ser instanciada indicando que ela é uma classe destinada a 
            //ser uma classe base para outras classes: Ex: public abstract class Teste { }
            //Uma classe abstrata pode conter métodos abstratos e métodos não abstratos;
            //Os métodos abstratos da classe devem possuir apenas a sua assinatura sendo que sua implementação deve ser feita de forma obrigatória pela classe derivada:
            //Um método abstrato é implicitamente um método virtual; (mas um método abstrato não tem implementação e o virtual sim)
            //A implementação do método abstrato na classe derivada é feito usando o modificador override: Ex: public override void Metodo1 { }
            //Quando criamos um método abstrato em uma classe abstrata sua implementação é obrigatória, caso você não implemente na classe derivada o compilador indicará 
            //um erro em tempo de compilação;
            //A declaração de um método abstrato somente é possível em uma classe abstrata;
            //Uma classe que implementa um método abstrato é uma classe concreta;
            //Uma classe abstract não pode ser static

            QuadradoForma q = new QuadradoForma();

            Console.WriteLine(q.Descricao());
            Console.WriteLine($"Informe o valor do lado do quadrado em metros");

            q.Lado = Convert.ToInt32(Console.ReadLine());
            q.CalcularArea();
            q.CalcularPerimetro();

            Console.WriteLine($"A área do quadrado é: {q.Area} m2");
            Console.WriteLine($"O perímetro do quadrado é: {q.Perimetro} m");
        }

        #endregion

        #region Polimorfismo

        public static void Polimorfismo()
        {
            //1.Polimorfismo em tempo de compilação(Overloading/ Sobrecarga);
            //2.Polimorfismo em tempo de execução(Overriding/ Sobrescrita);

            //A sobrecarga de métodos é um conceito onde usamos o mesmo nome do método muitas vezes na 
            //mesma classe, mas cada método com parâmetros diferentes. Com base nos parâmetros passados 
            //a execução é decidida em tempo de compilação.

            //Vantagens do Polimorfismo

            //Polimorfismo promove estensibilidade - O software que invoca comportamento polimórfico é 
            //independente dos tipos para os quais as mensagens são enviadas; (veiculo.Mover())

            //Novos tipos de objetos que respondem a chamadas de métodos existentes podem ser incorporados sem 
            //exigir modificações no sistema básico

            //Podemos instruir os objetos a se comportarem de maneira apropriada, sem nem mesmo conhecer 
            //seus tipos

            //Array de veículo: as Classes Automovel e Aeronave herdam de Veiculo
            Veiculo[] veiculo = new Veiculo[2];

            //Instancia em cada posição do array
            veiculo[0] = new Automovel("Gol");
            veiculo[1] = new Aeronave("Tucano");

            //Para o mesmo método, é passado cada instancia da classe, sendo que mesmo sendo o mesmo metodo,
            //cada um irá usar o seu método (Uma chamada única chamada de método para cada comportamento da classe herdada)
            MovimentarVeiculo(veiculo[0]);
            MovimentarVeiculo(veiculo[1]);
        }

        public static void MovimentarVeiculo(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.Tipo);
            veiculo.Mover();
        }

        #endregion

        #region AutoMapper

        public static void AutoMapper()
        {
            AutoMapper.Entidades.Aluno aluno = new AutoMapper.Entidades.Aluno
            {
                Nome = "Claudio Marcos de Campos",
                Email = "cmcampos86@gmail.com",
                Endereco = new AutoMapper.Entidades.Endereco
                {
                    Pais = "Brasil",
                    Cidade = "Santo André",
                    Rua = "Avenida Capitão Mário Toledo de Camargo",
                    Cep = "09110090"
                },
                Genero = "Masculino",
                Idade = 33,
                Nascimento = new DateTime(1986, 05, 07),
                Disciplina = new List<AutoMapper.Entidades.Disciplina>()
                {
                    new AutoMapper.Entidades.Disciplina
                    {
                        Nome= "Português",
                        Periodo = "Diurno"
                    },
                    new AutoMapper.Entidades.Disciplina
                    {
                        Nome= "Matemática",
                        Periodo = "Noturno"
                    },
                    new AutoMapper.Entidades.Disciplina
                    {
                        Nome= "Geografia",
                        Periodo = "Diruno"
                    }
                }
            };

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AutoMapper.Entidades.Aluno, AutoMapper.Entidades.AlunoViewItem>()
                    //.ForMember(av => av.Endereco, m => m.MapFrom(a => a.Endereco.Cidade + ", " + a.Endereco.Rua));
                    //https://stackoverflow.com/questions/9394833/automapper-with-nested-child-list
                    .ForMember(s => s.Disciplina, c => c.MapFrom(m => m.Disciplina));
            });

            IMapper iMapper = config.CreateMapper();

            AutoMapper.Entidades.AlunoViewItem _alunoViewItem = iMapper.Map<AutoMapper.Entidades.Aluno, AutoMapper.Entidades.AlunoViewItem>(aluno);
        }

        #endregion
    }
}
