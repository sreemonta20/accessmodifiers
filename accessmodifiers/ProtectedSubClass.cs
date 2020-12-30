using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifiers
{
    class ProtectedSubClass :ProtectedBaseClass
    {

        /*This allows variables and methods to access from that class and the sub class of the class. 
         * That means that methods can be accessed within that class and from the classes, 
         * which actually inherit that class.
         */
        ProtectedSubClass()
        {
            this._val = 10;
            Console.WriteLine("protected int _val of ProtectedBaseClasss can be accessed into ProtedctedSubClass and initialized  ");
            
        }

    }
}
