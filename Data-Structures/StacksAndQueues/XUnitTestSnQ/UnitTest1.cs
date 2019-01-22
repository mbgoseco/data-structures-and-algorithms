using System;
using Xunit;
using StacksAndQueues;
using StacksAndQueues.Classes;

namespace XUnitTestSnQ
{
    public class UnitTest1
    {
        [Fact]
        public void MakeNewNodes()
        {
            Node one = new Node(1);
            Assert.Equal(1, (int)one.Value);

            Node two = new Node(2);
            Assert.Equal(2, (int)two.Value);

            Node three = new Node(3);
            Assert.Equal(3, (int)three.Value);
        }

        [Fact]
        public void NewNodePushesToTop()
        {
            Node node = new Node(0);
            Stack test = new Stack(node);

            test.Push(1);
            Assert.True(test.Top.Value == 1);

            test.Push(3);
            Assert.True(test.Top.Value == 3);

            test.Push(5);
            Assert.True(test.Top.Value == 5);
        }

        [Fact]
        public void PopsGivesTopNodeValue()
        {
            Node node = new Node(2);
            Stack test = new Stack(node);
            test.Push(4);
            test.Push(6);
            test.Push(8);


            Assert.Equal(8, (int)test.Pop());

            Assert.Equal(6, (int)test.Pop());

            Assert.Equal(4, (int)test.Pop());
        }

        [Fact]
        public void PeekAlwaysShowsTop()
        {
            Stack test = new Stack();
            test.Push(11);
            test.Push(22);
            test.Push(33);
            test.Push(44);

            Assert.Equal(44, (int)test.Peek());

            test.Pop();

            Assert.Equal(33, (int)test.Peek());

            test.Pop();

            Assert.Equal(22, (int)test.Peek());
        }

        [Fact]
        public void EnqueueQueuesInOrder()
        {
            Node node = new Node(10);
            Queue q = new Queue(node);

            q.Enqueue(20);
            Assert.Equal(20, (int)q.Rear.Value);

            q.Enqueue(30);
            Assert.Equal(30, (int)q.Rear.Value);

            q.Enqueue(40);
            Assert.Equal(40, (int)q.Rear.Value);
        }

        [Fact]
        public void DequeueAlwaysGivesFrontValue()
        {
            Node node = new Node(5);
            Queue q = new Queue(node);
            q.Enqueue(4);
            q.Enqueue(3);
            q.Enqueue(2);
            q.Enqueue(1);

            Assert.Equal(5, (int)q.Dequeue());
            Assert.Equal(4, (int)q.Dequeue());
            Assert.Equal(3, (int)q.Dequeue());
        }

        [Fact]
        public void PeekAlwaysShowsFront()
        {
            Node node = new Node(9);
            Queue q = new Queue(node);
            q.Enqueue(10);
            q.Enqueue(11);

            Assert.Equal(9, (int)q.Peek());

            q.Dequeue();

            Assert.Equal(10, (int)q.Peek());

            q.Dequeue();

            Assert.Equal(11, (int)q.Peek());
        }
    }
}
