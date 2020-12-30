using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifiers
{
    class inprivatecls: PrivateClass
    {
        public void bd()
        {
            PrivateClass obb = new PrivateClass();

            obb.st();
        }
    }
}
