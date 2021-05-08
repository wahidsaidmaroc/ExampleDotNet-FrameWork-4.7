using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVar
{
    class Program
    {
        static void Main(string[] args)
        {

            var i = 10;
            Console.WriteLine(i.GetType());

            var s = "Said WAHID";
            Console.WriteLine(s.GetType());
            

            var listeVar = new[] { 12, 54, 54, 48, 4, 8, 9, 4 };

            foreach (var item in listeVar)
            {
                Console.WriteLine("Valeur {0} de type {1}" , item , item.GetType()) ;
            }


            //L'utilisation : 
            var listInt = new List<int>();
            



            Console.ReadKey();

        }
    }
}
