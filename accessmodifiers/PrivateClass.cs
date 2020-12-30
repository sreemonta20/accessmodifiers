using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifiers
{
    class PrivateClass
    {
        private void PrivateMethod()
        {

            Console.WriteLine("Private Method  [Invalid Code Access due to Protection level]");
            
            
        }

        public void st()
        {
            PrivateMethod();
        }
    }
}
