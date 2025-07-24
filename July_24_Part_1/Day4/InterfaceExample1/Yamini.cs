using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    internal class Yamini : ITraining
    {
        public void Email()
        {
            Console.WriteLine("Email is Yamini@gmail.com");
        }

        public void Name()
        {
            Console.WriteLine("Name is Yamini...");
        }
    }
}
