using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneric
{
    class Action<T, V>
    {
        public T GetT { get; set; }
        public V GetV { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {

            var client = new Action<string, string>();
            client.GetT = "Said";


            var intData = new Action<int, string>();
            intData.GetT = 12;

            //var four = new Action<int , fournisseur>();
            //four.GetT = new fournisseur { id = 1, fournisseur = "Nom Fournisseur" };

        }



        class fournisseur
        {
            public int id { get; set; }
            public string fournisseurNom { get; set; }
        }
    }
}
