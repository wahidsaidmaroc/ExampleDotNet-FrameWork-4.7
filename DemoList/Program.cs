using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoList
{
    class Program
    {
        static void Main(string[] args)
        {


            #region "Collection liste Simple"

            #region "Exemple List"

            List<int> listeInt = new List<int>()
            {12, 11,14};

            listeInt.Add(1);
            listeInt.Add(3);
            listeInt.Insert(0, 4);

            listeInt.Clear();

            List<string> vs = new List<string>()
            { "Said", "Omar", DateTime.Now.ToString()};
            vs.Add("Kaoutar");
            vs.Add(null);

            foreach (string item in vs)
            {
                Console.WriteLine(item);
            }

            #endregion

            //Ajouter arrayList.
            string[] etudiantM = new string[3] { "Sofian", "Amal", "Ayoub" };
            vs.AddRange(etudiantM);
            vs.Insert(4, "Khalid");


            //Ajouter Liste
            var etudiantL = new List<string>() 
            { "Gillbert", "Ibetissam" };
            vs.AddRange(etudiantL);

       


            //Using simple foreach
            foreach (string item in vs.OrderBy(a =>a))
            {
                Console.WriteLine(item);
            }

            //Using foreach Linq Method
            vs.ForEach(e => Console.WriteLine(e));

            #endregion



            var listeEtudiant = new List<Etudiant>()
            {
                new Etudiant(){id= 1, prenom = "Omar", note = 18},
                new Etudiant(){id= 2, prenom = "AMAL", note = 16},
                new Etudiant(){id= 3, prenom = "KHALID", note = 17},
                new Etudiant(){id= 4, prenom = "Ibtissam", note = 14},
                new Etudiant(){id= 5, prenom = "Said", note = 11},

            };
            //Update by index
            listeEtudiant[0].note = 12;

            //Update by object
            var e2 = new Etudiant();
            e2.id = 1;
            listeEtudiant.Contains(e2);
            

            //Update by linq
            var etudiantForUpdate = listeEtudiant.Where(a=> a.prenom == "Said").FirstOrDefault();    


            var e1 = new Etudiant();
            e1.id = 6;
            e1.prenom = "Saad";
            e1.note = 15;

            listeEtudiant.Add(e1);
            //e1.prenom = 
            

            //Order by name
            Console.WriteLine("------------------ Order by name :");
            foreach (var item in listeEtudiant.OrderBy(a => a.nom))
            {
                Console.WriteLine(item.prenom);
            }


            //Order by point
            Console.WriteLine("------------------ Les notes :");
            foreach (var item in listeEtudiant.OrderByDescending(a => a.note))
            {
                Console.WriteLine(item.note +  item.prenom);
            }




            Console.ReadKey();

        }
    }
}
