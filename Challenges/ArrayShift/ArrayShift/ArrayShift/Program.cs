using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oldArr = { 1, 7, 3, 8, 15, };
            int midNum = 5;
            Console.WriteLine($"Old array: [{string.Join(", ", oldArr)}]. Integer to insert to middle: {midNum}");
            int[] result = ArrayShift(oldArr, midNum);
            Console.WriteLine($"New array: [{string.Join(", ", result)}]");

        }

        public static int[] ArrayShift(int[] arr, int midVal)
        {
            int[] newArr = new int[arr.Length + 1];
            decimal mid = Math.Ceiling((decimal)newArr.Length / 2) - 1;
            int counter = 0;

            for (int i = 0; i < newArr.Length; i++)
            {
                if (i == mid && arr.Length % 2 == 0) // If started with even array, add mid value normally
                {
                    newArr[i] = midVal;
                } else if (i == mid && arr.Length % 2 != 0) // if started with odd array, add next value then shift right to add mid value
                {
                    newArr[i] = arr[counter];
                    counter++;
                    i++;
                    newArr[i] = midVal;
                }
                else
                {
                    newArr[i] = arr[counter];
                    counter++;
                }
            }
            return newArr;
        }
    }
}
