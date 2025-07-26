using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class GenEx1
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;
        }

        static void Main()
        {
            int a = 5, b = 4;
            Swap(ref a, ref b);
            Console.WriteLine("A value " +a + " B value  " +b);
            string s1 = "Venkata", s2 = "Uday";
            Swap(ref s1, ref s2);
            Console.WriteLine("S1 " +s1+ " S2  " +s2);
            double b1 = 12.5, b2 = 3.2;
            Swap(ref b1, ref b2);
            Console.WriteLine("B1  " +b1+ " B2  " +b2);
            bool f1 = true, f2 = false;
            Console.WriteLine("F1  " +f1+ " F2  " +f2);
        }
    }
}
