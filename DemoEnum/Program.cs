using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEnum
{

  
    class Program
    {
        static void Main(string[] args)
        {
            //Simple  use.
            niveau ob = niveau.Low;

            //use with Class:
            var s = new studant();
            s.level = niveau.Medium;
            s.months = mois.March;


            //if
            if (s.level == niveau.Low)
            {
                Console.WriteLine("Low");
            }

            //Switch
            switch(s.level)
            {
                case niveau.High:
                    Console.WriteLine("High");
                    break;
                case niveau.Low:
                    Console.WriteLine("Low");
                    break;


            }


        }
    }



    class studant
    {
        public niveau level { get; set; }
        public mois months { get; set; }
    }
}
