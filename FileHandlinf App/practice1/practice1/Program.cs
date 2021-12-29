using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    
    class CelsiustoFarhenheit
    {
        public static string ConvertMethod(double celsius)
        {
            double farenheit;
            if (celsius < -273.15)
            {
                return "Temperature below -273.15 is not exist";
            }
            farenheit = celsius * 1.8 + 32;
            return $"T = {farenheit}F";
        }
        class Program
        {
            public static void Main()
            {
                Console.WriteLine(ConvertMethod(0));
                Console.WriteLine(ConvertMethod(100));
                Console.WriteLine(ConvertMethod(-300));
                Console.ReadLine();
            }
        }
    }

        
}
