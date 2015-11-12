using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] integerMatrix = new int[m, n];

            for (int i = 0; i < integerMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < integerMatrix.GetLength(1); j++)
                {
                    integerMatrix[i, j] = int.Parse(Console.ReadLine());
                }

            }

            for (int i = 0; i < integerMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < integerMatrix.GetLength(1); j++)
                {
                    Console.Write("{0}\t", integerMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
