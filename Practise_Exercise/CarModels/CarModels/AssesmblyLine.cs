using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModels
{
    public static class AssesmblyLine
    {
        public static int SuccessRate(int SR)
        {
            //int[] SuccessRate = { };

            if (SR == 0)
            {
                Console.WriteLine("SuccessRate is : 0.00");
            }
            else if (SR >= 1 && SR <= 4)
            {
                Console.WriteLine("SuccessRate is : 0.10 ");
            }
            else if (SR >= 5 && SR <= 8)
            {
                Console.WriteLine("SuccessRate is : 0.90 ");
            }
            else if (SR == 9)
            {
                Console.WriteLine("SuccessRate is : 0.80 ");
            }
            else
            {
                Console.WriteLine("SuccessRate is : 0.77 ");
            }
            return SR; 
        }
        public static int ProductionRatePerHour(int SR)
        {
            int x = 221;
            if (SR == 0)
            {
                SR *= x;
                Console.WriteLine("Production Per Hour is : " + SR);
            }
            else if (SR >= 1 && SR <= 4)
            {
                SR *= x;
                Console.WriteLine("Production Per Hour is : " + SR);
            }
            else if (SR >= 5 && SR <= 8)
            {
                SR *= x;
                 Console.WriteLine("Production Per Hour is : " + SR);
            }
            else if (SR == 9)
            {
                SR *= x;
                Console.WriteLine("Production Per Hour is : " + SR);
            }
            else
            {
                SR *= x;
                Console.WriteLine("Production Per Hour is : " + SR);
            }
            return SR;
        }
        public static int WorkingItemsPerMinute(int SR)
        {
            int perHour = 221;
            int perMinute = 221 / 60;
            if (SR == 0)
            {
                SR *= perMinute;
                Console.WriteLine("Production Per Minute is : " + SR);
            }
            else if (SR >= 1 && SR <= 4)
            {
                SR *= perMinute;
                Console.WriteLine("Production Per Minute is : " + SR);
            }
            else if (SR >= 5 && SR <= 8)
            {
                SR *= perMinute;
                Console.WriteLine("Production Per Minute is : " + SR);
            }
            else if (SR == 9)
            {
                SR *= perMinute;
                Console.WriteLine("Production Per Minute is : " + SR);
            }
            else
            {
                SR *= perMinute;
                Console.WriteLine("Production Per Minute is : " + SR);
            }
            return SR;
        }
    }
}
