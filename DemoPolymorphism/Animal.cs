using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    abstract class Animal
    {

        public abstract void animalSound();
        public abstract void typeAnimal();

        public void taille()
        {

            Console.WriteLine("Taille animale");
        }



        public virtual void speed()
        {
            
            Console.WriteLine("speed animal");
        }


    }
}
