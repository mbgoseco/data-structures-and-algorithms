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
                    Console.WriteLine($"{num} added to linked list.");
                }
                Console.WriteLine();

                Console.WriteLine($"Does 99 exist on the linked list?   {(myList.Includes(99) ? "Yes" : "No")}");
                Console.WriteLine($"Does 42 exist on the linked list?   {(myList.Includes(42) ? "Yes" : "No")}");
                Console.WriteLine($"Does 777 exist on the linked list?   {(myList.Includes(777) ? "Yes" : "No")}");
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
