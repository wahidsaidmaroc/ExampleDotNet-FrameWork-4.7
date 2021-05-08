using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary.GestionProduit
{
    public sealed class Produit
    {
        

        public Produit(){}
        public Produit(string code) { }
        public Produit(string code,decimal prixCons )
        {
            this.code = code;
            prix = prixCons;
        }

        //Champ
        string codeProduit;


        //Properties.
        public int idProduit { get; set; }
        public string  code { get; set; }
        public decimal prix { get; set; }

        private int _stock; //Field
        public int stock  //Property
        {
            get { return _stock; } //Get method
            set { _stock = value; } // Set Method
        }






    }




}
