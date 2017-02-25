using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeStudent
{
    class Parent
    {
        public string Name { get; set; }

        public Parent()
        {
            Program.OnSesionGone +=ProgramOnSesionGone;
        }

        private void ProgramOnSesionGone(object sender, Student student)
        {
            if (student.AveragePoints < 7)
                Console.WriteLine("Parent {0} Cry on student {1} !\n",Name, student.Name);
            if (student.AveragePoints >= 7 && student.AveragePoints <= 9)
                Console.WriteLine("Parent {0} Praire student {1} !\n", Name, student.Name);
            if (student.AveragePoints > 10)
                Console.WriteLine("Parent {0} Take money to student {1} !\n", Name, student.Name);

            Program.OnSesionGone -= ProgramOnSesionGone;
        }
    }
}
