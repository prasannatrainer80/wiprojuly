using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample1
{
    internal class Venkat : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is venkat@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi My Name is Venkat...");
        }
    }
}
