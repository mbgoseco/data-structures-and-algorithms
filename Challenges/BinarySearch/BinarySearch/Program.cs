using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArr = { 12, 34, 56, 78, 90, 123, 234, 345, 456, 567 };
            int key = 123;
            int result = BinarySearch(sortedArr, key);
            Console.WriteLine($"Array: [{string.Join(", ", sortedArr)}]   Key: {key}");
            if (result == -1)
            {
                Console.WriteLine($"Key not found in array (returned {result})");
            }
            else
            {
                Console.WriteLine($"Key found in array index {result}");
            }
        }

        public static int BinarySearch(int[] arr, int key)
        {
            decimal start = 0, end = arr.Length - 1;
            decimal root = Math.Ceiling((decimal)arr.Length / 2) - 1;
            while(true)
            {
                if (arr[(int)root] == key)
                {
                    return (int)root;
                }
                else if (root == start && root == end)
                {
                    return -1;
                }
                else if (key < arr[(int)root])
                {
                    end = (int)root;
                    root = Math.Floor(root / 2);
                    //Console.WriteLine("Went left");
                }
                else if (key > arr[(int)root])
                {
                    start = (int)root;
                    root = Math.Ceiling((start + end) / 2);
                    //Console.WriteLine("Went right");
                }
            }
        }
    }
}
