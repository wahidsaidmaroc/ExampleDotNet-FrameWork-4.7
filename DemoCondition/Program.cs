using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (condition)
            //{ 
            //}
            //else if { }

            if (20 > 9)
            {
                Console.WriteLine("Vrai");
            }

            //Short Hand If else 
            //variable = (condition) ? Expression True : Expression false;
            //Par exemple :
            string result;
            int note = 16;
            if (note < 10)
                result = "Bad";
            else
                result = "Good";


            result = (note < 10) ? "bad" : "Good";


            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
