using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10] {1,2,3,4,5,6,7,8,9,10 };
            for (int i = 1; i < x.Length; i++)
            {
                x[i] = 10 * x[i];
                Console.WriteLine(x[i] +"");
            }
        }
    }
}
