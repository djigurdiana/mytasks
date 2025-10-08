using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app5
{
    internal class Program
    {
        static double Expression(double a, double b)


        {
            double numerator = Math.Sqrt(a) - Math.Sqrt(b);
            double denomirator = Math.Sqrt(a) + Math.Sqrt(b);
            return numerator/ denomirator;

        }
        static void Main(string[] args)

        {
        
           double x = Expression(3, 2) + Expression(5, 7) + Expression(11, 7);
            Console.WriteLine($"X: {x:F3}");
            
    }
}
}

