using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookShop
{
    class Shop
    {
        private Notebook[] nt;

        public Shop(Notebook[] nt)
        {
            this.nt = nt;
        }

        public Notebook this[int i]
        {
            get { return nt[i]; }
        }

        public Notebook this[string str]
        {
            get
            {
                for (int i = 0; i < nt.Length; i++)
                {
                    if (nt[i].Vendor == str)
                        return nt[i];
                }
                return null;
            }
        }
    }
}
