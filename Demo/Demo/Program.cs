using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           //Creating object for parent class.
            //Here private and protected are not called.

            Console.WriteLine("*********************Access Specifiers is started here****************");

            AccessSpecifier am = new AccessSpecifier();
            am.PublicFunction();
            am.InternalFunction();
            am.ProtectedInternalFunction();
            
            //Object creation for child class.
            //Here only Method Hiding function is called.
            
            AccessSpecifier amobj = new Call();
            amobj.PublicFunction();

            //Object creation for Call class to call other functions in that class.
            
            Call c1 = new Call();
            c1.InheritanceClass();
            c1.Display();
            Console.WriteLine("*********************Access Specifiers is ended here****************");
            Console.WriteLine();
            Console.ReadKey();

            /*
            Console.WriteLine("***************Here Operator overloading starts********************* ");
            // using overloaded - operator
            // with the class object
            Calculator calc = new Calculator(15, -25);
            calc = -calc;

            // To display the result
            calc.Print();
            Console.WriteLine("***************Here Operator overloading ends********************* ");
            Console.ReadKey();
           */
        }
    }
}
