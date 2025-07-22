using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program to display factors of given number (assume 10 number factors are 1, 2, 5, 10)
/// </summary>
namespace DemoApplication
{
    internal class Factors
    {
        public void Show(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Factor  " +i);
                }
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter N value  ");
            n = Convert.ToInt32(Console.ReadLine());
            Factors factors = new Factors();
            factors.Show(n);
        }
    }
}
