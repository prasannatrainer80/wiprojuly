using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class JaggedArrayEx4
    {
        static void Main()
        {
            int n, m;
            Console.WriteLine("Enter No.of Jagged Arrays and Size of elements ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            int[,] x = new int[n, m];
            Console.WriteLine("Enter The element for Multi-Dimenstional Array");
          
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Display Elements in Matrix Format  ");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + "  ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Adding Data to Jagged Array");
            for(int i=0;i<n;i++)
            {
                int[] p = new int[m]; 
               for(int j = 0; j < m; j++)
                {
                    //Console.WriteLine(x[i,j]);
                    p[j] = x[i, j];
;                }
                jaggedArray[i] = p;
            }

            Console.WriteLine("Jagged Done");
            Console.WriteLine("Print Jagged Array Data ");
            Console.WriteLine(jaggedArray.Length);
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
