using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Model
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil()
        {
            _name = "ExcelentPupil";
        }

        public override void Study()
        {
            Console.WriteLine("Very good");
        }

        public override void Write()
        {
            Console.WriteLine("Very good Write");
        }

        public override void Read()
        {
            Console.WriteLine("Very good Read");
        }

        public override void Relex()
        {
            Console.WriteLine("He doesn't have time for relax");
        }

    }
}
