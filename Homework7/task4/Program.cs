using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[] { 1,2,3,4,5,6,7,8,9};
            int index = Array.IndexOf(array, n);
            Console.WriteLine(index);
        }
    }
}
