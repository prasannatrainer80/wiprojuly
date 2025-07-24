using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsConEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ[] arrEmploy = new Employ[]
            {
                new Uday(1, "Uday", 82344),
                new Anusha(2, "Anusha",88411),
                new Madhu(3, "Madhu",88114)
            };

            foreach(Employ employ in arrEmploy)
            {
                Console.WriteLine(employ);
            }
        }
    }
}
