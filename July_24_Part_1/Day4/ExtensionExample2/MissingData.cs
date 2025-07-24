using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionLibrary;

namespace ExtensionExample2
{
    internal static class MissingData
    {
        public static string MileStone3(this Operations oper)
        {
            return "MileStone 3 on .NET core JWT Web API...";
        }

        public static string MileStone4(this Operations oper)
        {
            return "MileStone 4 on React and .NET Core Combination...";
        }

        public static string Project(this Operations oper)
        {
            return "Capstone Project to be Submitted Mandetorily...";
        }
    }
}
