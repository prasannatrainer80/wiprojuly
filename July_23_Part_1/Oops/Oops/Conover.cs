using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Conover
    {
        int a, b;

        public Conover()
        {
            a = 5;
            b = 7;
        }
        public Conover(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Show()
        {
            Console.WriteLine("A value is " +a+ " B value is " +b);
        }
        static void Main()
        {
            Conover obj1 = new Conover();
            obj1.Show();
            Conover obj2 = new Conover(66, 12);
            obj2.Show();
        }
    }
}
