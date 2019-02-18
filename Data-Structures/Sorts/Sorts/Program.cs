using System;

namespace Sorts
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 7, 4, 1, 9, 8, 3, 2, 10, 6 };
            Console.Write($"Before sort: ");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            InsertionSort(array);
            Console.Write($"After sort: ");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

        }

        /// <summary>
        /// Takes in an unsorted integer array and iterates through the array until finding a value less than its previous element. That lesser value is stored before iterating backwards, stopping when the temp value is lesser than the last passed element, and assigning that temp value in order to the current index.
        /// </summary>
        /// <param name="arr">Array of integers</param>
        /// <returns>Sorted array</returns>
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }

            return arr;
        } 
    }
}
