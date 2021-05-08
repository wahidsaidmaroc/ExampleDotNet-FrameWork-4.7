using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary
{
    interface IAction
    {
        void Create();
        void Remove();
        void Update();
        void Detail(int id);
    }
}
