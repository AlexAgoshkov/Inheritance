using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Model
{
    class Plane : Vehicle
    {
        public Plane(string name, int year, decimal price, int capacity, int height)
            : base(name, year, price)
        {
            _capacityPeople = capacity;
            _height = height;
        } 
        public override void Information()
        {
            Console.WriteLine($"Name of Plane - {_name}");
            Console.WriteLine($"Year of Plane manufacture - {_year}");
            Console.WriteLine($"Plane price - {_price}");
            Console.WriteLine($"Capacity of People - {_capacityPeople}");
            Console.WriteLine($"Height - {_height}");
        }

        private int _capacityPeople;
        private int _height;
    }
}
