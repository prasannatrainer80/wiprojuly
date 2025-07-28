using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionExample1
    {
        static void Main()
        {
            Type typeObj = typeof(Test);
            Console.WriteLine("Methods Avaialble in Tes Class Are");
            foreach(MethodInfo mi in typeObj.GetMethods())
            {
                Console.WriteLine(mi.Name);
            }
            Console.WriteLine("Variables available in the class are ");
            foreach(FieldInfo fi in typeObj.GetFields())
            {
                Console.WriteLine(fi.Name);
            }
        }
    }
}
