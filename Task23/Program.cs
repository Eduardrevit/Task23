using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления факториала");
            int m = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(m);

            Console.ReadKey();
        }
        static void Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i < n + 1; i++)
            {
                f *= i;
            }
            Console.WriteLine($"Факториал числа равен {f}");
        }
        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
