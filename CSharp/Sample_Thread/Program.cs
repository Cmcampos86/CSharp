namespace Sample_Thread
{
    class Program
    {

        static void Main(string[] args)
        {
            //Thread é uma forma de um processo dividir a si mesmo em duas ou mais tarefas, podendo executar elas concorrentemente.
            //Aplicações multithread permitem que você execute várias threads ao mesmo tempo, cada uma executando um passo por exemplo.
            //Caso nós não sincronizarmos corretamente as threads, fatalmente cairemos nos famigerados deadlocks.

            //Métodos:
            //Suspend(): Suspende a execução de uma Thread, até o método Resume() seja chamado.
            //Resume(): Reinicia uma thread suspensa. Pode disparar exceções por causa de possíveis status não esperados das threads.
            //Sleep(): Uma thread pode suspender a si mesma utilizando esse método que espera um valor em Milisegundos para especificar esse tempo de pausa.
            //Join(): Chamado por uma thread, faz com que outras threads espere por ela até que ela acabe sua execução.
            //CurrentThread(): Método estático que retorna uma referência à thread em execução

            //Estados de uma Thread:
            //Aborted: Thread já abortada;
            //AbortRequested: Quando uma thread chama o método Abort();
            //Background: Rodando em bnackground;
            //Running: Rodando depois que outra thread chama o método start();
            //Stopped: Depois de terminar o método run() ou Abort();
            //Suspended: Thread Suspendida depois de chamar o método Suspend();
            //Unstarted: Thread criada mas não iniciada.
            //WaitSleepJoin: Quando uma thread chama Sleep() ou Join(), ou quando uma outra thread chama join();

            //Propriedades:
            //Name: Retorna o nome da thread;
            //ThreadState: Retorna o etado de uma thread;
            //Priority: Retorna a prioridade de uma thread. As prioridades podem ser:
            //Highest
            //AboveNormal
            //Normal
            //BelowNormal
            //Lowest
            //IsAlive: Retorna um valor booleano indicando se uma thread esta “viva” ou não;
            //IsBAckground: Retorna uma valor booleano indicando se a thread está rodando em Background ou Foreground;

            ThreadJoin();

            Console.ReadKey();
        }

        #region ThreadCriar

        public static void ThreadCriar()
        {
            Console.WriteLine("Thread principal iniciada");
            Thread.CurrentThread.Name = "Principal - ";

            //Cria uma Thread apontando para o método ThreadMetodo
            Thread t1 = new Thread(new ThreadStart(ThreadMetodo));
            t1.Name = "Secundária - ";
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread Atual  - " + Thread.CurrentThread.Name + i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Thread Principal terminada");
        }

        public static void ThreadMetodo()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread Atual - " + Thread.CurrentThread.Name + i);

                Thread.Sleep(1000);
            }
        }

        #endregion

        #region ThreadLock

        public static void ThreadLock()
        {
            //Lock: obriga-nos a especificar um token(uma referência de objeto) que deve ser adquirido por uma thread para entrar no escopo do lock (bloqueio).
            //Quando estamos tentando bloquear um método em nível de instância, podemos simplesmente passar a referência a essa instância. (Nós podemos usar esta palavra-chave
            //para bloquear o objeto atual). Uma vez que a thread entra em um escopo de bloqueio, o sinal de trava(objeto de referência) é inacessível por outros segmentos, 
            //até que o bloqueio seja liberado ou o escopo do bloqueio seja encerrado.

            Console.WriteLine("======MultiThreads======");

            Printer p = new Printer();
            Thread[] Threads = new Thread[3];

            for (int i = 0; i < 3; i++)
            {
                Threads[i] = new Thread(new ThreadStart(p.PrintNumbersLock));
                Threads[i].Name = "threadFilha " + i;
            }

            foreach (Thread t in Threads)
                t.Start();
        }

        #endregion

        #region ThreadMonitor

        public static void ThreadMonitor()
        {
            //Método Monitor.Enter() é o destinatário final do token da thread.Precisamos escrever todo o código do escopo de bloqueio dentro de um bloco try. 
            //A cláusula finally assegura que o token de thread seja liberada(usando o método Monitor.Exit () , independentemente de qualquer exceção de runtime.            

            Console.WriteLine("======MultiThreads======");

            Printer p = new Printer();
            Thread[] Threads = new Thread[3];

            for (int i = 0; i < 3; i++)
            {
                Threads[i] = new Thread(new ThreadStart(p.PrintNumbersMonitor));
                Threads[i].Name = "threadFilha " + i;
            }

            foreach (Thread t in Threads)
                t.Start();
        }

        #endregion

        #region ThreadJoin

        public static void ThreadJoin()
        {
            Thread join = new Thread(ThreadJoinMetodo);
            join.Start();

            //Aguarda o término da thread
            join.Join();

            Console.WriteLine("\r\n\r\nA Thread Join terminou a sua execução!");
            Console.ReadKey();
        }

        static void ThreadJoinMetodo()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("Teste Thread com Join");
        }

        #endregion
    }
}
