using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentinelProgram
{
    class Program
    {
        public string SENTINEL { get; set; }
        static void Main(string[] args)
        {
            string[] inputs = { "test2", "test1" };
            Program p = new Program();
            p.SENTINEL = "~";
            p.JoinIt(inputs);
            p.SplitIt("test");
            p.Reverse("test");
            p.PadLeft("test", 2, 'a');
           Console.ReadKey();
        }
        public string JoinIt(string[] input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);
            }
            string result = sb.ToString();
            return result;
        }

        public string[] SplitIt(string input)
        {
            return input.Split('~');
        }
        public StringBuilder Reverse(string input)
        {
            StringBuilder st = new StringBuilder();
            var getchars = input.ToCharArray();
            Array.Reverse(getchars);
            string str = string.Empty;
            for (int i = 0; i < getchars.Length; i++)
            {
                st.Append(getchars[i].ToString());
            }

            return st;
        }
        public string PadLeft(string input, int n, char a)
        {
            return input.PadLeft(n, a);
        }
    }
}


