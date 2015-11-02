using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long[] fibunaci = new long[n];
            fibunaci[0] = 0;
            fibunaci[1] = 1;
            
            Console.WriteLine(fibunaci[0]);
            Console.WriteLine(fibunaci[1]);

            for (int i = 2; i < n; i++)
            {
                fibunaci[i] = fibunaci[i - 2] + fibunaci[i - 1];

                Console.WriteLine(fibunaci[i]);
            }


        }
    }
}
