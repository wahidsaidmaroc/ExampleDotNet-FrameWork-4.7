using System;
using System.Collections;


namespace DemoQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            var q = new Queue();
            q.Enqueue("Je suis le 1");
            q.Enqueue("Je suis le 2eme");
            q.Enqueue("Je Suis le 3 eme");
            q.Enqueue(null);

            Console.WriteLine("Tapez votre classement :");

            q.Enqueue(Console.ReadLine()); 



            foreach (var item in q)
            {
                Console.WriteLine(item);
            }


            q.Dequeue();
            q.Dequeue();

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();

        }
    }
}
