using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_C_
{
    public class Htable
    {
        static void Main(string[] args)
        {
            Hashtable employees = new Hashtable();
            employees.Add(1, "PRAVIN");
            employees.Add(2, "PAWAN");
            employees.Add(3, "GAURAV");
            employees.Add(4, "MAYUR");
            employees.Add(5, "KARTIK");

             

            foreach (DictionaryEntry item in employees)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

            

            Console.WriteLine("After Removing");

            foreach (DictionaryEntry item in employees)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }

    }
}
