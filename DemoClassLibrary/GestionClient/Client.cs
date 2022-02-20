using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DemoClassLibrary.GestionClient
{
    /// <summary>
    /// Classe de type client 
    /// Version 1.0 Projet commercial
    /// </summary>
    public class Client : IAction, IDisposable
    {

        #region "Param"


        public int idClient { get; set; }
        public string nomClient { get; set; }
        public string adresse { get; set; }
        public DateTime dateCreation { get; set; }
        public decimal solde { get; set; }
        public bool etat { get; set; }

        #endregion

        #region "CRUD"

        /// <summary>
        /// Methode pour créer un nouveau objet client
        /// </summary>
        public void Create()
        {
            Console.WriteLine("Creation Client");
        }

        public void Remove()
        {
            Console.WriteLine("Supperission Client");
        }

        public void Update()
        {
            Console.WriteLine("Modification Client");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idClient"></param>
        public void Detail(int idClient)
        {
            Console.WriteLine("Consultation id Client {0}", idClient);
            methodPrive(21);
            methodProtect(4545);
        }

        #endregion

        #region "Autre Methode"

        private void methodPrive(int idClient)
        {
            Console.WriteLine("Consultation id Client {0}", idClient);
        }


        protected void methodProtect(int idClient)
        {
            Console.WriteLine("Consultation id Client {0}", idClient);
        }


        internal void methodInternal(int idClient)
        {
            Console.WriteLine("Consultation id Client {0}", idClient);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
