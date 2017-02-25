using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PingPong
{
    class Pong
    {
        public Pong()
        {
            Program.OnPingPong += ProgramOnOnPingPong;
        }

        private void ProgramOnOnPingPong(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("{0} received {1}",nameof(Pong),nameof(Ping));
            Thread.Sleep(1000);
        }
    }
}
