using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_C_
{
    internal class Arraylist_List
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("Pravin");
            list.Add(5);
            

            foreach (var item in list)
            {
                Console.Write(item+",");
            }
            Console.WriteLine();

            list.Remove(3);
            Console.WriteLine($"after removing ");
            foreach (var item in list)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();

            //list.Clear();

            foreach (var item in list)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }
    }
}
