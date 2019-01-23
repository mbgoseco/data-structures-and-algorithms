using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        // Creates a stack with one node
        public Stack(Node node)
        {
            Top = node;
        }

        // Creates an empty stack
        public Stack()
        {

        }

        // Creates a new node and puts it at the top of the stack
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        // Creates a temp node, sets Top to the next node in the stack, clears the reference of next on temp, and returns the temp node's value.
        public int Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }

        // Shows the value of the top node on the stack
        public int Peek()
        {
            try
            {
                return Top.Value;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
