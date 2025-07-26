using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("Welcome to C#");
            Console.WriteLine(stringBuilder);
            stringBuilder.Append("Trainer is Prasanna\n");
            stringBuilder.Append("For Wipro Client\n");
            Console.WriteLine(stringBuilder);

        }
    }
}
