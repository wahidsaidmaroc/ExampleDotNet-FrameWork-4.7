using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Chat : Animal
    {

        public override void speed()
        {
            Console.WriteLine("1 speed chat");
            base.speed();
            Console.WriteLine("2 speed chat");
        }

        //public override void animalSound()
        //{
        //    Console.WriteLine("MAW MAW");
        //}

        //public override void typeAnimal()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
