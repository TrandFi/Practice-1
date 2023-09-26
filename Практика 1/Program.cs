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
            Console.WriteLine("Программа, которая складывает два числа");
            Console.Write("Введите первое число = ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число = ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма чисел равна = {A + B}");
            Console.Read();
        }
    }
}
