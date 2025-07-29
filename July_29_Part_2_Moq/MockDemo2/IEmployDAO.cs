using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDemo2
{
    public interface IEmployDAO
    {
        List<Employ> ShowEmploy();
        Employ SearchEmploy(int empno);
    }
}
