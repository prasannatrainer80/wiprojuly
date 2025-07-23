using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFirstLibrary
{
    public class Demo
    {
        private string privateStr = "Sanman";
        public string publicStr = "Rajesh";
        protected string protectedStr = "Sreeja";
        internal string internalStr = "Kethavi";
        internal protected string ipStr = "DevaDatta";

        void Show()
        {
            Console.WriteLine(privateStr);
            Console.WriteLine(publicStr);
            Console.WriteLine(protectedStr);
            Console.WriteLine(internalStr);
            Console.WriteLine(ipStr);
        }
    }
}
