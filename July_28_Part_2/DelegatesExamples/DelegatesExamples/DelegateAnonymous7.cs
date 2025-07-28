using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class DelegateAnonymous7
    {
        public delegate void MyDelegate(string str);
        static void Main()
        {
            MyDelegate obj = delegate(string str) 
            {
                Console.WriteLine("This is Anonymous Method  " +str);
            };

            obj("Prasanna");
        }
    }
}
