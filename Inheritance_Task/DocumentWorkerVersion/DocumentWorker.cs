using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkerVersion
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Doc open");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Edit doc available in pro version !");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Save doc avalible in pro version");
        }
    }
}
