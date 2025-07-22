using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program to read a string and count no.of vowels in them 
/// </summary>
namespace DemoApplication
{
    internal class MileStoneEx1
    {
        public void Show(string data)
        {
            data = data.ToLower();
            int count = 0;
            char[] chars = data.ToCharArray();
            foreach(char c in chars)
            {
                if (c=='a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine("Total No. of Vowels are " +count);
        }
        static void Main()
        {
            string data;
            Console.WriteLine("Enter a String  ");
            data = Console.ReadLine();
            MileStoneEx1 obj = new MileStoneEx1();
            obj.Show(data);
        }
    }
}
