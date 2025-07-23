using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class C1
    {
        public C1()
        {
            Console.WriteLine("Base Class Constructor...");
        }
    }

    class C2 : C1 
    {
        public C2()
        {
            Console.WriteLine("Derived Class Constructor...");
        }
    }

    internal class Inhc
    {
        static void Main()
        {
            C2 c2 = new C2();
        }
    }
}
