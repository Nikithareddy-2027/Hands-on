using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Print
    {
        public Print(int rollno)
        {
            Console.WriteLine(rollno);

        }
        public Print(string name)
        {
            Console.WriteLine(name);
        }
        public Print(string course1, string course2)
        {
            Console.WriteLine(course1);
            Console.WriteLine(course2);
        }
        public static void ServiceTax()
        {
            double tax =12.3;
        }
        public void DueAmount()
        {
            Print.ServiceTax();
        // ServiceTax s1 = new ServiceTax();
            
        }
        public void TotalFee()
        {
            Console.WriteLine("It is TotalFee function");
            //pObj.DueAmount();
        }
        public void Payment()
        {
        Console.WriteLine("Payment details of each courses are provided in payment method");
        int feeOfCSharp = 2000;
        int feeOfASPNET = 3000;
        Console.WriteLine(feeOfCSharp);
        Console.WriteLine(feeOfASPNET);

        }



    } 
}
