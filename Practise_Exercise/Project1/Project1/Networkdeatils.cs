using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project1
{
    class Networkdeatils
    {
        public void Jio()
        {
            //File creation
            FileStream filestreamObj = new FileStream("D:\\.NET Capgemini Training\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader s1 = new StreamReader(filestreamObj);
            Console.WriteLine("Id\t\tSource\t\tDestination\t\tDate\t\tStatus\t\tNetwork");
            while(s1.Peek()>0)
            {
                String line = s1.Readline();
                string[] values = line.Split(':');
                if (line != " ")
                {
                    if (values.Length > 1)
                    {
                        if (line.StartsWith("Date"))
                        {
                            string date = values[1].Split(' ')[0];
                            Console.Write(date + "\t\t");
                        }
                        else
                        {
                            Console.Write(values[1] + "\t\t");
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }

                 
               
            
        }
    }
}
