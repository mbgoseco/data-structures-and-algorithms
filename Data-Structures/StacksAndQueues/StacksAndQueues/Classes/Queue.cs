using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        // Creates a queue with one node
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        // Creates a new node and sets it at the end of the queue
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            Rear.Next = node;
            Rear = node;
        }

        // Removes the node at the front of the queue and returns its value
        public int Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }

        // Returns the node value at the front of the queue
        public int Peek()
        {
            return Front.Value;
        }
    }
}
