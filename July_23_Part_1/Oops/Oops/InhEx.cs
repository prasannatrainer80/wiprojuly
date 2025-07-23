using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class First
    {
        public void Show()
        {
            Console.WriteLine("Show Method from Class First...");
        }
    }

    class Second : First
    {
        public void Display()
        {
            Console.WriteLine("Display Method from Class Second...");
        }
    }
    internal class InhEx
    {
        static void Main()
        {
            Second second = new Second();
            second.Show();
            second.Display();
        }
    }
}
