using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class Predicate13
    {
        public static bool Check(string gender)
        {
            if (gender.Equals("MALE") || gender.Equals("FEMALE"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool MaritalStatus(int status)
        {
            if (status == 1 || status == 0)
            {
                return true;
            }
            return false;
        }
        static void Main()
        {
            Console.WriteLine("Enter Gender (MALE/FEMALE)  ");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter MaritalStatus (0 or 1)  ");
            int mstat = Convert.ToInt32(Console.ReadLine());
            Predicate<string> result1 = Check;
            Console.WriteLine(result1(gender));
            Predicate<int> result2 = MaritalStatus;
            Console.WriteLine(result2(mstat));
        }
    }
}
