using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_Exercise
{
    class Person
    {
        protected int age;
        public void SetAge(int n)
        {
           age = n;
        }
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
}
