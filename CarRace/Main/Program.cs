using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        public static event EventHandler OnStart;

        static void Main(string[] args)
        {
            SportCar sportCar = new SportCar("Porche 911");
            Jeep jeep = new Jeep("RangeRover 2");

            DoOnStart();

            Console.ReadKey();
        }

        private static void DoOnStart()
        {
            OnStart?.Invoke(null, EventArgs.Empty);
        }
    }
}
