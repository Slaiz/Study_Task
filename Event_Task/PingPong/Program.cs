using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PingPong
{
    class Program
    {
        public static event EventHandler OnPingPong;
        static void Main(string[] args)
        {
            Pong pong = new Pong();
            Ping ping = new Ping();

            do
            {
                DoOnPingPong();
            } while (true);
        }


        private static void DoOnPingPong()
        {
            OnPingPong?.Invoke(null, EventArgs.Empty);
        }
    }
}
