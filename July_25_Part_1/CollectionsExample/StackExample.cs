using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    internal class StackExample
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push("Sreepriya");
            stack.Push("Neshat");
            stack.Push("Manjula");
            stack.Push("Akhil");
            stack.Push("Mounika");
            Console.WriteLine("Stack Data  ");
            foreach(object o in stack)
            {
                Console.WriteLine(o);
            }
            stack.Pop();
            Console.WriteLine("Poping one element ");
            foreach (object o in stack)
            {
                Console.WriteLine(o);
            }
            stack.Pop(); 
            stack.Pop();
            Console.WriteLine("Poping Two elements ");
            foreach (object o in stack)
            {
                Console.WriteLine(o);
            }
        }
    }
}
