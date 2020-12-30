using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifiers
{
    class InternalClass
    {
        /* This Internal allows accessibility in the assembly. Assemble is slightly different from Namespace
         Assembly is just like DLL of the project. One Assembly can contain several namespace
         */

        internal void MethodInternal()
        {
            Console.WriteLine("Internal Method\n\n");

        }
    }
}
