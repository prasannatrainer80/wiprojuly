using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class Demo
    {
        static void Main()
        {
            int[,] x = new int[2, 3]
            {
                {1, 2, 3},
                {5,2,8 }
            };

            for(int i=0;i<x.GetLength(0);i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.WriteLine("x{0}{1}  {2}",i,j, x[i,j]);
                }
                    
            }
        }
    }
}
