using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClsReflectionExample1;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionExamples
{
    internal class ReflectionExample8
    {
        static void Main()
        {
            Type objStudent = typeof(Student);
            Console.WriteLine("Methods available are ");
            foreach(MethodInfo m in objStudent.GetMethods())
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine("Fields available are  ");
            foreach(FieldInfo f in objStudent.GetFields())
            {
                Console.WriteLine(f.Name);
            }
        }
    }
}
