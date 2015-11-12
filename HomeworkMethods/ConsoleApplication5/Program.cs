using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Number(a);
            Number(b);
            Number(c);
        }

        public static void Number(int a)

        {
            if (a % 2 == 0)
            {
                Console.WriteLine("chetno");
            }
            else
            {
                Console.WriteLine("nechetno");
            }
        }
    }
}

