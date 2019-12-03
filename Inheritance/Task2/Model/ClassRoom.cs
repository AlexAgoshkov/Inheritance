using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Model
{
    class ClassRoom
    {
        public ClassRoom(params Pupil[] pupils)
        {
            _pupils = pupils;
        }

        public void PrintStudy()
        {
            foreach (var item in _pupils)
            {
                Console.Write($"{item._name} - ");
                item.Study();
                
            }
        }

        public void PrintWrite()
        {
            foreach (var item in _pupils)
            {
                Console.Write($"{item._name} - ");
                item.Write();

            }
        }
        public void PrintRead()
        {
            foreach (var item in _pupils)
            {
                Console.Write($"{item._name} - ");
                item.Read();
            }
        }
        public void PrintRelax()
        {
            foreach (var item in _pupils)
            {
                Console.Write($"{item._name} - ");
                item.Relex();
            }
        }

        private Pupil[] _pupils;
    }
}
