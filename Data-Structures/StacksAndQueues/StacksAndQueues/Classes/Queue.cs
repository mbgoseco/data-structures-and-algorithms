using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        /// <summary>
        /// Creates a queue with one node
        /// </summary>
        /// <param name="node">node object</param>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Creates a new node and sets it at the end of the queue
        /// </summary>
        /// <param name="value">value for new node</param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Removes the node at the front of the queue and returns its value
        /// </summary>
        /// <returns>removed node's value</returns>
        public int Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }

        /// <summary>
        /// Removes the node at the front of the queue and returns its value
        /// </summary>
        /// <returns>front node value</returns>
        public int Peek()
        {
            try
            {
                return Front.Value;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
