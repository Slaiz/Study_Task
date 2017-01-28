using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerClub
{
    class Computer
    {
        public string Model { get; set; }

        public int Ram { get; set; }

        public bool Enabled { get; private set; }

        public bool Mainframe { get; set; }

        public Computer(string Model, bool Mainframe)
        {
            this.Model = Model;
            this.Mainframe = Mainframe;
            Enabled = true;
        }

        public void On(bool command)
        {
            if (!Mainframe)
            {
                if (Enabled)
                {
                    Print(Model + " start work ");
                    Enabled = true;
                }
                else Print(Model + "is on");
            }
        }

        public void Off()
        {
            if (!Mainframe)
            {
                if (Enabled)
                {
                    Print(Model + " end work ");
                    Enabled = false;
                }
                else Print(Model + " is off ");
            }
        }

        public void Reboot()
        {
            if (!Mainframe) {
                if (Enabled)
                    Print(Model + " reboot ");
                else Print(Model + " is disenable ");
            }
        }

        private void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
