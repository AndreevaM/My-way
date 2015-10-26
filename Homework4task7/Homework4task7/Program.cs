using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = (Console.ReadLine());
            string str2 = (Console.ReadLine());
            bool index = str1.Contains (str2);
            Console.WriteLine(index);
        }
    }
}
