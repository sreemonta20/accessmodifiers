using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifiers
{
    class ProtectedInternalClass
    {
        /*Protected Internal allows you to access the variables and methods to access from that class and sub classes of that class. 
         * Also allows to access within the same assembly. This means in protected, if the class is inheriting the super class and 
         * the method or variable is protected, then the assembly doesn't matter to access. But in the Internal, the assembly matters 
         * if the class is inheriting the super class. That is why we use Protected Internal access modifier.
         */

        protected internal string name; // protected internal
        protected internal void print()
        {
            Console.WriteLine("\n Protected Internal : My name is " + name +"\n\n");
        }
    }
}
