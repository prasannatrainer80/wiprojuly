using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class JaggedArrayEx3
    {
        static void Main()
        {
            int n, m;
            Console.WriteLine("Enter No.of Jagged Arrays and Size of elements ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            int[] x = new int[m];
            int[] y = new int[m];

            Console.WriteLine("Enter Elements for Array X ");
            for(int i=0;i<m;i++)
            {
                x[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Elements for Array Y ");
            for(int i = 0; i < m; i++)
            {
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
            jaggedArray[0] = x;
            jaggedArray[1] = y;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "    ");
                }
                Console.WriteLine();
            }
        }
    }
}
