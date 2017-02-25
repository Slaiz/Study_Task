using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PingPong
{
    class Ping
    {
        public Ping()
        {
            Program.OnPingPong += ProgramOnOnPingPong;
        }

        private void ProgramOnOnPingPong(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("{0} received {1}", nameof(Ping), nameof(Pong));
            Thread.Sleep(1000);
        }
    }
}
