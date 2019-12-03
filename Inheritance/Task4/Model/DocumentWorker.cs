using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Model
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document was opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("You can EDIT only in the PRO version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("You can SAVE only in the PRO version");
        }

    }
}
