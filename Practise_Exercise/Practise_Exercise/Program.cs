using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_Exercise
{
    class StudentsAndTeacherTest
    {
        static void Main()
        {
            Person p1 = new Person();
            p1.Greet();
       
            Student s1 = new Student();
            s1.ShowAge();
            s1.SetAge(21);
            s1.Greet();

            Teacher t1 = new Teacher();
            t1.Greet();
            t1.Explain();
            t1.SetAge(30);
            Console.ReadLine();
            
        }
    }
}
