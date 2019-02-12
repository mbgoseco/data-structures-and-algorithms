using System;
using LinkedLists.Classes;

namespace ShuffleLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            for (int i = 1; i <= 5; i++)
            {
                list.Insert(i);
            }

            Console.Write($"List before shuffle: ");
            list.Print();
            Console.Write("List after shuffle: ");
            LinkedList result = ShuffleLinkedList(list);
            result.Print();
        }

        /// <summary>
        /// Randomly shuffles the nodes of a given linked list.
        /// </summary>
        /// <param name="list">Linked list</param>
        /// <returns>Shuffled linked list</returns>
        public static LinkedList ShuffleLinkedList(LinkedList list)
        {
            if (list.Head == null)
            {
                return list;
            }

            int length = 0;
            list.Current = list.Head;

            while(list.Current.Next != null)
            {
                list.Current = list.Current.Next;
                length++;
            }
            if (list.Current.Next == null)
            {
                length++;
            }

            Random num = new Random();
            for (int i = 0; i <= length; i++)
            {
                list.Current = list.Head;
                int step = num.Next(0, length - 1);

                while (step > 0)
                {
                    if (list.Current.Next != null)
                    {
                        list.Current = list.Current.Next;
                    }
                    step--;
                }

                Node temp = list.Current;
                temp.Next = list.Current.Next;

                list.Current = list.Head;
                list.Current.Next = temp.Next;

                temp.Next = list.Head.Next;
                list.Head = temp;
            }

            return list;
        }
    }
}
