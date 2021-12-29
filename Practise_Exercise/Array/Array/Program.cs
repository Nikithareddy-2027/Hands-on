using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessing_array_value
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[6];
            string[] name = new string[6];
            int i, j = 0;
            string find;

            // Storing users name and age in two different array. 
            for (i = 0; i < 6; i++)
            {
                Console.Write("\n\nEnter your name:\t");
                name[i] = Console.ReadLine();
                
                Console.Write("Enter your age:\t\t");
                age[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Accepting name and find their correspondence age in array.

            Console.Write("\n\nEnter your name to find age:\t");
            find = Console.ReadLine();

            for (i = 0; i < 6; i++)
            {
                if (name[i] == find)
                {
                    Console.WriteLine("\n\nName\t:{0}", name[i]);
                    Console.WriteLine("Age\t:{0}", age[i]);
                    j++;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Not Found!!!");
            }
            Console.ReadLine();
        }
    }
}
