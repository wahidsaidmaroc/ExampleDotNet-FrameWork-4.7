using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DemoIs
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region "Exemple Client"
            var client = new Client();
            if (client is null)
            {
                Console.Write("Client is nul");
            }
            else
                Console.WriteLine("Nom Client : " + client.nom);

            Client client1 = null;

            if (client1 is null)
            {
                Console.Write("Client is nul");
            }
            #endregion



            object[] mesObjets = { 1, "Salut", 13.7F , DateTime.Now};

            foreach (object obj in mesObjets)
            {
                if (obj is int)
                    Console.WriteLine("int");
                if (obj is string)
                    Console.WriteLine("string");
                if (obj is DateTime)
                {
                    Console.WriteLine("Date Time");
                    Console.WriteLine(obj.GetType());
                }

            }




            Console.ReadKey();
        }

    }
}
