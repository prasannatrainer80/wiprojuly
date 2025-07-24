using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    internal class StaticEx
    {
        static int count;
        public void Increment()
        {
            count++;
        }

        public void Show()
        {
            Console.WriteLine("Count is  " +count);
        }
        static void Main(string[] args)
        {
            StaticEx obj1 = new StaticEx();
            StaticEx obj2 = new StaticEx();
            StaticEx obj3 = new StaticEx();

            obj1.Increment();
            obj2.Increment();
            obj3.Increment();

            obj1.Show();
        }
    }
}
