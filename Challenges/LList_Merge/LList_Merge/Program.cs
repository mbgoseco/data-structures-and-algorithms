using System;
using LinkedLists.Classes;

namespace LList_Merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList listOne = new LinkedList();
            for (int i = 0; i < 4; i++)
            {
                listOne.Insert(i);
            }

            LinkedList listTwo = new LinkedList();
            listTwo.Insert(5);
            listTwo.Insert(9);

            listOne.Current = listOne.Head;
            listTwo.Current = listTwo.Head;

            listOne = MergeLists(listOne, listTwo);

            listOne.Print();
        }

        public static LinkedList MergeLists(LinkedList one, LinkedList two)
        {

            Console.Write("List one values: ");
            while (one.Current.Next != null)
            {
                Console.Write($"[{one.Current.Value}] ");
                one.Current = one.Current.Next;
            }
            if (one.Current != null)
            {
                Console.WriteLine($"[{one.Current.Value}] ");
            }

            Console.Write("List two values: ");
            while (two.Current.Next != null)
            {
                Console.Write($"[{two.Current.Value}] ");
                two.Current = two.Current.Next;
            }
            if (two.Current != null)
            {
                Console.WriteLine($"[{two.Current.Value}] ");
            }

            Node runnerOne = one.Head;
            Node runnerTwo = one.Head;

            one.Current = one.Head;
            two.Current = two.Head;

            while(one.Current.Next != null)
            {
                // Moves runners one node ahead of current to retain old refrence paths
                runnerOne = one.Current.Next;
                runnerTwo = two.Current.Next;

                // Works like InsertBefore()
                one.Current.Next = two.Current;
                two.Current.Next = runnerOne;

                // Sets current nodes to old .Next references
                one.Current = runnerOne;
                two.Current = runnerTwo;

                if (two.Current == null)
                {
                    return one;
                }
            }

            return one;
        }
    }
}
