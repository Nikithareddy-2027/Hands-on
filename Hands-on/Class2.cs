using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_on
{
    class Class2
    {
       
        public void Data()
        {
            char[] input = "hello world".ToCharArray();
            int count = 0;
            string empty = string.Empty;
            int length = input.Length-1;

            while(length>=0)
            {
                for (int i = 0; i < length; i++)
                {
                    if (input[i] != ' ')
                    {
                       
                        if(empty[i] == input[i])
                        {
                            empty += input[i];
                            count++;
                        }
                        
                    }
                    
                }
            }
            Console.Write(empty + "-" + count);
        }
        
    }
}
