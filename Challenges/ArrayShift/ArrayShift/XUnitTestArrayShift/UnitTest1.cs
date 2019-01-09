using System;
using Xunit;
using ArrayShift;

namespace XUnitTestArrayShift
{
    public class UnitTest1
    {
        [Fact]
        public void ShiftsToMiddleEven()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int mid = 0;
            int[] result = { 1, 2, 3, 0, 4, 5, 6 };
            Assert.Equal(result, Program.InsertShiftArray(arr, mid));
        }

        [Fact]
        public void ShiftsToMiddleOdd()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int mid = 0;
            int[] result = { 1, 2, 3, 0, 4, 5 };
            Assert.Equal(result, Program.InsertShiftArray(arr, mid));
        }

        [Fact]
        public void ShiftsToMiddleSingle()
        {
            int[] arr = { 1 };
            int mid = 0;
            int[] result = { 1, 0 };
            Assert.Equal(result, Program.InsertShiftArray(arr, mid));
        }
    }
}
