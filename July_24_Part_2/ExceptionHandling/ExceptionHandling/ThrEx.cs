using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ThrEx
    {
        public void Show(int n)
        {
            if (n < 0)
            {
                throw new DivideByZeroException("Negative Numbers Not Allowed...");
            } else if (n == 0)
            {
                throw new IndexOutOfRangeException("Zero is Invalid Value...");
            } else
            {
                Console.WriteLine("N value is " +n);
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter a Number  ");
            n = Convert.ToInt32(Console.ReadLine());
            ThrEx obj = new ThrEx();
            try
            {
                obj.Show(n);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
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
