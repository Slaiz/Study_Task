using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    /// <summary>
    /// Create a class that describes the student and 
    /// provide him moments following items: name, surname, patronymic, the group, age, 
    /// an array (ragged) Programming estimates, administration and design (5 to 10). 
    /// Also add methods for working with enumerated danymi: the ability to install / receiving evaluation, 
    /// obtaining the average score on the instructions of the subject, obtaining the maximum and minimum estimate printout of student data.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Student st1 = new Student("Sviatoslav", "Komarnytskyi", "43 PZ", 18);

            do
            {
                Console.Clear();

                Console.WriteLine("Choose operation:\n1. Describe student\n2. Set rate\n3. Get Rate\n4. Print Middle Rate\n5. Find Min/Max");
                n = Int32.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        st1.DescriptionStudent();
                        break;
                    case 2:
                        st1.SetRate(ChooseSubject());
                        break;
                    case 3:
                        st1.GetRate(ChooseSubject());
                        break;
                    case 4:
                        st1.PrintMiddleRate(ChooseSubject());
                        break;
                    case 5:
                        st1.PrintMinMaxRate(ChooseSubject());
                        break;
                    default:
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.DownArrow);
        }
        static int ChooseSubject()
        {
            int n;

            Console.WriteLine("Choose subject:\n1. Programming\n2. Math\n3. Graphics\n");
            n = Int32.Parse(Console.ReadLine());

            return n;
        }
    }
}