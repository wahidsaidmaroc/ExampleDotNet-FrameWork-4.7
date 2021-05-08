using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary.GestionClient
{
    public class typeClient : Client
    {

        public void testMethod(int idClient)
        {
            //methodPrive(21);
            methodProtect(221212);
        }


    }
}
