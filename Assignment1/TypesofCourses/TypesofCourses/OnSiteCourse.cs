using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesofCourses
{
    class OnSiteCourse 
    {
        public string duration;
        public int coursefee;
        public string coursename;
        
        public void OnsiteDetils()
        {
            
            string companyname;
            int noofcandidates;
            int chargepercent = 10;
            int totalfee;
            
                Console.WriteLine("**********It is a On-Site Course**********");
                coursename = ".NET";
                duration = "6 Months";
                coursefee = 100000;
                companyname = "JSP";
                noofcandidates = 35;
                totalfee = chargepercent * coursefee / 100;

                Console.WriteLine(coursename);
                Console.WriteLine(duration);
                Console.WriteLine(coursefee);
                Console.WriteLine(companyname);
                Console.WriteLine(noofcandidates);
                Console.WriteLine(totalfee);
            
        }
    }   
}
