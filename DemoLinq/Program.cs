using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //EtudiantNote(17);
            EtudiantEntrevalle(14, 18);
            //GetInfo(2);
            //EtudiantGroupBy();

            Console.ReadKey();

        }







        static List<Etudiant> getList()
        {
            var list = new List<Etudiant>()
            {
                new Etudiant() { id = 1, nom = "Omar", note = 18 , ville = "Meknes"},
                new Etudiant() { id = 2, nom = "Soufian", note = 16, ville ="Casa" },
                new Etudiant() { id = 3, nom = "KHALID", note = 17 , ville =  "Rabat"},
                new Etudiant() { id = 4, nom = "Ibtissam", note = 14 , ville = "Mohmadia"},
                new Etudiant() { id = 5, nom = "Said", note = 11 , ville = "Berrchid" },
                new Etudiant() { id = 6, nom = "Amal", note = 17 , ville = "Rabat"},
                new Etudiant() { id = 7, nom = "Ahmed", note = 9 , ville = "Casa"},
            };
            return list;
        }



        static void EtudiantNote(int note)
        {
            //Linq Query
            var l1 = from l in getList()
                     where l.note == note
                     select l;

            foreach (var item in l1)
            {
                Console.WriteLine(item.nom);
            }

            var linqMethode = getList().Where(a => a.note == note).ToList();
        }

        static void EtudiantNoteNom(int note)
        {
            //Linq Query
            var noms = from l in getList()
                     where l.note == note
                     select l.nom;

            foreach (var item in noms)
            {
                Console.WriteLine(item);
            }
        }


        static void EtudiantEntrevalle(int noteMin, int noteMax)
        {
            
            //Linq syntax Query 
            var l1 = from l in getList()
                     where l.note > noteMin && l.note <noteMax
                     select l;

            foreach (var item in l1)
            {
                Console.WriteLine(item.nom);
            }


        }


        static void EtudiantEntrevalleMethod(int noteMin, int noteMax)
        {
            //Linq method Query 
            var l1 = getList().Where(l => l.note > noteMin && l.note < noteMax).ToList<Etudiant>();
            foreach (var item in l1)
            {
                Console.WriteLine(item.nom);
            }


        }


        static void GetInfo(int id)
        {
            //Linq method Query 
            Etudiant l = getList().Where(a => a.id == id).FirstOrDefault();

            Console.WriteLine(l.id);
            Console.WriteLine(l.nom);
            Console.WriteLine(l.note);
            

        }

        static void EtudiantIntrevalleWhereClause(int noteMin, int noteMax)
        {
            //Linq syntax Query 
            var l1 = from l in getList()
                     where IsIntervalle(l)
                     select l;

            foreach (var item in l1)
            {
                Console.WriteLine(item.nom);
            }
        }

        static bool IsIntervalle(Etudiant a)
        {
            return a.note > 12 && a.note < 14;
        }

        static void EtudiantMultiWhere(int noteMin, int noteMax)
        {
            //Linq syntax Query 
            var l1 = from l in getList()
                     where l.note > 12
                     where l.note < 14
                     select l;

            foreach (var item in l1)
            {
                Console.WriteLine(item.nom);
            }

            //Linq Method Query 
            var lM = getList().Where(a => a.note > 12).Where(l => l.note < 14);

        }


        static void EtudiantTypeOf()
        {
            //Linq syntax Query 
            IList mixList = new ArrayList();

            mixList.Add(0);
            mixList.Add(null);
            mixList.Add("Said");
            mixList.Add(true);
            mixList.Add(12);
            mixList.Add("Maroc");
            mixList.Add(DateTime.Now);

            var listeInt = from l in mixList.OfType<string>()
                           select l;

            foreach (var item in listeInt)
            {
                Console.WriteLine(item);
            }

        }



        static void EtudiantOrderBy()
        {

            //Linq syntax Query 
            var l1 = from l in getList()
                     where IsIntervalle(l)
                     orderby l.note
                     orderby l.nom descending
                     select l;


            foreach (var item in l1)
            {
                Console.WriteLine("Etudiant :  {0} - note : {1}",item.nom, item.note);
            }
        }

        static void EtudiantGroupBy()
        {

            var l1 = from l in getList()
                     group l by l.ville;

            foreach (var item in l1)
            {
                Console.WriteLine("Etudiant de la ville : {0}", item.Key);
                foreach (Etudiant etudiant in item)
                {
                    Console.WriteLine("Nom : {0}", etudiant.nom);
                }
            }

        }


        static void EtudiantSelect()
        {

            //Linq syntax Query 
            var l1 = from l in getList()
                     where IsIntervalle(l)
                     select new { l.nom , l.id};


            foreach (var item in l1)
            {
                Console.WriteLine("Etudiant : {1} - note : {0}",item.id, item.nom);
            }

        }

    }
}
