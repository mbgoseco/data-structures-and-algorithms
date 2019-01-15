using System;
using LinkedLists.Classes;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();

            try
            {
                int[] nums = { 42, 5, 9999, 777, 911 };
                foreach (int num in nums)
                {
                    myList.Insert(num);
                    Console.WriteLine($"{num} inserted to head of linked list.");
                }
                Console.WriteLine();

                Console.WriteLine($"Does 99 exist on the linked list?   {(myList.Includes(99) ? "Yes" : "No")}");
                Console.WriteLine($"Does 42 exist on the linked list?   {(myList.Includes(42) ? "Yes" : "No")}");
                Console.WriteLine($"Does 777 exist on the linked list?   {(myList.Includes(777) ? "Yes" : "No")}");
                Console.WriteLine();

                int[] moarNums = { 8, 16, -3 };
                foreach (int num in moarNums)
                {
                    myList.Insert(num);
                    Console.WriteLine($"{num} appended to linked list.");
                }
                Console.WriteLine();

                int[] manyNums = { 25, 50, 75 };
                int[] manyNumsTarget = { 5, 911, 16 };
                for(int i = 0; i < manyNums.Length; i++)
                {
                    myList.InsertBefore(manyNumsTarget[i], manyNums[i]);
                    Console.WriteLine($"{manyNums[i]} added to list before {manyNumsTarget[i]}.");
                }
                Console.WriteLine();

                int[] suchNums = { 15, 45, 60 };
                int[] suchNumsTarget = { 9999, -3, 75 };
                for (int i = 0; i < manyNums.Length; i++)
                {
                    myList.InsertAfter(suchNumsTarget[i], suchNums[i]);
                    Console.WriteLine($"{suchNums[i]} added to list after {suchNumsTarget[i]}.");
                }
                Console.WriteLine();

                myList.Print();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End of test.");
            }
        }
    }
}
