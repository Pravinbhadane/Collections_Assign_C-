using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_C_
{
    internal class Arr_5_Strings
    {
        static void Main(string[] args)
        {
            String[] students = new String[5];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] =Console.ReadLine();
            }

            Array.Sort(students);

            foreach (var item in students)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
