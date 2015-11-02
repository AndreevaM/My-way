using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++)
            {

                if (i % 3!=0 &&  i % 7!=0 )
                {
                    
                    Console.WriteLine(i);
                }
                

            }
        }
    }
}
