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

            var client = new Action<string, bool>();
            client.GetT = "Said";
            client.GetV = 12;


            var intData = new Action<int, string>();
            intData.GetT = 12;

            //var four = new Action<int , fournisseur>();
            //four.GetT = new fournisseur { id = 1, fournisseur = "Nom Fournisseur" };


            #region "Method no Generique"
            var actionCRUD = new CRUD(); 

            var client1 = new Client() { ClientNom = "Said", id= 1 };
            actionCRUD.ajouterClient(client1);

            var fournisseur1 = new Fournisseur() { fournisseurNom = "Fournisseur Said", id = 1 };
            actionCRUD.ajouterFounrisseur(fournisseur1);
            #endregion

            actionCRUD.ajouterGenerique<Fournisseur>(fournisseur1);
            actionCRUD.ajouterGenerique<Client>(client1);

        }



        class Fournisseur
        {
            public int id { get; set; }
            public string fournisseurNom { get; set; }
        }

        class Client
        {
            public int id { get; set; }
            public string ClientNom { get; set; }
        }


        class CRUD
        {

            public void ajouterGenerique<T>(T obj)
            {
                

            }

            public void ajouterClient(Client obj)
            {


            }

            public void ajouterFounrisseur(Fournisseur obj)
            {
 

            }
        }
    }
}
