using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OpennPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("id   " + "     Source    " + "      Destination     " + "    Date     " + "       Status       " + "         Network       ");
            FileStream f1 = new FileStream("D:\\Capgemini Training\\Practise_Exercise\\Project1\\Network_Example.txt", FileMode.Open, FileAccess.Read);
            StreamReader s1 = new StreamReader(f1);
            while (s1.Peek() > 0)
            {
                string readmyline = s1.ReadLine();
                string[] strings = readmyline.Split(':');
                if (strings.Length > 1)
                {
                    Console.WriteLine( strings[1]);
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
