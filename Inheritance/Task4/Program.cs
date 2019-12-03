using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Model;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Product Key");
            string key = Console.ReadLine();
            DocumentWorker document;

            switch (key)
            {
                case "pro":
                    document = new ProDocumentWorker();
                    break;
                case "exp":
                    document = new ExpertDocumentWorker();
                    break;
                default:
                    document = new DocumentWorker();
                    break;
            }

            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
            
            Console.ReadKey();
        }
    }
}
