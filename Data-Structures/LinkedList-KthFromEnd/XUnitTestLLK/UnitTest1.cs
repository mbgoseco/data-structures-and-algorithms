using System;
using Xunit;
using LinkedList_KthFromEnd;
using LinkedLists.Classes;

namespace XUnitTestLLK
{
    public class UnitTest1
    {
        [Fact]
        public void KFoundAtSixthFromEnd()
        {
            int kValue = Program.FindKthFromEnd(6);

            Assert.True(kValue == 3);
        }

        [Fact]
        public void KFoundAtEndOfList()
        {
            int kValue = Program.FindKthFromEnd(0);

            Assert.True(kValue == 9);
        }

        [Fact]
        public void KFoundAtHeadOfList()
        {
            int kValue = Program.FindKthFromEnd(9);

            Assert.True(kValue == 1);
        }
    }
}
