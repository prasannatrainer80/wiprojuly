using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspWithout
{
    internal class Rajesh : IEmployDetails
    {
        public void AccountDetails()
        {
            throw new NotImplementedException();
        }

        public void PersonalDetails()
        {
            Console.WriteLine("Hi I am Rajesh...");
        }

        public void ProjectDetails()
        {
            throw new NotImplementedException();
        }
    }
}
