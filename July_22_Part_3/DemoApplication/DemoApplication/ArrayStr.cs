using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class ArrayStr
    {
        public void Show()
        {
            string[] names = new string[]
            {
                "Rajesh","Dilip","Basha","Sreeja","Anusha"
            };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
        static void Main()
        {
            ArrayStr arrayStr = new ArrayStr();
            arrayStr.Show();
        }
    }
}
