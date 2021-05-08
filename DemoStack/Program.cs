using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();
            stack.Push("Kaoutar");
            stack.Push("khalid");
            stack.Push("Ayoub");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Remove
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Count);

            stack.Contains("khalid");


            stack.Peek();

            Console.ReadKey();

        }
    }
}
