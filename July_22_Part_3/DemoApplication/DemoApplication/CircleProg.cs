using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program to Calculate area and circ. of circle
/// </summary>
namespace DemoApplication
{
    internal class CircleProg
    {
        public void Calc(double radius)
        {
            double area, circ;
            area = Math.PI * radius * radius;
            circ = 2 * Math.PI * radius;
            Console.WriteLine("Area of Circle  " +area);
            Console.WriteLine("Circumference  " +circ);
        }
        static void Main()
        {
            double radius;
            Console.WriteLine("Enter Radius  ");
            radius = Convert.ToDouble(Console.ReadLine());
            CircleProg circleProg = new CircleProg();
            circleProg.Calc(radius);
        }
    }
}
