using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            int m = int.Parse(Console.ReadLine());
            int[,] integerMatrix = new int[5, 6];

            for (int i = 0; i < integerMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < integerMatrix.GetLength(1); j++)
                {

                    integerMatrix[i, j] = m;
                    m--;
                }
                Console.WriteLine();
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

