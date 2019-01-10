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
            decimal start = 0, end = arr.Length - 1;    /* Denotes start and end of current binary search bounds.
                                                         Will change after each fork. */
            decimal root = Math.Ceiling((decimal)arr.Length / 2) - 1;  // Sets midpoint and traget index of each search
            while(true)
            {
                if (arr[(int)root] == key)  // Returns index value if key matches current target
                {
                    return (int)root;
                }
                else if (root == start && root == end)  // End of binary search and no matches for key found
                {
                    return -1;
                }
                else if (key < arr[(int)root])  // Sets new target index to midpoint of start and old target, rounded down to start
                {
                    end = (int)root;
                    root = Math.Floor(root / 2);
                    //Console.WriteLine("Went left");
                }
                else if (key > arr[(int)root])  // Sets new target index to midpoint of old target and end, rounded up to end
                {
                    start = (int)root;
                    root = Math.Ceiling((start + end) / 2);
                    //Console.WriteLine("Went right");
                }
            }
        }
    }
}
