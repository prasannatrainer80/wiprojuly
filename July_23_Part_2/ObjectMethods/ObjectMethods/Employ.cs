using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    internal class Employ
    {
        int empno;
        string name;
        double basic;

        public Employ()
        {

        }

        public override string ToString()
        {
            return "Employ No " + empno + " Name " + name + " Basic " + basic;
        }

        public Employ(int empno,string name, double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }
    }
}
