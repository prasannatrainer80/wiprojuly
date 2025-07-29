using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemos
{
    public class Demo
    {
        public bool EvenOdd(int n)
        {
            if (n%2==0)
            {
                return true;
            }
            return false;
        }
        public int Max3(int a,int b, int c)
        {
            int m = a;
            if (m < b)
            {
                m = b;
            }
            if (m < c)
            {
                m = c;
            }
            return m;
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }   
        public string SayHello()
        {
            return "Welcome to C# FSD Programming...";
        }
    }
}
