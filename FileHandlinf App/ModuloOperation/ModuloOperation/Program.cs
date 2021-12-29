using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloOperation
{
    class Program
    {
        public static int Modul(int a, int b, int c)
        {

            return a % b % c;
        }
         public static void Main(string[] args)
        {
            Console.WriteLine(Modul(8, 5, 2));
            Console.ReadKey();
        }
    }
}
