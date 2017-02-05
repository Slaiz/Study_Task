using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukraine
{
    class Kiev
    {
        private long peopleCount;

        public long PeopleCount
        {
            get
            {
                return peopleCount;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Error");
                else peopleCount = value;
            }
        }
        public Kiev()
        {

        }
        public Kiev(int peopleCount)
        {
            PeopleCount = peopleCount;
        }
    }
}
