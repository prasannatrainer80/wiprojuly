using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntfTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOne obj1 = new Test();
            obj1.Show();

            ITwo obj2 = new Test();
            obj2.Show();
        }
    }
}
