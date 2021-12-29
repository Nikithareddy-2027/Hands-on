using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_Exercise
{
     class Student : Person
    {
       
        public void GoToClasses()
        {
            Console.WriteLine("i'm going to class");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is : {0} years old" , age );
        }
    }
}
