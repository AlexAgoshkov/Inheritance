using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Model
{
    class Pupil
    {
        public Pupil()
        {
            _name = "Pupil";
        }

        public virtual void Study()
        {
            Console.WriteLine("Not bad");
        }

        public virtual void Read()
        {
            Console.WriteLine("Not bad read");
        }

        public virtual void Write()
        {
            Console.WriteLine("Not bad Write");
        }

        public virtual void Relex()
        {
            Console.WriteLine("Not bad Relax");
        }

       public string _name { get; protected set; }
    }
}
