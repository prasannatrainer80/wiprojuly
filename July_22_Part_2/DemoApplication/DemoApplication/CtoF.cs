using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program to Convert Celsius into Fahrenheit
/// </summary>
namespace DemoApplication
{
    internal class CtoF
    {
        public double ConvertToFahrenehit(double celcius)
        {
            double f = ((9 * celcius) / 5) + 32;
            return f;
        }
        static void Main()
        {
            double celsius;
            Console.WriteLine("Enter Celsius Value  ");
            celsius = Convert.ToDouble(Console.ReadLine());
            CtoF obj = new CtoF();
            Console.WriteLine("Fahrenheit Value is  " +obj.ConvertToFahrenehit(celsius));
        }
    }
}
