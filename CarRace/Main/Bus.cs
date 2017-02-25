using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Bus:Car
    {
        public Bus(string name)
        {
            Name = name;
            MaxSpeed = 12;
        }
        public override void Drive()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
