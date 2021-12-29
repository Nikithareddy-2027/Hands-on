using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcat
{
    class StringClass
    {
        public void Concating()
        {
            List<string> obj = new List<string>();
            obj.Add("1");
            obj.Add("2");
            obj.Add("3");
            obj.Add("4");

            foreach(string n in obj)
            {
                Console.Write((n + n + n + n) + " ");
            }
        }
    }
}
