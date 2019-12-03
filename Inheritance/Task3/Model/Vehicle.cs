using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Model
{
    abstract class Vehicle
    {
        public Vehicle(string name, int year, decimal price)
        {
            _name = name;
            _year = year;
            _price = price;
        }

        public abstract void Information();
        
        public decimal _price { get; protected set; }

        public int _year { get; protected set; }

        public string _name { get; protected set; }
    }
}
