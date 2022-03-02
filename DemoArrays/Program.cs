using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrays
{
    class Program
    {
        static void Main(string[] args)
        {


            

          
            
            string[] voiture = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(voiture[0]);




            string[] marque = new string[10];



            Console.WriteLine(voiture[1]);
            voiture[1] = "Opel";

            Console.WriteLine(voiture[2]);
            Console.WriteLine(voiture.Length);


            //Pour afficher les donnée d'array

            foreach (var item in voiture)
            {
                Console.WriteLine(item);
            }


            Array.Sort(voiture);
            Console.WriteLine("------- Sort :");
            foreach (var item in voiture)
            {
                Console.WriteLine(item);
            }




            Console.WriteLine("Array int");

            int[] vs = { 10,20,30,40,50,20};
            //Linq

            Console.WriteLine("Max : " + vs.Max());
            Console.WriteLine("Min : " + vs.Min());
            

            Console.ReadKey();


        }
    }
}
