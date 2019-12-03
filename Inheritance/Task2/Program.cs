using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Model;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new Pupil(), new ExcelentPupil(), new BadPupil(), new GoodPupil());

            classRoom.PrintStudy();
            classRoom.PrintWrite();
            classRoom.PrintRead();
            classRoom.PrintRelax();

            Console.ReadKey();
        }
    }
}
