using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace usingstack
{
    
        //Object name1 = "Sanju";
        // Object name2 = "Nikky";
        //Object name3 = "Sani";
        // Object age1 = 22;
        //Object age2 = 42;
        //Object age3 = 78;
    class Person
    {
        
        string name1 = Console.ReadLine();
        string name2 = Console.ReadLine();
        string name3 = Console.ReadLine();
        string age1 = Console.ReadLine();
        string age2 = Console.ReadLine();
        string age3 = Console.ReadLine();
       
        public void ToString()
        {
            Stack s1 = new Stack();
            s1.Push(name1);
            s1.Push(name2);
            s1.Push(name3);

            Stack s2 = new Stack();
            s2.Push(age1);
            s2.Push(age2);
            s2.Push(age3);
            Console.WriteLine("ENter into console");
            //Console.WriteLine((string)s1[0] + "-" + s2[0]);
            for (int i = 0; i<=s1.Count+1;i++)
            {
                Console.WriteLine(s1.Pop() + "-" + s2.Pop());
            }
        }
    }
}
