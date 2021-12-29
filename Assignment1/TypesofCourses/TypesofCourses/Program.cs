using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesofCourses
{
    class Program
    {
        public static void Main(string[] args)
        {
            int month;
            Console.Write("Enter months here : ");
            month = Console.Read();
            if (month == 0 && month <= 3)
            {
                PartTimeCourse pt = new PartTimeCourse();
                pt.Details();
            }
            else
            {
                OnSiteCourse os = new OnSiteCourse();
                os.OnsiteDetils();
            }
           
            Console.ReadKey();
        }
    }
}
