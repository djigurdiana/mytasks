using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону прямоугольника 1");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника 2");
            var b = double.Parse(Console.ReadLine());

            double area = a * b;

            double perimetr = a * 2 + b * 2;
            double diagonal = (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.WriteLine($"площадь прямоугольника: {area}");
            Console.WriteLine($"периметр прямоугольника: {perimetr}");
            Console.WriteLine($"диагональ прямоугольника: {diagonal}");

        }
    }
}
