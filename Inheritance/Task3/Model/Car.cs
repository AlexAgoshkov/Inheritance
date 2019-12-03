using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Model
{
    class Car : Vehicle
    {
        public Car(string name, int year, decimal price)
            : base(name, year, price)
        {

        }

        public override void Information()
        {
            Console.WriteLine($"Name of car - {_name}");
            Console.WriteLine($"Year of car manufacture - {_year}");
            Console.WriteLine($"Car price - {_price}");
        }
    }
}
