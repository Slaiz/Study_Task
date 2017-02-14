using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkVector
{
    /// <summary>
    /// Create a class with granular vector memory allocation. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int ch, n, m;
            int[] a = new int[] { 3, 5, 7, 0 ,1};

            Vector vk = new Vector(a,5,100);

            do
            {
                Console.Clear();

                Console.WriteLine("Choose operation:\n1. PushBack\n2. PopBack\n3. Insert\n4. Erase\n5. Empty\n6. At\n7. Reverse\n8. Clear\n9. Print");
                ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Write element to add:");
                            n = Int32.Parse(Console.ReadLine());
                            vk.PushBack(n);
                            Console.WriteLine("Element is successful add !\n"); 
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            vk.PopBack();
                            Console.WriteLine("Element is successful delete !\n");
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Write element to add: ");
                            n = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("Write position to add: ");
                            m = Int32.Parse(Console.ReadLine());

                            vk.Insert(n,m);
                            Console.WriteLine("Element is successful add !\n");
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Write position to delete: ");
                            m = Int32.Parse(Console.ReadLine());

                            vk.Erase(m);
                            Console.WriteLine("Element is successful delete !\n");
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();

                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("Write element to find index: ");
                            n = Int32.Parse(Console.ReadLine());

                            m = vk.At(n);
                            if (m == -1)
                                Console.WriteLine("Element not found !");
                            else Console.WriteLine("Index of {0} is {1}\n",n,m);

                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            vk.Reverse();
                            Console.WriteLine("Vector is successful reverse !\n");
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            vk.Clear();
                            Console.WriteLine("Vector is successful clear !\n");
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();
                            Console.WriteLine("Vector: ");
                            vk.Print();
                            break;
                        }
                    default:
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.DownArrow);
        }
    }
}
