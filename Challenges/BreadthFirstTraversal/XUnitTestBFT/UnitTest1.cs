using System;
using Xunit;
using BreadthFirstTraversal;
using HappyTrees.Classes;

namespace XUnitTestBFT
{
    public class UnitTest1
    {
        [Fact]
        public void ThirdLevelInOrder()
        {
            Node node = new Node(5);
            node.Left = new Node(2);
            node.Right = new Node(4);
            node.Left.Left = new Node(6);
            node.Left.Right = new Node(11);
            node.Right.Right = new Node(9);
            node.Left.Left.Right = new Node(7);
            node.Right.Right.Left = new Node(1);

            object[] result = Program.BreadthFirst(node);

            Assert.Equal(6, result[3]);
            Assert.Equal(11, result[4]);
            Assert.Equal(9, result[5]);
        }

        [Fact]
        public void FourthLevelInOrder()
        {
            Node node = new Node(5);
            node.Left = new Node(2);
            node.Right = new Node(4);
            node.Left.Left = new Node(6);
            node.Left.Right = new Node(11);
            node.Right.Right = new Node(9);
            node.Left.Left.Right = new Node(7);
            node.Right.Right.Left = new Node(1);

            object[] result = Program.BreadthFirst(node);

            Assert.Equal(7, result[6]);
            Assert.Equal(1, result[7]);
        }

        [Fact]
        public void FifthLevelInOrder()
        {
            Node node = new Node(5);
            node.Left = new Node(2);
            node.Right = new Node(4);
            node.Left.Left = new Node(6);
            node.Left.Right = new Node(11);
            node.Right.Right = new Node(9);
            node.Left.Left.Right = new Node(7);
            node.Right.Right.Left = new Node(1);
            node.Right.Right.Left.Left = new Node(22);
            node.Right.Right.Left.Right = new Node(33);
            node.Left.Left.Right.Left = new Node(44);
            node.Left.Left.Right.Right = new Node(55);

            object[] result = Program.BreadthFirst(node);

            Assert.Equal(44, result[8]);
            Assert.Equal(55, result[9]);
            Assert.Equal(22, result[10]);
            Assert.Equal(33, result[11]);
        }
    }
}
