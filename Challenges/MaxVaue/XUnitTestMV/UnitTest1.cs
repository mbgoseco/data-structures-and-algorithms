using System;
using Xunit;
using MaxVaue;
using HappyTrees.Classes;

namespace XUnitTestMV
{
    public class UnitTest1
    {
        [Fact]
        public void DuplicateMaxNodes()
        {
            Node node = new Node(11);
            node.Left = new Node(13);
            node.Right = new Node(-2);
            node.Left.Left = new Node(13);
            node.Left.Right = new Node(8);
            node.Right.Right = new Node(13);
            node.Right.Right.Left = new Node(10);

            int result = Program.FindMaxValue(node);

            Assert.Equal(13, result);
        }

        [Fact]
        public void LastNodeIsMax()
        {
            Node node = new Node(11);
            node.Left = new Node(1);
            node.Right = new Node(-2);
            node.Left.Left = new Node(22);
            node.Left.Right = new Node(8);
            node.Right.Right = new Node(13);
            node.Right.Right.Left = new Node(75);

            int result = Program.FindMaxValue(node);

            Assert.Equal(75, result);
        }

        [Fact]
        public void SingleNodeIsMax()
        {
            Node node = new Node(7);

            int result = Program.FindMaxValue(node);

            Assert.Equal(7, result);
        }
    }
}
