using System;
using StacksAndQueues.Classes;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                QueueWithStacks();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void QueueWithStacks()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);


            Console.WriteLine(queue.PQueue.Top.Next.Next.Value);

            Console.WriteLine(queue.Dequeue());

            Console.WriteLine(queue.PQueue.Top.Next.Next.Value);
        }
    }
}
