using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Creates a stack with one node
        /// </summary>
        /// <param name="node"></param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Creates an empty stack
        /// </summary>
        public Stack()
        {

        }

        /// <summary>
        /// Creates a new node and puts it at the top of the stack
        /// </summary>
        /// <param name="value">int value for node</param>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Creates a temp node, sets Top to the next node in the stack, clears the reference of next on temp, and returns the temp node's value.
        /// </summary>
        /// <returns>popped node value</returns>
        public int Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }

        /// <summary>
        /// Shows the value of the top node on the stack
        /// </summary>
        /// <returns>top node's value</returns>
        public int Peek()
        {
            return Top.Value;
        }
    }
}
