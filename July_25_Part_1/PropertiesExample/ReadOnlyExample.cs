using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program to Demo about Read-Only Properties
/// </summary>
namespace PropertiesExample
{
    class Bank
    {
        public int AccountNo { get; } = 12;
        public string BranchName { get; } = "ECIL";
        public string BankName { get; } = "ICICI";
    }
    internal class ReadOnlyExample
    {
        static void Main()
        {
            Bank bank = new Bank();
            Console.WriteLine("Account No  " +bank.AccountNo);
            Console.WriteLine("Bank Name  " +bank.BankName);
            Console.WriteLine("Branch Name  " +bank.BranchName);
        }
    }
}
