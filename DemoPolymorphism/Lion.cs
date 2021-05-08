using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Lion : Animal
    {
        public override void animalSound()
        {
            
        }

        public override void speed()
        {
            Console.WriteLine("speed lion");
            base.speed();
        }


    }
}
