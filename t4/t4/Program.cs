using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");

            var x = double.Parse(Console.ReadLine());
            var y = F(x);

            double baseNumber = Math.Tan(x);
            double baseNumber2 = Math.Cos(x);

            Console.WriteLine("y = "+ y);
        }
        static double F(double x) => Math.Abs(x) + 2 * Math.Sin(Math.Pow(Math.Tan(x), 2) + 4)/ 5.5 * x;
    }
}
