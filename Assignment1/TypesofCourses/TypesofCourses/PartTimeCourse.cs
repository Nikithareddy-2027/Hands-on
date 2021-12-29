using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TypesofCourses
{
    public class PartTimeCourse
    {
       
        public string duration;
        public int coursefee;
        
        public string coursename;
        public void Details()
        {
           
            int chargepercent = 10;
            int totalfee;
            string timing = "9 am - 1 pm";
            
                Console.WriteLine("**********It is a Part-Time Course**********");
                coursename = "C#";
                duration = "3 Months";
                coursefee = 50000;
                totalfee = chargepercent * coursefee / 100;

                Console.WriteLine(coursename);
                Console.WriteLine(duration);
                Console.WriteLine(coursefee);
                Console.WriteLine(totalfee);
                Console.WriteLine(timing);
           
        }
    }
}

