using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoClassLibrary.GestionCommande;
using DemoClassLibrary.GestionClient;
using DemoClassLibrary.GestionProduit;

namespace DemoClass
{
    class Program
    {
        static void Main(string[] args)
        {

            



            // Without Construrtor
            
            var client = new Client();
            client.idClient = 1;
            client.dateCreation = DateTime.Now;
            

            var bc = new BonCommande { idBC = 1, nBC = 0001, client = client };
            //bc.client.Details(6);

            client.Create();
            //client.Details(1);


            //With Constructor
            var p = new Produit("2154", 125);
            Console.WriteLine(p.code);


            //With out  constructor,
            var produit = new Produit();
            produit.code = "5454";
            Console.WriteLine(p.code);



            //test access Method

            var tc = new typeClient();
            


            //Bloque la console ;
            Console.ReadKey();


        }
    }
}
