using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class PrinterContext
    {
        public PrinterContext()
        {
            printers = new List<IPrinter>();
            printers.AddRange(
                new Printer[] 
                {
                    new PrinterRed(),
                    new PrinterBlue(),
                    new PrinterCyan(),
                    new PrinterYellow()
                });
        }
       public List<IPrinter> printers { get; }
        
    }

    class Printer : IPrinter
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class PrinterRed : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
        }
    }

    class PrinterBlue : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
        }
    }

    class PrinterCyan : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(value);
        }
    }

    class PrinterYellow : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
        }
    }

}
