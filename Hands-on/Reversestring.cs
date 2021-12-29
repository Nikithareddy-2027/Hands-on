using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_on
{
    class Reversestring
    {
        public string Data(string input)
        {
            string reverse = "";
            int count = input.Length-1;
            while(count>=0)
            {
                for(int i = 0; i<=count;i++)
                {
                    reverse += input[count];
                    count--;
                }
            }
            Console.WriteLine(reverse);
            return reverse;
        }
    }
}
