using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Object[] mesAnimaux = { new Chien(), new Chat() };

            foreach (Object AnimalCourant in mesAnimaux)
            {
                Chien monChien = AnimalCourant as Chien;
                Chat monchat = AnimalCourant as Chat;

                if (monChien != null)
                    Console.WriteLine("Voici le cri du chien : {0}", monChien.Cri());
                else if (monchat != null)
                    Console.WriteLine("Voici le cri du chat : {0}", monchat.Cri());
                else
                    Console.WriteLine("Animal inconnu !");
            }

        }
    }

    abstract public class Animal
    {
        abstract public string Cri();
    }


    public class Chien : Animal
    {
        public override string Cri()
        {
            return "Waf !!!";
        }
    }
    public class Chat : Animal
    {
        public override string Cri()
        {
            return "Miaouuu !!!";
        }
    }

}
