using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class View
    {
        public View()
        {
            _context = new PrinterContext();
        }

        public void Print()
        {
            foreach (var item in _context.printers)
            {
                item.Print("Allo");
            }
        }


       private PrinterContext _context;
    }
}
