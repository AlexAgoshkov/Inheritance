using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Model
{
    class Ship : Vehicle
    {
        public Ship(string name, int year, decimal price, int capacity, string port)
            : base(name, year, price)
        {
            _capacityPeople = capacity;
            _port = port;
        }
      
        public override void Information()
        {
            Console.WriteLine($"Name of Ship - {_name}");
            Console.WriteLine($"Year of Ship manufacture - {_year}");
            Console.WriteLine($"Ship price - {_price}");
            Console.WriteLine($"Capacity of People - {_capacityPeople}");
            Console.WriteLine($"Name of Port - {_port}");
        }

        private string _port;
        private int _capacityPeople;
    }
}
