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
           // int length = int.Parse(Console.ReadLine());
            int[] a = new int[] { 2, 6 ,4, 5, 7};
            int sum = 0;
            for (int i = 0; i < a.Length; i += 2)
            {
                sum += a[i];

               
            }

            Console.WriteLine(sum);




        }
    }
}
