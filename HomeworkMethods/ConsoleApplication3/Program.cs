using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            string FirstName = "Greetings,";
            string Name = Console.ReadLine();
            
            MyName(FirstName, Name);
        }

        public static void MyName(string FirstName, string Name)

        {
            string full = FirstName + ","+ Name+ "!" ;
            Console.WriteLine(full); 
        }

    }

}





