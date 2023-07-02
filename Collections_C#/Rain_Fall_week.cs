using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_C_
{
    public class Rain_Fall_week
    {
        static void Main(string[] args)
        {
            double[] rainfall = new double[7];

            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.Write($" Enter rainfall for day {i + 1}: ");
                rainfall[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.WriteLine($"Day {i+1}: {rainfall[i]}");
            }
        }
    }
}
