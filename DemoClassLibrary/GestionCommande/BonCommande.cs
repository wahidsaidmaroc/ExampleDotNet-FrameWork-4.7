using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary.GestionCommande
{
    public class BonCommande
    {
        public int idBC { get; set; }
        public int nBC { get; set; }
        public GestionClient.Client client { get; set; }
    }
}
