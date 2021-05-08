using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInt
{
    class Program
    {
        static void Main(string[] args)
        {

            int myNum;
            myNum = 15;
            Console.WriteLine(myNum);

            const int taxe = 20;
            // taxe = 25; //error

            int a = 5, b = 9, c = 12;
            Console.WriteLine(a + b);  // 14
            Console.WriteLine(a + b + c);  // 26
            Console.WriteLine(a.ToString() + b); 

            Console.ReadKey();

        }
    }
}
