using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockRepeat
{
    public interface IEmployDAO
    {
        List<Employ> ShowEmploy();
        Employ SearchEmploy(int empno);
    }
}
