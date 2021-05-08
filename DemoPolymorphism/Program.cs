using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal a = new Chat();
            a.speed();
            a.animalSound();

            Chat c = new Chat();
            c.speed();

            Lion l = new Lion();
            l.speed();

            Console.ReadKey();

        }
    }
}
