using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_C_
{
    public class Matrix
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,3];
            Console.WriteLine("Enter 1st matrix Values");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j <arr.GetLength(1) ; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] arr2 = new int[3, 3];
            Console.WriteLine("Enter 2nd matrix Values");

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                int  addition =  arr[i, j] + arr2[i,j];

                    Console.Write("  "+addition+ "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
