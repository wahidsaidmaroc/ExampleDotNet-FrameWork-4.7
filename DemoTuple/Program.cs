using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Declaration 
            Tuple<int, string, string> message = new Tuple<int, string, string>(1, "Said", "wahid");
            Console.WriteLine(message.Item1);

            //
            var numbers = Tuple.Create(12,185, 2 ,3);
            var a = numbers.Item1;

            var variableTuple = Tuple.Create("Un", 2, 3, "Quatre");
            var etat = ajouterElement(true);
            if (etat.Item1)
            {
                Console.WriteLine("Save element is numbre {}", etat.Item3);
            }
            if (!etat.Item1)
            {
                Console.WriteLine("Erreur : {}", etat.Item2);
            }
        }


        static Tuple<bool, string, int> ajouterElement(bool etat)
        {
            if (etat)
            {
                return Tuple.Create(true, "", 1);
            }
            else
            {
                return Tuple.Create(false, "Message d'erreur", 0);
            }
        }
    }
}
