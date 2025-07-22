using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class LoopEx1
    {
        public void Show()
        {
            int i = 0; // Initialization
            int count = 10;
            while (i < count)
            {
                Console.WriteLine("Welcome to Dotnet...");
                i++;
            }
        }
        static void Main()
        {
            LoopEx1 obj = new LoopEx1();
            obj.Show();
        }
    }
}
