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

            var stack = new Stack();
            stack.Push("1 Kaoutar");
            stack.Push("2 khalid");
            stack.Push("3 Ayoub");
            stack.Push("4 Adam");
            stack.Push("5 Zouhair");

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
