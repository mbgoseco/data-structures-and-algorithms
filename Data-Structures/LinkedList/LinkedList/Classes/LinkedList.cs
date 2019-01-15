using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// Creates a new node instance and inserts it at the head of the linked list.
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Determines if a given value exists in the linked list.
        /// </summary>
        /// <param name="value">Node Value</param>
        /// <returns>true or false</returns>
        public bool Includes(int value)
        {
            Current = Head;

            if (Head == null)
            {
                return false;
            }

            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }

            if (Current.Value == value)
                {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Prints all values of linked list to the console.
        /// </summary>
        public void Print()
        {
            Current = Head;

            if (Head == null)
            {
                Console.WriteLine("List has no nodes to display.");
                return;
            }

            Console.Write("Values of linked list: ");
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value}, ");
                Current = Current.Next;
            }
            Console.WriteLine($"{Current.Value}");
        }

        /// <summary>
        /// Creates a new node instance and appends it to the end of the linked list.
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            Current = Head;

            if (Head == null)
            {
                Insert(value);
                return;
            }

            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Node node = new Node(value);
            Current.Next = node;
        }

        /// <summary>
        /// Attempts to find a target node value in the linked list and insert a new node before it.
        /// </summary>
        /// <param name="value">target value</param>
        /// <param name="newValue">new node value</param>
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;

            if (Current.Value == value)
            {
                Insert(newValue);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                else
                {
                    Current = Current.Next;
                }
            }
        }

        /// <summary>
        /// Attempts to find a target node value in the linked list and insert a new node after it.
        /// </summary>
        /// <param name="value">target value</param>
        /// <param name="newValue">new node value</param>
        public void InsertAfter(int value, int newValue)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                else
                {
                    Current = Current.Next;
                }
            }

            if (Current.Value == value)
            {
                Append(newValue);
                return;
            }
        }
    }
}
