using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] integerMatrix = new int[2, 2];

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
                    if (integerMatrix[i, j] % 2 == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine(integerMatrix[i, j]); 
                    }
                }
            }

        }
    }
}
