using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[3, 4] { {5, 6, 1, 7}, {8, 7, 9, 4}, {3, 5, 44, 1} };
            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }
            int[,] array2 = new int[8, 15];
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = i * j;
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine("");
            }
            string[,] paises = { { "El Salvador", "Guatemala", "Honduras" }, { "", "", "" } };
        }
    }
}
