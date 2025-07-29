using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemos
{
    public class EmployDao
    {
        static List<Employ> employList;

        static EmployDao()
        {
            employList = new List<Employ>()
            {
                new Employ{Empno=1,Name="Akhil",Basic=88222},
                new Employ{Empno=2,Name="Yash",Basic=99223},
                new Employ{Empno=3,Name="Manali",Basic=99211},
                new Employ{Empno=4,Name="Prathyusha",Basic=92344}
            };
        }

        public List<Employ> ShowEmploy()
        {
            return employList;
        }

        public Employ SearchEmploy(int empno)
        {
            Employ employFound = null;
            foreach (Employ employ in employList)
            {
                if (employ.Empno == empno)
                {
                    employFound = employ;
                }
            }
            return employFound;
        }
    }

}
