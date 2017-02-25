using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Truck:Car
    {
        public Truck(string name)
        {
            Name = name;
            MaxSpeed = 18;
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
