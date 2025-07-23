using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArray
{
    internal class Student
    {
        int sid;
        string sname;
        double cgpa;
        string city;

        public Student() { }

        public Student(int sid, string sname, double cgpa, string city)
        {
            this.sid = sid;
            this.sname = sname;
            this.cgpa = cgpa;
            this.city = city;
        }

        public override string ToString()
        {
            return "Sid " + sid + " Name " + sname + " Cgp  " + cgpa + " City " + city;
        }
    }
}
