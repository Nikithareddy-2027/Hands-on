using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingRemoveAll
{
    class Program
    {
        public static void main (string[ ] args)
        {
           string sa = "a";
            List<string> l1 = new List<string>();
            l1.Add("abc");
            l1.Add("cdaef");
            l1.Add("js");
            l1.Add("php");

            foreach(string s1 in l1)
            {
                if (s1.Contains("a")) ;
                {
                    Console.Write(l1.RemoveAll(sa));
                }
            }
           
              
        }
    }
}
