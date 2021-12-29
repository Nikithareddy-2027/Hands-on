using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Print p2 = new Print(Convert.ToInt32(56));
            Print p1 = new Print("Anirudh");
            //Print p2 = new Print(Convert.ToInt32(56));
            Print p3 = new Print("C#", "ASP.NET");
            Print printObj;
            printObj = new Print("These are non-return type functions");
            printObj.TotalFee();
            printObj.DueAmount();
            printObj.Payment();

            Console.ReadKey();
        }
    }
}
