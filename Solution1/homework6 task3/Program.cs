using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
                
            {
                int a = int.Parse(Console.ReadLine());
                if (a> max)
                {
                    max = a;
                }
                if (a<min)
                {
                    min = a;
                }
                
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
           
           
        }
    }
}
