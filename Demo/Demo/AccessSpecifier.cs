using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class AccessSpecifier
    {
        //creating access modifiers / specifiers and assigning.



        //public has no limits. 
        //It can be accessed inside the container class or in another class too.
        public int publicId = 01;

        //private has limits.
        //It can be accessed only inside the same class or function.
        private int privateAge = 12;

        //protected is used while inheritance.
        // Or it is accessible while a child class is inherited by parent class.
        protected string protectedName = "John";

        //Internal class can be accessed wherever inside the assembly.
        internal string internalSubject = "Maths";

        //Protected Internal is a combinational specifier. 
        //It will be accessible within the assembly cz of internal flavor and also via inheritance cz of protected flavor.
        protected internal int protectedinternalStudentclass = 8;

        //Access specifier functions.
        public int PublicFunction()
        {
            return publicId;
        }

        private int PrivateFunction()
        {
            return privateAge;
        }
        protected string ProtectedFunction()
        {
            return protectedName;
        }
        internal string InternalFunction()
        {
            return internalSubject;
        }
        protected internal int ProtectedInternalFunction()
        {
            return protectedinternalStudentclass;
        }
    }
    class Call : AccessSpecifier
    {
        //Method Hiding : we use new keyword to hide parent class.
        //only public and internal functions or variables can be accessed.
        public  void PublicFunction()
        {

            //We can access internal function anywhere inside the whole assembly.
            this.InternalFunction();
            Console.Write("id : {0} ", publicId);
            Console.WriteLine("//Method Binding output");
        }
        //functions that can be accessed with intheritance are : public, internal, protected, protected internal.
        //private cannot accessed because it has limits / accessible only inside the parent class where it is created.
        public void InheritanceClass()
        {
            this.PublicFunction();
            this.ProtectedFunction();
            this.ProtectedInternalFunction();
            this.InternalFunction();
        }

        //Here except private all other access specifiers are available.
        public void Display()
        {
            Console.WriteLine(publicId + "  " + protectedName + "  " + internalSubject + "  " + protectedinternalStudentclass);
            //Console.WriteLine();
        }
    }
}
