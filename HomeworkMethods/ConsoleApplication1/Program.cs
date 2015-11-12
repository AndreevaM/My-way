using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            MaxNumber(a, b);
            int result = MaxNumber(a, b); 
            MaxNumber(result, c);

            Console.WriteLine(MaxNumber(result, c));

        }

        public static int MaxNumber(int firstNumber, int secondNumber)
        {
            int max = 0;
            if (firstNumber > secondNumber)
            {
                max = firstNumber;
                return max;
            }
            else
            {
                max = secondNumber;
                return max;
            }
            Console.WriteLine(max);



        }
    }
}


