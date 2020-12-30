using System;

namespace accessmodifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Public
            PublicClass oPublicClass = new PublicClass();
            oPublicClass.PublicMethod();

            //Private
            PrivateClass oPrivateClass = new PrivateClass();

            Console.WriteLine("PrivateMethod() method present in the PrivateClass.\nBut cannot be accessed in it's object\n\n");

            //Protected
            ProtectedBaseClass oProtectedBaseClass = new ProtectedBaseClass();
            Console.WriteLine("protected variable present in the ProtectedBaseClass.\nBut cannot be accessed in it's object but can be accessed in inherrited class\n\n");

            //Internal
            InternalClass oInternalClass = new InternalClass();
            oInternalClass.MethodInternal();

            //Protected Internal
            ProtectedInternalClass oProtectedInternalClass = new ProtectedInternalClass();
            oProtectedInternalClass.name = "Suman";
            oProtectedInternalClass.print();

            Console.WriteLine("This is the end");

            Console.ReadKey();
        }
    }
}
