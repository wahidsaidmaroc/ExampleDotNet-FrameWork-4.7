﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            //EtudiantNote(9);
            //EtudiantEntrevalle(8, 12);
            //GetInfo(2);
            //EtudiantTypeOf();
            //EtudiantGroupBy();
            EtudiantGroupBy();
            //groupByJointure();
            Console.ReadLine();

        }







        static List<Etudiant> getList()
        {
            var list = new List<Etudiant>()
            {
                new Etudiant() { id = 1, nom = "Haroun", note = 18 , ville = "Meknes", _idGroup = 1},
                new Etudiant() { id = 2, nom = "Abdelahe", note = 20, ville ="Casa" , _idGroup = 2},
                new Etudiant() { id = 3, nom = "Kaoutar", note = 17 , ville =  "Rabat", _idGroup = 3},
                new Etudiant() { id = 4, nom = "Hamza", note = 14 , ville = "Mohmadia", _idGroup = 2},
                new Etudiant() { id = 5, nom = "Said", note = 10 , ville = "Berrchid", _idGroup = 3 },
                new Etudiant() { id = 6, nom = "Amine", note = 17 , ville = "Rabat", _idGroup = 1},
                new Etudiant() { id = 7, nom = "Ahmed", note = 9 , ville = "Casa", _idGroup = 4},
                new Etudiant() { id = 8, nom = "Mohamed", note = 20, ville ="Rabat" , _idGroup = 1},
                new Etudiant() { id = 9, nom = "Youssef", note = 20, ville ="Rabat" , _idGroup = 1},
                new Etudiant() { id = 10, nom = "Hasnaoui", note = 19, ville ="Rabat" , _idGroup = 1},
                new Etudiant() { id = 11, nom = "Abdelatif", note = 14, ville ="Rabat" , _idGroup = 2},
                new Etudiant() { id = 12, nom = "Abdelghni", note = 10, ville ="Casablanca" , _idGroup = 2},
                new Etudiant() { id = 13, nom = "Ihssan", note = 13, ville ="Rabat" , _idGroup = 2},
                new Etudiant() { id = 14, nom = "Nada", note = 17, ville ="Rabat" , _idGroup = 2},
                new Etudiant() { id = 15, nom = "Khadija", note = 17, ville ="Rabat" , _idGroup = 2},
                new Etudiant() { id = 16, nom = "Ayoub", note = 17, ville ="Casablanca" , _idGroup = 3},
                new Etudiant() { id = 17, nom = "Rachid", note = 18, ville ="Rabat" , _idGroup = 4},
                new Etudiant() { id = 18, nom = "Adam", note = 13, ville ="Berrchid" , _idGroup = 4},
                new Etudiant() { id = 19, nom = "Zouhair", note = 10, ville ="Tanger" , _idGroup = 4},
                new Etudiant() { id = 20, nom = "Mustapha", note = 9, ville ="Fes" , _idGroup = 3},
            };
            return list;
        }

        static List<GroupEtudiant> getGroup()
        {
            var list = new List<GroupEtudiant>()
            {
                new GroupEtudiant() { id = 1, groupe = "LICDA"},
                new GroupEtudiant() { id = 2, groupe = "MIAGE" },
                new GroupEtudiant() { id = 3, groupe = "Big Data"},
                new GroupEtudiant() { id = 4, groupe = "ISRI"}
            };
            return list;
        }


        static void EtudiantNote(int note)
        {
            //Linq Query
            //var resulte = from l in getList()
            //         where l.note == note 
            //         select l;

            //foreach (var item in resulte)
            //{
            //    Console.WriteLine(item.nom + " - " +item.ville);
            //}

            var linqMethode = getList().Where(a => a.note == note).ToList();
            foreach (var item in linqMethode)
            {
                Console.WriteLine(item.nom);
            }
        }

        static void EtudiantNoteNom(int note)
        {
            //Linq Query
            var noms = from l in getList()
                     where l.note == note
                     orderby l.note descending
                     select l.nom;

            foreach (var item in noms)
            {
                Console.WriteLine(item);
            }

            //by methode
            var linqMethode = getList().Where(a => a.note == note).Select(a => a.nom).ToList();
        }

        static void EtudiantEntrevalle(int noteMin, int noteMax)
        {

            //Linq syntax Query 
            var l1 = from l in getList()
                     where l.note > noteMin && l.note < noteMax 
                     select new { l.nom,message = "Tres faible" };

            foreach (var item in l1)
            {
                Console.WriteLine(item.nom  + "Messsage Prof. " + item.message);
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


        static void groupByJointure()
        {
            var list = from g in getGroup()
                        join e in getList()
                        
                       on g.id equals e._idGroup
                       select new { nomPersonne = e.nom, gr = g.groupe };

            foreach (var item in list)
            {
                Console.WriteLine("Nom : {0}        - Group {1} ", item.nomPersonne, item.gr);
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
  

            var listeInt = (from l in mixList.OfType<string>()
                           select l).ToList();

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
                     orderby l.note descending
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
