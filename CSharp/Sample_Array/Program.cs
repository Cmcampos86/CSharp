namespace Sample_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Formas de declarar um array      
            int[] n2 = { 10, 20, 30, 40, 50 };
            //int[] n3 = new int[] { 10, 20, 30, 40, 50 };
            //int[] n4 = new int[5] { 10, 20, 30, 40, 50 };
            //int[] n5 = new int[5];
            //n5[0] = 1;
            //n5[1] = 2;
            //n5[2] = 3;
            //n5[3] = 4;
            //n5[4] = 5;

            ////Array 2 dimensões - 3 linhas e 2 colunas
            //int[,] arr2d = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            PercorreArray();

            Console.ReadKey();
        }

        #region PercorreArray

        public static void PercorreArray()
        {
            char[] vogais = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i <= vogais.Length - 1; i++)
                Console.WriteLine(vogais[i]);
        }

        #endregion

        #region AtribuiMostraArray

        public static void AtribuiMostraArray()
        {
            int[] numeros = new int[20];

            //Atribuir os valores do array
            for (int i = 0; i <= numeros.Length - 1; i++)
                numeros[i] = i;

            //Mostrar os valores do array
            for (int i = 0; i <= numeros.Length - 1; i++)
                Console.WriteLine($"Numeros[{i}]: {numeros[i]}");
        }

        #endregion

        #region MostraArrayForeach

        public static void MostraArrayForeach()
        {
            int[] numeros = new int[20];

            foreach (int n in numeros)
                Console.WriteLine(n);
        }

        #endregion

        #region PercorreArrayBidimensional

        public static void PercorreArrayBidimensional()
        {
            int[,] numeros = new int[3, 2] { { 99, 98 }, { 12, 34 }, { 100, 56 } };

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                    Console.WriteLine(numeros[i, j]);

            }
        }

        #endregion

        #region PercorreArrayBidimensionalForeach

        public static void PercorreArrayBidimensionalForeach()
        {
            int[,] numeros = new int[3, 2] { { 99, 98 }, { 12, 34 }, { 100, 56 } };

            foreach (int n in numeros)
                Console.WriteLine(n);
        }

        #endregion

        #region PercorreArrayTridimensional

        public static void PercorreArrayTridimensional()
        {
            //Array 3 dimensões - uma ou mais dimensões com suas linhas e colunas
            int[,,] arr3d = new int[3, 2, 3];
            arr3d[0, 0, 0] = 1;
            arr3d[0, 1, 0] = 2;
            arr3d[1, 1, 1] = 2;
            arr3d[2, 1, 2] = 3;
            arr3d[2, 0, 2] = 4;

            //Percorre array 3 dimensões
            for (int i = 0; i < arr3d.GetLength(0); i++)
            {
                for (int x = 0; x < arr3d.GetLength(1); x++)
                {
                    for (int y = 0; y < arr3d.GetLength(2); y++)
                        Console.WriteLine($"Índice[{i},{x},{y}] = {arr3d[i, x, y]}");

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region ArrayJagged

        public static void ArrayJagged()
        {
            //Arrays irregulares(Jagged array): é quando temos um ou mais arrays dentro de um array

            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[2] { 7, 9 };
            jaggedArray[1] = new int[4] { 12, 42, 26, 38 };
            jaggedArray[2] = new int[6] { 3, 5, 7, 9, 11, 13 };
            jaggedArray[3] = new int[3] { 4, 6, 8 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Element({0}): ", i + 1);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                    Console.Write(jaggedArray[i][j] + "\t");

                Console.WriteLine();
            }
        }

        #endregion
    }
}
