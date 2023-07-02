using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_C_
{
    public class Array_Metods
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine();
            Console.WriteLine("After Sorting");

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            int [] arr2 = new int[7];

            Array.Copy(arr, arr2,5);
            Console.WriteLine("after copying in 2nd array");
            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nAfter Reverse");
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Array.Clear(arr);
            Console.WriteLine("\nCleared the array");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }


        }
    }
}
