using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace DemoArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            IList listArrayList = new ArrayList();
            ICollection collectionArraList = new ArrayList();
            ArrayList arrayList = new ArrayList();
            //or
            var list = new ArrayList();


            list.Add(12);
            list.Add("Said");
            list.Add(true);
            list.Add(null);
            list.Add(null);

            
            //Or 
            var listIni = new ArrayList() 
            { 3, "Maroc", true, null, 
                "Message d'erreur",DateTime.Now };
            listIni.Add(12);


            //Accessing Element of ArrayList

            int idListe = (int)listIni[0]; //Return un variable de type Objet.
            string nomListe = (string)listIni[1];

            //Using var without Explicit Casting
            var obj = listIni[1];


            //insert Element in ArrayList
            ArrayList arlist = new ArrayList()
            {
            "Mohamed", 300, 87, true
            };

            arlist.Insert(0, "2eme Element");
            arlist.Insert(0, "3eme Element");
            arlist.Insert(0, "4eme Element");


            foreach (var item in arlist)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();

        }
    }
}
