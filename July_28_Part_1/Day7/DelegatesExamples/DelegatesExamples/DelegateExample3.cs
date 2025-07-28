using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// Example about Multi-Cast Delegae
/// </summary>
namespace DelegatesExamples
{
    internal class DelegateExample3
    {
        #region delegate_declaration
        public delegate void MyDelegate(int n);
        #endregion delegate_declaration

        #region methods
        public static void Fact(int n)
        {
            int f = 1;
            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial Value " +f);
        }

        public static void PosNeg(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("Positive Number...");
            }
            else
            {
                Console.WriteLine("Negative Number...");
            }
        }

        public static void EvenOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Even Number...");
            }
            else
            {
                Console.WriteLine("Odd Number...");
            }
        }
        #endregion methods

        #region Main
        static void Main()
        {
            int n;
            Console.WriteLine("Enter N value  ");
            n = Convert.ToInt32(Console.ReadLine());
            MyDelegate obj = new MyDelegate(PosNeg);
            obj += new MyDelegate(Fact);
            obj += new MyDelegate(EvenOdd);
            obj(n);
        }
        #endregion Main
    }
}
