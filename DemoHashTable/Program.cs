using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            #region "Exemple 1"

            Hashtable hashtable = new Hashtable();

            hashtable.Add(0, "Said");
            hashtable.Add(1, "wahid");


            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine("Clé : {0} , Valeur : {1}", item.Key, item.Value);
            }

            #endregion


            #region "Exemple 2"

            Hashtable ht = new Hashtable();
 
            ht.Add("0", "Client 1");
            ht.Add("1", "Client 2");
            ht.Add("2", "Client 3");

            ICollection cleHT = ht.Keys;

            foreach (string k in cleHT)
            {
                Console.WriteLine(ht[k]);
            }


            Console.WriteLine(ht.ContainsKey("0"));
            Console.WriteLine(ht.ContainsValue("Client 1"));

            #endregion

            Console.ReadKey();

        }
    }
}
