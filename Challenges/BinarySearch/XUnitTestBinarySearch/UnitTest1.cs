using System;
using Xunit;
using BinarySearch;

namespace XUnitTestBinarySearch
{
    public class UnitTest1
    {
        [Fact]
        public void KeyAtStartEven()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.Equal(0, (int)Program.BinarySearch(arr, 1));
        }
        [Fact]
        public void KeyAtEndOdd()
        {
            int[] arr = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 100, 111 };
            Assert.Equal(10, (int)Program.BinarySearch(arr, 111));
        }
        [Fact]
        public void KeyInBetween()
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Assert.Equal(3, (int)Program.BinarySearch(arr, 40));
        }
        [Fact]
        public void KeyNotInArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Assert.Equal(-1, (int)Program.BinarySearch(arr, 21));
        }
    }
}
