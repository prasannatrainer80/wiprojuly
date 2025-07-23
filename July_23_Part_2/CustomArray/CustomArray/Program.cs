using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = new Student[]
            {
                new Student(1,"Pallavi",9.2,"Hyderabad"),
                new Student(2,"Veera",8.9,"Vijayanagaram"),
                new Student(3, "Rajesh",9.1,"Rajahmundry")
            };

            foreach (Student student in studentArray)
            {
                Console.WriteLine(student);
            }
        }
    }
}
