using System;
using LinkedLists.Classes;

namespace LinkedList_KthFromEnd
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int k = 3;
                int kValue = FindKthFromEnd(k);
                Console.WriteLine($"Node value that is {k} places from the end of the list is {kValue}");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static int FindKthFromEnd(int k)
        {
            LinkedList myList = new LinkedList();
            Console.Write("Node list values: ");
            for (int i = 9; i > 0; i--)
            {
                myList.Insert(i);
            }

            int listLength = 0;

            myList.Current = myList.Head;
            while (myList.Current.Next != null)
            {
                Console.Write($"[{myList.Current.Value}] ");
                myList.Current = myList.Current.Next;
                listLength++;
            }
            if(myList.Current.Next == null)
            {
                Console.WriteLine($"[{myList.Current.Value}] ");
                listLength++;
            }

            myList.Current = myList.Head;
            for (int i = 0; i < listLength - k - 1; i++)
            {
                myList.Current = myList.Current.Next;
            }
            return myList.Current.Value;

        }
    }
}
