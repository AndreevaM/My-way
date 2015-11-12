using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = rand.Next(0, 100);
            int b = rand.Next(0, 100);
            int c = rand.Next(0, 100);
            int d = rand.Next(0, 100);
            int e = rand.Next(0, 100);
            int f = rand.Next(0, 100);
            int g = rand.Next(0, 100);
            int h = rand.Next(0, 100);
            int i = rand.Next(0, 100);
            int j = rand.Next(0, 100);
            int k = rand.Next(0, 100);
            int l = rand.Next(0, 100);
            int m = rand.Next(0, 100);
            int n = rand.Next(0, 100);
            int o = rand.Next(0, 100);
            int p = rand.Next(0, 100);
            int q = rand.Next(0, 100);
            int r = rand.Next(0, 100);
            int s = rand.Next(0, 100);
            int t = rand.Next(0, 100);
            int u = rand.Next(0, 100);
            int v = rand.Next(0, 100);
            int x = rand.Next(0, 100);
            int y = rand.Next(0, 100);
            int z = rand.Next(0, 100);
            int alfa = rand.Next(0, 100);
            int beta = rand.Next(0, 100);
            int gama = rand.Next(0, 100);
            int delta = rand.Next(0, 100);
            int epsilon = rand.Next(0, 100);


            Console.WriteLine(Proizvedenie(a, b, c));
            Console.WriteLine(Proizvedenie(d, e, f));
            Console.WriteLine(Proizvedenie(g, h, i));
            Console.WriteLine(Proizvedenie(j, k, l));
            Console.WriteLine(Proizvedenie(m, n, o));
            Console.WriteLine(Proizvedenie(p, q, r));
            Console.WriteLine(Proizvedenie(s, t, u));
            Console.WriteLine(Proizvedenie(v, x, y));
            Console.WriteLine(Proizvedenie(z, alfa, beta));
            Console.WriteLine(Proizvedenie(gama, delta, epsilon));
        } 
        

        private static int Proizvedenie(int a, int b, int c)
        {
            int result = a * b * c;
            return result;
        }
    }
}



