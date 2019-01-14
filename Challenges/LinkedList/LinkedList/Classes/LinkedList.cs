using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert(int value)
        {
            try
            {
                Node node = new Node(value);
                node.Next = Head;
                Head = node;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool Includes(int value)
        {
            Current = Head;

            while(Current.Next != null)
            {
                if(Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }

            if(Current.Value == value)
                {
                return true;
            }

            return false;
        }

        public void Print()
        {
            Current = Head;

            Console.Write("Values of linked list: ");
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value}, ");
                Current = Current.Next;
            }
            Console.WriteLine($"{Current.Value}");
        }
    }
}
