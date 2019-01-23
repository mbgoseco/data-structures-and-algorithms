using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stack PQueue { get; set; }

        // Pseudo queue constructor creates new Stack instance in PseudoQueue
        public PseudoQueue()
        {
            PQueue = new Stack();
        }

        // Stack push() method works the same as Enqueue() by simply adding a new node to the rear which is equal to top
        public void Enqueue(int value)
        {
            PQueue.Push(value);
        }

        // Simulates Dequeue() by popping all but the last node and pushing into a temp stack, pushing it all again to a new stack, then reassigning it back to the PseudoQueue stack.
        public int Dequeue()
        {
            // Temp stacks for flipping and popping
            Stack Stack1 = new Stack();
            Stack Stack2 = new Stack();
            int temp;

            // If PQueue only has one node, pop it and return its value.
            if (PQueue.Top.Next == null)
            {
                temp = PQueue.Pop();
                return temp;
            }

            // Moves all but the dequeued node to temp stack1
            while (PQueue.Top.Next != null)
            {
                Stack1.Push(PQueue.Pop());
            }

            // Stores the value of the dequeued node
            temp = PQueue.Top.Value;

            // Moves all the nodes from stack1 to stack2 in original order
            while (Stack1.Top.Next != null)
            {
                Stack2.Push(Stack1.Pop());

            }
            if (Stack1.Top.Next == null)
            {
                Stack2.Push(Stack1.Pop());
            }

            // Assigns the new stack minus the dequeued node back to PQueue
            PQueue = Stack2;
            // Returns dequeued node's value
            return temp;
        }
    }
}
