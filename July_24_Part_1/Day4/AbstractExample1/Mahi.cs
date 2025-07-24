using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample1
{
    internal class Mahi : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Mahi@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi My Name is Mahi...");
        }
    }
}
