using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int idNumber;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="identification"></param>
        public Person(String firstName, String lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = identification;
        }


        /// <summary>
        /// Print person data
        /// </summary>
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + idNumber);


        }
    }
}

