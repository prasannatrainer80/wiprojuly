using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class JaggedArrayEx2
    {
        static void Main()
        {
            int[][] jaggedArray = new int[2][];

            int[] x = new int[] { 12, 5, 22 };
            int[] y = new int[] { 55, 11, 124 };

            jaggedArray[0] = x;
            jaggedArray[1] = y;

            for(int i=0; i<jaggedArray.Length; i++)
            {
                for(int j=0;j<jaggedArray[i].Length;j++)
                {
                    Console.Write(jaggedArray[i][j] + "    ");
                }
                Console.WriteLine();
            }
        }
    }
}
