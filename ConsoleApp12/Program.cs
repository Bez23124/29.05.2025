using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> p1 = new Point<int>(3, 5);
            p1.Display();

            Point<uint> p2 = new Point<uint>(7, 9);
            p2.Display();

            Point<double> p3 = new Point<double>(3.5, 6.7);
            p3.Display();
            Console.ReadLine();
        }
    }
}
