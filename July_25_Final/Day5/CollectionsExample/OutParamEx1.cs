using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    internal class OutParamEx1
    {
        public void Show(int empno, out string name, out double basic)
        {
            name = string.Empty;
            basic = 0;
            if (empno == 1)
            {
                name = "Uday";
                basic = 88234;
            }
            if (empno == 2)
            {
                name = "Nitin";
                basic = 99321;
            }
            if (empno == 3)
            {
                name = "Pradeepthi";
                basic = 88411;
            }
        }
        static void Main()
        {
            int empno;
            Console.WriteLine("Enter Employ Number  ");
            empno = Convert.ToInt32(Console.ReadLine());
            OutParamEx1 obj  = new OutParamEx1();
            string name;
            double basic;
            obj.Show(empno, out name, out basic);
            Console.WriteLine("Name is " +name);
            Console.WriteLine("Basic is  " +basic);
        }
    }
}
