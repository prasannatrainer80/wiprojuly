using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    internal class Sunil : ITraining
    {
        public void Email()
        {
            Console.WriteLine("Email is sunil@gmail.com");
        }

        public void Name()
        {
            Console.WriteLine("Hi Name is Sunil...");
        }
    }
}
