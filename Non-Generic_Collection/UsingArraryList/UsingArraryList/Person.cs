using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UsingArraryList
{
    class Person
    {
        public new void ToString()
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();

            string age1 = Console.ReadLine();
            string age2 = Console.ReadLine();
            string age3 = Console.ReadLine();

            //object name1 = "Sandeep";
            //object name2 = "Nikitha";
            //object name3 = "NiSa";

            ArrayList studentObj = new ArrayList();
            studentObj.Add(name1);
            studentObj.Add(name2);
            studentObj.Add(name3);

            //object age1 = 21;
            //object age2 = 32;
           // object age3 = 17;

            ArrayList studentAges = new ArrayList();
            studentAges.Add(age1);
            studentAges.Add(age2);
            studentAges.Add(age3);

            studentObj.AddRange(studentAges);

            Console.WriteLine(studentObj[0] + "\t-\t" + studentAges[0]);
            Console.WriteLine(studentObj[1] + "\t-\t" + studentAges[1]);
            Console.WriteLine(studentObj[2] + "\t-\t" + studentAges[2]);
        }
    }
}
