using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class OverloadEx1
    {
        public void Show(int x)
        {
            Console.WriteLine("Show Method w.r.t. int  " +x);
        }

        public void Show(double x)
        {
            Console.WriteLine("Show Method w.r.t. double  " +x);
        }

        public void Show(string x)
        {
            Console.WriteLine("Show Method w.r.t. String  " +x);
        }
        static void Main(string[] args)
        {
            OverloadEx1 obj = new OverloadEx1();
            obj.Show(12);
            obj.Show("Wipro");
            obj.Show(523.33);
        }
    }
}
