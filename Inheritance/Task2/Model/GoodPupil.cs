using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Model
{
    class GoodPupil : Pupil
    {
        public GoodPupil()
        {
            _name = "GoodPupil";
        }

        public override void Study()
        {
            Console.WriteLine("Good");
        }
        public override void Read()
        {
            Console.WriteLine("Good Read");
        }
        public override void Write()
        {
            Console.WriteLine("Good Write");
        }
        public override void Relex()
        {
            Console.WriteLine("Good Relax");
        }

    }
}
