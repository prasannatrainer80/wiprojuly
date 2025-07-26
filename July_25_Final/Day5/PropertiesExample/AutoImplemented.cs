using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    class Employ
    {
        public int Empno { get; set; } 
        public string Name { get; set; }
        public double Basic { get; set; }
    }

    internal class AutoImplemented
    {
        static void Main()
        {
            Employ employ1 = new Employ();
            employ1.Empno = 1;
            employ1.Name = "Rajesh";
            employ1.Basic = 88323.23;

            Employ employ2 = new Employ();
            employ2.Empno = 2;
            employ2.Name = "Venkata";
            employ2.Basic = 88113;

            Employ employ3 = new Employ();
            employ3.Empno = 3;
            employ3.Name = "Vasim";
            employ3.Basic = 88124.23;

            Console.WriteLine("First Employee Record(s)  ");
            Console.WriteLine("Employ No  " +employ1.Empno + " Employ Name " +employ1.Name + " Employ Basic  " +employ1.Basic);
            Console.WriteLine("Employ No  " + employ2.Empno + " Employ Name " + employ2.Name + " Employ Basic  " + employ2.Basic);
            Console.WriteLine("Employ No  " + employ3.Empno + " Employ Name " + employ3.Name + " Employ Basic  " + employ3.Basic);

        }
    }
}
