using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_C_
{
    internal class Jagged_Array
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[4];
            arr[2] = new int[5];
          

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" "+arr[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
