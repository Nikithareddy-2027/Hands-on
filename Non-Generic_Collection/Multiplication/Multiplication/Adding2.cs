using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Adding2
    {
        public void ListProgram()
        {
            List<int> obj = new List<int>();
            obj.Add(1);
            obj.Add(2);
            obj.Add(3);
            obj.Add(4);
            foreach(var n in obj)
            {
                
                Console.Write((n+2)*5 + " ");
            }
            

        }
    }
}
