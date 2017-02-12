using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfTanks
{
    class Tank
    {
        private string name;
        private int damage;
        private int shild;
        private int speed;
        private int point = 0;

        public Tank(string name, int damage, int shild, int speed)
        {
            Name = name;
            Damage = damage;
            Shild = shild;
            Speed = speed;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                    name = value;
            }
        }
        public int Damage
        {
            get { return damage; }
            set
            {
                if (value > 0)
                    damage = value;
            }
        }
        public int Shild
        {
            get { return shild; }
            set
            {
                if (value > 0)
                    shild = value;
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 0)
                    speed = value;
            }
        }

        public static Tank operator *(Tank t1, Tank t2)
        {
            if (t1.Damage > t2.Damage)
                t1.point += 1;
            else t2.point += 1;

            if (t1.Shild > t2.Shild)
                t1.point += 1;
            else t2.point += 1;

            if (t1.Speed > t2.Speed)
                t1.point += 1;
            else t2.point += 1;

            if (t1.point > t2.point)
                return t1;
            else return t2;
        }

        public void Decription()
        {
            Console.WriteLine("Name: {0}\nDamage: {1}\nShild: {2}\nSpeed: {3}\n", Name, Damage, Shild, Speed);
        }

    }
}
