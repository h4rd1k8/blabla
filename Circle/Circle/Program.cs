using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radius:");
            double a = int.Parse(Console.ReadLine());
            double findArea(double x)
            {
                return Math.PI * x * x;
            }
            double findDiameter(double x)
            {
                return 2 * x;
            }
            double findCircumference(double x)
            {
                return 2 * Math.PI * x;
            }
            Console.WriteLine("Area:");
            Console.WriteLine(findArea(a));
            Console.WriteLine("Diameter:");
            Console.WriteLine(findDiameter(a));
            Console.WriteLine("Circumference:");
            Console.WriteLine(findCircumference(a));
        }
    }

}