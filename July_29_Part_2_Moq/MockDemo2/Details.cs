using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDemo2
{
    public class Details : IDetails
    {
        public string ShowCompany()
        {
            return "Its Capgemini from Hyderabad...";
        }

        public string ShowStudent()
        {
            return "Hi Sai Akhil Here...";
        }
    }
}
