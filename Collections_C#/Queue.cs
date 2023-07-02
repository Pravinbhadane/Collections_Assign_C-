using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_C_
{
    public class Queue_pro
    {
        static void Main(string[] args)
        {
            // Queue --> FIFO (first in first out)
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Removed Element "+ queue.Dequeue()); //remove the first element- 10

            Console.WriteLine($"first element in the list {queue.Peek()}");
            Console.WriteLine($"total elements in the queue {queue.Count}");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

    }
}
