using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Model
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document was edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document was saved in the old format, If you want to save in NEW format, you need Expert version");
        }

    }
}
