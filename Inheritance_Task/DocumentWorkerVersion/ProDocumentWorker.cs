using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorkerVersion
{
    class ProDocumentWorker:DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Doc edit");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Doc save in old formant. New format available in expert version");
        }
    }
}
