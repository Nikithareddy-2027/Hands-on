using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapOfTwo
{
    class Program
    {
        public static string Input(int a, int b)
        {
            string before = $"Before: a = {a}, b = {b} ";
            int swap;
            swap = b;
            b = a;
           a = swap;
            string after = $"After: a ={a}, b = {b}";
            return before + after;
        }
        public static void Main()
        {

            Console.WriteLine(Input(87, 45));
            Console.WriteLine(Input(-13, 2));
            Console.WriteLine(Input(67, 98));
            Console.ReadKey();

        }
    }
}
