using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDay_07Jan2016_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of a circle to determine perimeter and area:");
            string radiusAsString = Console.ReadLine();
            double radiusAsDouble = Convert.ToDouble(radiusAsString);

            double area = Math.PI * radiusAsDouble * radiusAsDouble;
            double Perimeter = (2 * Math.PI * radiusAsDouble);

            Console.WriteLine("Area= " + area);
            Console.WriteLine("Perimeter= " + Perimeter);

        }
    }
}
