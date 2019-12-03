using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Model;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Volga", 1771, 50);

            Plane plane = new Plane("B", 1991, 130.150m, 100, 50);

            Ship ship = new Ship("Black Diamond", 2004, 120, 40, "California");

            car.Information();
            plane.Information();
            ship.Information();


            Console.ReadKey();
        }
    }
}
