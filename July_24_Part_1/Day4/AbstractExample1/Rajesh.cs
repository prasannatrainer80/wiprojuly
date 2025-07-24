using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample1
{
    internal class Rajesh : Training
    {
        public override void Email()
        {
            Console.WriteLine("Hi My Email is rajesh@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi I am Rajesh...");
        }
    }
}
