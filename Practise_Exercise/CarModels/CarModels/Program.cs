using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModels
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AssesmblyLine.SuccessRate(10);
            AssesmblyLine.ProductionRatePerHour(6);
            AssesmblyLine.WorkingItemsPerMinute(6);
            Console.ReadKey();
        }
    }
}
