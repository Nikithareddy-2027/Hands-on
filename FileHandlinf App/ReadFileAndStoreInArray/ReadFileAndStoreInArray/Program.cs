using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFileAndStoreInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\.NET Capgemini Training\\networklog.txt";
            StreamReader s1 = new StreamReader(path);
            int totalFileSize = 12;
            int[] Id = new int[totalFileSize];
            string[] Source = new string[totalFileSize];
            string[] Destination = new string[totalFileSize];
            string[] Date = new string[totalFileSize];
            string[] Status = new string[totalFileSize];
            string[] Network = new string[totalFileSize];

            int i = 0;
            int[] j = new int [i];
            string st = "";
            string TextBox1 = "";
            while (s1.Peek() != -1)
            {
                string readmyline = s1.ReadLine();
                var Id1 = Convert.ToInt32(Id[0]);
                //int[] Id =txtProductOptn1.Text.Split(':'));
                //var Id1 = Convert.ToInt32(Id);
               // Id[i] = Convert.ToInt32(Id);
                j= j + Id;
                if (Id.Length>1)
                {
                    Console.WriteLine(Id[1]);
                }

                Source[i] = Convert.ToString(readmyline.Split(':'));
                st = st + Source[i].ToString() + "\n";
                if (Id.Length > 1)
                {
                    Console.WriteLine(Id[1]);
                }

                Destination[i] = Convert.ToString(readmyline.Split(':'));
                st = st + Destination[i].ToString() +"\n";
                if (Id.Length > 1)
                {
                    Console.WriteLine(Destination[1]);
                }

                Date[i] = Convert.ToString(readmyline.Split(':'));
                {
                    Console.WriteLine("Date: {0:dd-MM-yy} Time: {0:hh:mm:ss}", Date);
                }
                st = st + Date[i].ToString() + "\n";
                if (Id.Length > 1)
                {
                    Console.WriteLine(Date[1]);
                }

                Status[i] = Convert.ToString(readmyline.Split(':'));
                st = st + Status[i].ToString() + "\n";
                if (Id.Length > 1)
                {
                    Console.WriteLine(Status[1]);
                }

                Network[i] = Convert.ToString(readmyline.Split(':'));
                st = st + Network[i].ToString() + "\n";
                if (Id.Length > 1)
                {
                    Console.WriteLine(Network[1]);
                }
                i++;
            }
           
        }
    }
}
