using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ e1 = new Employ(1, "Venkat", 88423.44);
            Employ e2 = new Employ(2, "Rakesh", 84823.44);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
        }
    }
}
