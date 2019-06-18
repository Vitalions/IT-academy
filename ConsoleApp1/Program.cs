using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int bseach(int[] mass, int x)
        {
            for (int i = 0; i < mass.Length; i++)
                if (mass[i] > x) return i;
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            Random rnd = new Random();
            int[] mass = new int[int.Parse(Console.ReadLine())];
            for(int i = 0; i<mass.Length;i++)
            {
                mass[i] = rnd.Next(50)-25;
                Console.Write(mass[i]+ " ");
            }
            Array.Sort(mass);
            Console.WriteLine("\nВведите число X:");
            int maxX = bseach(mass,int.Parse(Console.ReadLine()));
            if(maxX > -1)
            {
                Console.WriteLine($"Индекс элемента массива больше X: {maxX}");
            }
            else
            {
                Console.WriteLine("Числа больше X нет!");
            }

        }
    }
}
