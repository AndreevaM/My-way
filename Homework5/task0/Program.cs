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
            Console.WriteLine("Please enter a number form 1 to 9:");
            int x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 3)
            {
                int y = x * 5;
                Console.WriteLine(y);
            }
            else if (x >= 4 && x <= 6)

            {
                int z = x * 10;
                Console.WriteLine(z);
            }
            else if (x >= 7 && x <= 9) 
            {
                int t = x * 50;
                Console.WriteLine(t);
            }
        }
    }
}
