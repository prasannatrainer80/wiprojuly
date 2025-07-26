using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class GenEx2
    {

        static void Main()
        {
            List<Int32> numbers = new List<Int32>();
            numbers.Add(42);
            numbers.Add(88);
            numbers.Add(48);
            numbers.Add(11);
            numbers.Add(9);

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
