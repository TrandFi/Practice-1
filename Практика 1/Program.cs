using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа, которая складывает, вычитает, умножает и делит два числа");
            Console.Write("Введите первое число = ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число = ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма чисел равна = {A + B}");
            Console.WriteLine($"Разность чисел равна = {A - B}");
            Console.WriteLine($"Произведение чисел равно = {A * B}");
            Console.WriteLine($"Частное чисел равно = {(double)A / (double)B}");
            Console.Read();
        }
    }
}
