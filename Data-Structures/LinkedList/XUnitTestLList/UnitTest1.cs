using System;
using Xunit;
using LinkedLists.Classes;

namespace XUnitTestLList
{
    public class UnitTest1
    {
        // Tests that property setters of Insert() are correct
        [Fact]
        public void NodeValueIsEight()
        {
            LinkedList testList = new LinkedList();

            testList.Insert(8);

            Assert.True(testList.Head.Value == 8);
        }
        [Fact]
        public void LastInsertIsHead()
        {
            LinkedList testList = new LinkedList();

            testList.Insert(4);
            testList.Insert(2);

            bool isHead = testList.Head.Value == 2;

            Assert.True(isHead);
        }
        [Fact]
        public void NodeHasNoCurrent()
        {
            LinkedList testList = new LinkedList();

            testList.Insert(1);

            bool current = testList.Current == null;

            Assert.True(current);
        }

        // Test if the Includes() method propery detects a given value
        [Fact]
        public void ValueIsInList()
        {
            LinkedList testList = new LinkedList();

            testList.Insert(5);
            testList.Insert(6);
            testList.Insert(7);
            testList.Insert(8);

            bool isFound = testList.Includes(7);

            Assert.True(isFound);
        }
        [Fact]
        public void ValueNotInList()
        {
            LinkedList testList = new LinkedList();

            testList.Insert(1);
            testList.Insert(2);
            testList.Insert(3);
            testList.Insert(4);

            bool isFound = testList.Includes(8);

            Assert.False(isFound);
        }

        // Tests the Append() method
        [Fact]
        public void AppendToPopulatedList()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(1);
            testList.Insert(2);
            testList.Insert(3);

            testList.Append(25);

            testList.Current = testList.Head;
            while (testList.Current.Next != null)
            {
                testList.Current = testList.Current.Next;
            }

            Assert.True(testList.Current.Value == 25);
        }
        [Fact]
        public void AppendToEmptyList()
        {
            LinkedList testList = new LinkedList();

            testList.Append(10);

            Assert.True(testList.Head.Value == 10);
        }

        // Tests the InsertBefore() method
        [Fact]
        public void InsertsToMiddle()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(3);
            testList.Insert(2);
            testList.Insert(-2);
            testList.Insert(-3);

            testList.InsertBefore(2, 0);

            testList.Current = testList.Head;
            testList.Current = testList.Current.Next;
            testList.Current = testList.Current.Next;

            Assert.True(testList.Current.Value == 0);
            Assert.True(testList.Current.Next.Value == 2);
        }
        [Fact]
        public void InsertsBeforeLast()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(8);
            testList.Insert(7);
            testList.Insert(6);
            testList.Insert(5);

            testList.InsertBefore(8, -1);

            testList.Current = testList.Head;
            testList.Current = testList.Current.Next;
            testList.Current = testList.Current.Next;
            testList.Current = testList.Current.Next;

            Assert.True(testList.Current.Value == -1);
            Assert.True(testList.Current.Next.Value == 8);
        }

        // Tests the InsertAfter() method
        [Fact]
        public void InsertsAfterHead()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(11);
            testList.Insert(22);
            testList.Insert(33);

            testList.InsertAfter(33, 5);

            testList.Current = testList.Head;

            Assert.True(testList.Current.Value == 33);
            Assert.True(testList.Current.Next.Value == 5);
        }
        [Fact]
        public void InsertsAfteLast()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(44);
            testList.Insert(55);
            testList.Insert(66);
            testList.Insert(77);

            testList.InsertAfter(44, 0);

            testList.Current = testList.Head;
            while (testList.Current.Next != null)
            {
                testList.Current = testList.Current.Next;
            }

            Assert.True(testList.Current.Value == 0);
        }
    }
}
