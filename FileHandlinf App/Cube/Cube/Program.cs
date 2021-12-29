using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    class Program
    {
        public static double Input(double a)
        {
            return a * a * a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Input(2.0));
            Console.WriteLine(Input(-5.5));
            Console.ReadKey();
        }
    }
}
