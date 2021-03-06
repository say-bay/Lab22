using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab22
{
    class Program
    {
        static int n = 0;
        static void Sum(int[] array)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s = s + array[i];
            }
            Console.WriteLine($"Сумма чисел равна {s}");
        }
        static void Max(int[] array)
        {
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > m)
                {
                    m = array[i];
                }
            }
            Console.WriteLine($"Максимальное число равно {m}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                var rand = new Random();
                array[i] = rand.Next(100);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Task task = new Task(() => Max(array));
            task.Start();
            Sum(array);
            Console.ReadKey();
        }
    }
}
