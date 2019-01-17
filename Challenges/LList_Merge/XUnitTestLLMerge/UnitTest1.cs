using System;
using Xunit;
using LinkedLists.Classes;
using LList_Merge;

namespace XUnitTestLLMerge
{
    public class UnitTest1
    {
        [Fact]
        public void ListOneBigger()
        {
            LinkedList testListOne = new LinkedList();
            testListOne.Insert(2);
            testListOne.Insert(3);
            testListOne.Insert(4);
            testListOne.Insert(5);
            testListOne.Insert(6);

            LinkedList testListTwo = new LinkedList();
            testListTwo.Insert(11);
            testListTwo.Insert(12);

            testListOne.Current = testListOne.Head;
            testListTwo.Current = testListTwo.Head;

            testListOne = Program.MergeLists(testListOne, testListTwo);

            string result = "";

            testListOne.Current = testListOne.Head;
            testListTwo.Current = testListTwo.Head;

            while (testListOne.Current.Next != null)
            {
                result += $"{testListOne.Current.Value}, ";
                testListOne.Current = testListOne.Current.Next;
            }
            result += $"{testListOne.Current.Value}";

            Assert.Equal("6, 12, 5, 11, 4, 3, 2", result);
        }

        [Fact]
        public void ListTwoBigger()
        {
            LinkedList testListOne = new LinkedList();
            testListOne.Insert(9);
            testListOne.Insert(8);
           

            LinkedList testListTwo = new LinkedList();
            testListTwo.Insert(1);
            testListTwo.Insert(2);
            testListOne.Insert(3);
            testListOne.Insert(4);

            testListOne.Current = testListOne.Head;
            testListTwo.Current = testListTwo.Head;

            testListOne = Program.MergeLists(testListOne, testListTwo);

            string result = "";

            testListOne.Current = testListOne.Head;
            testListTwo.Current = testListTwo.Head;

            while (testListOne.Current.Next != null)
            {
                result += $"{testListOne.Current.Value}, ";
                testListOne.Current = testListOne.Current.Next;
            }
            result += $"{testListOne.Current.Value}";

            Assert.Equal("8, 4, 9, 3, 2, 1", result);
        }

        [Fact]
        public void OneNodeEach()
        {
            LinkedList testListOne = new LinkedList();
            testListOne.Insert(9);


            LinkedList testListTwo = new LinkedList();
            testListTwo.Insert(1);

            testListOne.Current = testListOne.Head;
            testListTwo.Current = testListTwo.Head;

            testListOne = Program.MergeLists(testListOne, testListTwo);

            string result = "";

            testListOne.Current = testListOne.Head;
            testListTwo.Current = testListTwo.Head;

            while (testListOne.Current.Next != null)
            {
                result += $"{testListOne.Current.Value}, ";
                testListOne.Current = testListOne.Current.Next;
            }
            result += $"{testListOne.Current.Value}";

            Assert.Equal("9, 1", result);
        }
    }
}
