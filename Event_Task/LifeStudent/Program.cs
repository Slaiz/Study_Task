using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeStudent
{
    class Program
    {
        public static event EventHandler<Student> OnSesionGone;
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            Parent[] parents = new Parent[5];
            string str;

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Type name student:");
                str = Console.ReadLine();
                students[i] = new Student();
                students[i].Sesion(str);
                Console.WriteLine("Type name parent:");
                str = Console.ReadLine();
                parents[i] = new Parent();
                parents[i].Name = str;
                DoOnSesionGone(students[i]);
            }

            Console.ReadKey();
        }

        private static void DoOnSesionGone(Student e)
        {
            OnSesionGone?.Invoke(null, e);
        }
    }
}
