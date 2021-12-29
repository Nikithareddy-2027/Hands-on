using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Calculator
    {
        //Unary operator Overloading.
        public int number1, number2;
            public Calculator(int num1, int num2)
            {
                number1 = num1;
                number2 = num2;
            }

            // Function to perform operation
            // By changing sign of integers
            public static Calculator operator -(Calculator c1)
            {
                c1.number1 = -c1.number1;
                c1.number2 = -c1.number2;
                return c1;
            }

            // Function to print the numbers
            public void Print()
            {
                Console.WriteLine("Number1 = " + number1);
                Console.WriteLine("Number2 = " + number2);
            }
    }
}









/* 
 * Operator Overloading: It gives ability to use the same operator to do various operations.
 * To use operators with user-defined data types, they need to be overloaded according to a programmer’s requirement.
 * An operator can be overloaded by defining a function to it. The function of the operator is declared by using the operator keyword. 
 * It must have return-type and parameters.
 
 * Syntax: access specifier classname Operator keyword followed by(user entered operator) (parameters).
   {
     //code;
   }
 * These are the accessibility of data types in overloading.
 * ->    +, -, !, ~, ++, – –	unary operators take one operand and can be overloaded.
   ->    +, -, *, /, %	Binary operators take two operands and can be overloaded.
   ->    ==, !=, =	Comparison operators can be overloaded.
   ->    &&, ||	Conditional logical operators cannot be overloaded directly
   ->    +=, -+, *=, /=, %=, =	Assignment operators cannot be overloaded.
 */
