using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStruct
{
    struct Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


     

    }

    class Program
    {
        static void Main(string[] args)
        {
            var c = new Coordinate();
            c.x = 10;
            c.y = 20;
            Console.WriteLine(c.x);
            Console.WriteLine(c.y);
            Console.ReadKey();

        }
    }
}
