using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace CollectionsExample
{
    internal class Example1
    {
        static void Main(string[] args)
        {
            ArrayList namesList = new ArrayList();
            namesList.Add("Vasim");
            namesList.Add("Rajesh");
            namesList.Add("Madhu");
            namesList.Add("Vandana");
            namesList.Add("Nithin");
            Console.WriteLine("Default ArrayList Elements are  ");
            foreach(object obj in namesList)
            {
                Console.WriteLine(obj);
            }

            namesList.Insert(3, "Manjula");
            Console.WriteLine("List after Inserting New Element ");
            foreach (object obj in namesList)
            {
                Console.WriteLine(obj);
            }
            namesList.Remove("Madhu");
            Console.WriteLine("List after Removing By Name  ");
            foreach (object obj in namesList)
            {
                Console.WriteLine(obj);
            }
            namesList.RemoveAt(2);
            Console.WriteLine("List after Removing By Position  ");
            foreach (object obj in namesList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
