using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSortedList
{
    class Program
    {
        static void Main(string[] args)
        {

            #region "Exemple simple"


            SortedList personne = new SortedList();
            personne.Add(1, "Omar");
            personne.Add(2, "Sofian");
            personne.Add(3, "Amal");
            personne.Add(4, null);
 

            foreach (DictionaryEntry item in personne)
            {
                Console.WriteLine("Clé : {0} , Valeur : {1}", item.Key, item.Value);
            }


            #endregion


            //Exemple pour Lire et modifier un element

            SortedList pays = new SortedList()
            {
                {1, "MAroc" },
                {2, "France" },
                {3, "Esp." },
                {4, "Japon" },
            };

            Console.WriteLine(pays[3]);

            pays[3] = "USA";

            Console.WriteLine(pays[3]);


            //Remove Element by our key
            pays.Remove(3);
            //Remove Element by key
            pays.RemoveAt(0);
            


            Console.ReadKey();


        }
    }
}
