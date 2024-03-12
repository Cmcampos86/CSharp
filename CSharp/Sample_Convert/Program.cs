namespace Sample_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method intentionally left empty.
        }

        #region Parse

        public static void Parse()
        {
            //Preferi usar Parse do Convert
            int numero = int.Parse("1");

            Console.WriteLine(numero);
        }

        #endregion

        #region Convert

        public static void Converter()
        {
            int numero = Convert.ToInt32("1");
            //int numero = Convert.ToInt32(null); //Retorna 0

            Console.WriteLine(numero);
        }

        #endregion
    }
}
