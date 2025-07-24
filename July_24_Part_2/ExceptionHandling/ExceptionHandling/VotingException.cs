using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class VotingException : ApplicationException
    {
        public VotingException(string error) : base(error) { }
    }
}
