using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Fact
    {

        public void Calc(int n)
        {
            int i = 1, f = 1;
            while(i <= n)
            {
                f = f * i;
                i++;
            }
            Console.WriteLine("Factorial Value  " +f);
        }

        static void Main()
        {
            int n;
            Console.WriteLine("Enter N Value   ");
            n = Convert.ToInt32(Console.ReadLine());
            Fact fact = new Fact();
            fact.Calc(n);
        }
    }
}
