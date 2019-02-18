using System;
using Xunit;
using Sorts;

namespace XUnitTestSorts
{
    public class UnitTest1
    {
        [Fact]
        public void UnsortedArrayReturnsSorted()
        {
            int[] array = { 5, 7, 4, 1, 9, 8, 3, 2, 10, 6 };

            int[] result = Program.InsertionSort(array);
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortedArrayReturnsSame()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] result = Program.InsertionSort(array);

            Assert.Equal(array, result);
        }

        [Fact]
        public void BackwardsArrayReturnsSorted()
        {
            int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int[] result = Program.InsertionSort(array);
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Equal(expected, result); ;
        }

        [Fact]
        public void EmptyArrayReturnsEmpty()
        {
            int[] array = { };

            int[] result = Program.InsertionSort(array);
            int[] expected = { };

            Assert.Equal(expected, result); ;
        }

        [Fact]
        public void SingleElementArrayReturnsSame()
        {
            int[] array = { 5 };

            int[] result = Program.InsertionSort(array);
            int[] expected = { 5 };

            Assert.Equal(expected, result); ;
        }
    }
}
