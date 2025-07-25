using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Calculation
    {
        public void Calc(int a,int b)
        {
            if (a < 0 || b < 0)
            {
                throw new NegativeException("Negative Numbers Not Allowed...");
            } else if (a == 0 || b == 0)
            {
                throw new NumberZeroException("Zero is Invalid Value...");
            }
            else
            {
                int c = a + b;
                Console.WriteLine("Sum is  " +c);
            }
        }
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter 2 Numbers  ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculation calculation = new Calculation();
            try
            {
                calculation.Calc(a, b);
            }
            catch(NumberZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NegativeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            } 
        }
    }
}
