using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Model
{
    class BadPupil : Pupil
    {
        public BadPupil()
        {
            _name = "BadPupil";
        }

        public override void Study()
        {
            Console.WriteLine("Very bad");
        }

        public override void Write()
        {
            Console.WriteLine("Very bad Write");
        }

        public override void Read()
        {
            Console.WriteLine("Very bad Read");
        }

        public override void Relex()
        {
            Console.WriteLine("Always Relax");
        }
    }
}
