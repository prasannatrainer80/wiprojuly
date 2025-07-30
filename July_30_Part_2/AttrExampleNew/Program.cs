using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Security.Permissions;

namespace AttrExampleNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type obj = typeof(Student);
            Assembly exec = Assembly.GetExecutingAssembly();
            Type[] types = exec.GetTypes();
            foreach(var v in types)
            {
                foreach(var a in v.GetCustomAttributes())
                {
                    Console.WriteLine(a.TypeId);
                }
            }
        }
    }
}
