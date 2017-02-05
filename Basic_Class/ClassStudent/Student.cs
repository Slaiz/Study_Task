using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class Student
    {
        private int age;
        Random rand = new Random();

        public int[][] rating = new int[3][] { new int[5], new int[5], new int[5] };

        public Student(string name, string surname, string group, int age)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value <= 80)
                    age = value;
                else Console.WriteLine("Error");
            }
        }

        public void SetRate(int n)
        {
            switch (n)
            {
                case 1:
                    FillArray(0);
                    break;
                case 2:
                    FillArray(1);
                    break;
                case 3:
                    FillArray(2);
                    break;
                default:
                    break;
            }
        }

        private void FillArray(int k)
        {
            for (int i = 0; i < 5; i++)
            {
                rating[k][i] = rand.Next(1, 5);
            }

            Console.WriteLine("Array are fill !");
        }

        public void GetRate(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Rate of Programming");
                    PrintArray(0);
                    break;
                case 2:
                    Console.WriteLine("Rate of Math");
                    PrintArray(1);
                    break;
                case 3:
                    Console.WriteLine("Rate of Grapgics");
                    PrintArray(2);
                    break;
                default:
                    break;
            }
        }

        private void PrintArray(int k)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", rating[k][i]);
            }
        }

        public void PrintMiddleRate(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Middle Rate of Programming");
                    FindMiddleRate(0);
                    break;
                case 2:
                    Console.WriteLine("Middle Rate of Math");
                    FindMiddleRate(1);
                    break;
                case 3:
                    Console.WriteLine("Middle Rate of Grapgics");
                    FindMiddleRate(2);
                    break;
                default:
                    break;
            }
        }

        private void FindMiddleRate(int k)
        {
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += rating[k][i];
            }

            Console.WriteLine("{0}", sum / rating[k].Length);
        }

        public void PrintMinMaxRate(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Min/Max Rate of Programming");
                    FindMinMaxRate(0);
                    break;
                case 2:
                    Console.WriteLine("Min/Max Rate of Math");
                    FindMinMaxRate(1);
                    break;
                case 3:
                    Console.WriteLine("Min/Max Rate of Grapgics");
                    FindMinMaxRate(2);
                    break;
                default:
                    break;
            }
        }

        public void FindMinMaxRate(int k)
        {
            int min = 5, max = 0;

            for (int i = 0; i < 5; i++)
            {
                if (max < rating[k][i])
                    max = rating[k][i];

                if (min > rating[k][i])
                    min = rating[k][i];
            }

            Console.WriteLine("Min: {0}\nMax: {1}", min, max);
        }

        public void DescriptionStudent()
        {
            Console.WriteLine("Name: {0}\nSurname: {1}\nGroup: {2}\nAge: {3}\n", Name, Surname, Group, Age.ToString());

        }

    }
}
