using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttrExampleNew
{
    [AttributeUsage(AttributeTargets.Class |  AttributeTargets.Method |
            AttributeTargets.Constructor, AllowMultiple =true) ]
    public class InformationAttribute : Attribute
    {
        public string InformationString { get; set; }
    }
}
