using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class BoxEmploy
    {
        public void Show(object obj)
        {
            string type=obj.GetType().Name;
            if (type.Equals("Employ"))
            {
                Employ employ = (Employ)obj;
                Console.WriteLine("Employ No  " +employ.empno + " Name " +employ.name + " Basic " +employ.basic);
            }
        }
        static void Main()
        {
            Employ employ = new Employ();
            employ.empno = 1;
            employ.name = "Yamini";
            employ.basic = 88233;

            BoxEmploy boxEmploy = new BoxEmploy();
            boxEmploy.Show(employ);
        }
    }
}
