using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число:");
            var n = int.Parse(Console.ReadLine());
            int units = n % 10;
            int thousands = n / 1000;
            int d1 = n / 1000;
            int d2 = (n / 100) % 10;
            int d3 = (n / 10) % 10;
            int d4 = n % 10;
            int product = d1 * d2 * d3 * d4;

            Console.WriteLine($"Число единиц: {units}");
            Console.WriteLine($"Число тысяч: {thousands}");
            Console.WriteLine($"Произведение: {product}");

        }
    }
}
