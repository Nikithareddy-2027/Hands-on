using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace usingQueue
{
    public class Person
    {
       
        public void ToString()
        {
            Object name1 = "Pritam";
            Object name2 = "Quor";
            Object name3 = "Vrindha";

            object age1 = 24;
            object age2 = 35;
            object age3 = 37;
            Queue q1 = new Queue();
             q1.Enqueue(name1);
            q1.Enqueue(name2);
            q1.Enqueue(name3);

            Queue q2 = new Queue();
            q2.Enqueue(age1);
            q2.Enqueue(age2);
            q2.Enqueue(age3);

            foreach (object obj1 in q1)
            {
                Console.WriteLine(obj1);
            }
                foreach(object obj2 in q2)
                {
                    Console.WriteLine(obj2 );
                   
                }
            

            

          
        }
    }
}
