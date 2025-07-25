using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class NumberZeroException : ApplicationException
    {
        public NumberZeroException(string error) : base(error) { }
    }
}
