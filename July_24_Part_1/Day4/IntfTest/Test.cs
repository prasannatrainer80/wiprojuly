using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntfTest
{
    internal class Test : IOne, ITwo
    {
        void IOne.Show()
        {
            Console.WriteLine("Show Method from Interface One...");
        }

        void ITwo.Show()
        {
            Console.WriteLine("Show Method from Interface Two...");
        }
    }
}
