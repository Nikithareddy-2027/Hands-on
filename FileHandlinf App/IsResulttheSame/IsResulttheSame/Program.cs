using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsResulttheSame
{
    class Program
    {
        public static string Check1(int a , int b, int c, int d)
        {
            if (a + b == c * d)
            {
                return "True";
            }
            else
                return "False";
        }
        public static string Check2(double e, double f, double g, double h)
        {
            if (e / f == g - h)
            {
                return "True";
            }
            else
                return "False";
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Check1(2, 2, 2, 2));
            Console.WriteLine(Check2(9, 3, 16, 1));
            Console.ReadKey();
        }
    }
}
