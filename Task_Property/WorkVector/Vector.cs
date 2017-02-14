using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkVector
{
    class Vector
    {
        private int[] mass;
        private int count;
        private int capacity = 5;

        public Vector()
        {

        }
        public Vector(int[] mass, int count, int capacity)
        {
            Count = count;
            Capacity = capacity;

            this.mass = new int[Capacity];
            for (int i = 0; i < count; i++)
            {
                this.mass[i] = mass[i];
            }
        }

        private void CountElement()
        {

        }

        public int Count
        {
            get { return count; }
            set
            {
                if (value > 0)
                    count = value;
            }
        }
        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value > 0)
                    capacity = value;
            }
        }

        public void PushBack(int n)
        { 
            mass[count] = n;

            count += 1;
        }

        public void PopBack()
        {
            mass[count] = 0;

            count -= 1;
        }

        public void Insert(int n, int m)
        {
            m--;

            int[] b = new int[count - m];

            for (int i = 0; i < count - m; i++)
            {
                b[i] = mass[m + i];
            }

            mass[m] = n;

            m++;
            count++;

            for (int i = 0; i < count - m; i++)
            {
                mass[m + i] = b[i];
            }

        }

        public void Erase(int m)
        {
            m--;

            int[] b = new int[count - m];

            for (int i = 1; i < count - m; i++)
            {
                b[i] = mass[m + i];
            }

            mass[m] = 0;

            count--;

            for (int i = 0; i < count - m; i++)
            {
                mass[m + i] = b[i+1];
            }
        }

        public void Empty()
        {

        }

        public int At(int n)
        {
            for (int i = 0; i < count; i++)
            {
                if (mass[i] == n)
                    return i;
            }

            return -1;
        }

        public void Reverse()
        {
            int[] b = new int[count];

            for (int i = 0; i < count; i++)
            {
                b[i] = mass[i];
            }

            for (int i = count ; i > 0; i--)
            {
                mass[i-1] = b[count - i];
            }
        }

        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                mass[i] = 0;
            }

            count = 0;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(" {0}", mass[i]);
            }
        }
    
    }
}
