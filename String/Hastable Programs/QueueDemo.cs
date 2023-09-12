using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Hastable_Programs
{
    internal class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            queue.Dequeue(); // 10

            Console.WriteLine("First element in the queue" + queue.Peek());

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
