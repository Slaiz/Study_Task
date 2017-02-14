using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookShop
{
    class Notebook
    {
        private string vendor;
        private int price;

        public Notebook()
        {

        }

        public Notebook(string vendor, int price)
        {
            Vendor = vendor;
            Price = price;
        }

        public string Vendor { get { return vendor; } set { vendor = value; } }

        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }
    }
}
