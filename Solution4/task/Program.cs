using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int m = n * n;
            int[] arr1 = new int[m];
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                
                sum += arr1[i];

            }
            Console.WriteLine(sum);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = arr1[i];
                }
                Console.WriteLine();

            }

            int counter = 0;
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                    matrix[j, i] = arr1[counter];
                    counter++;

                    //Console.Write("{0}\t", matrix[i, j]);
                }
                
                Console.WriteLine();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    

                    Console.Write("{0}\t", matrix[i, j]);
                }

                Console.WriteLine();
            }

        }
    }
}
