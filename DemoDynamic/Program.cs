using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic valeur1 = 12;
            Console.WriteLine(valeur1.GetType());

            valeur1 = "Said";
            Console.WriteLine(valeur1.GetType());

            valeur1 = DateTime.Now;
            Console.WriteLine(valeur1.GetType());



            //dynamic type conversion
            dynamic d1 = 9;
            int n = d1;

            d1 = "said";
            string s1 = d1;



            Console.ReadKey();

        }
    }
}
