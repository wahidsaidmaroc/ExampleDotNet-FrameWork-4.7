using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary.GestionClient
{
    public class MethodTypeClient
    {

        typeClient t = new typeClient();

        void myMethodAccess()
        {
            t.methodInternal(144);
        }

    }
}
