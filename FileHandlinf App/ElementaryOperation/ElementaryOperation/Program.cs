using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryOperation
{
    class Program
    {
        public static int Addition(int a , int b)
        {
            return a + b;
        }
        public static int Subtraction(int c , int d)
        {
            return c - d;
        }
        public static int Multiplication(int e , int f)
        {
            return e * f;
        }
        public static double Division(double g, double h)
        {
            if(h == 0)
            {
                Console.WriteLine("It is out of Given context");
                return 0.0;

            }

            return g / h;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Addition(3, 8));
            Console.WriteLine(Multiplication(3, 8));
            Console.WriteLine(Division(3.0, 8.0));
            Console.WriteLine(Subtraction(3, 8));
            Console.ReadKey();
        }
    }
}
