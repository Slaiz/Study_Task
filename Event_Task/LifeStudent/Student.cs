using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeStudent
{
    class Student
    {
        private int[] points;

        public string Name { get; set; }
        public int AveragePoints { get; set; }

        public Student()
        {
            points = new int[10];
        }

        public void Sesion(string str)
        {
            Name = str;

            Random r = new Random();
            int s = 0;

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = r.Next(1, 12);
                s += points[i];
            }

            AveragePoints = s / 10;

            Console.WriteLine("Student {0} gone sesion with {1} points\n", Name,AveragePoints);
        }
    }
}
