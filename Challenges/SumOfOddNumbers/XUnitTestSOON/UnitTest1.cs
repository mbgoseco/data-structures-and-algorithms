using System;
using Xunit;
using System.Collections.Generic;
using HappyTrees.Classes;
using SumOfOddNumbers;

namespace XUnitTestSOON
{
    public class UnitTest1
    {
        [Fact]
        public void BinaryTreeReturnsThrityThree()
        {
            Node node = new Node(5);
            node.Left = new Node(2);
            node.Right = new Node(4);
            node.Left.Left = new Node(6);
            node.Left.Right = new Node(11);
            node.Right.Right = new Node(9);
            node.Left.Left.Right = new Node(7);
            node.Right.Right.Left = new Node(1);

            int result = Program.SumOfOddNodes(node);

            Assert.Equal(33, result);
        }

        [Fact]
        public void OneNodeTreeOdd()
        {
            Node node = new Node(5);

            int result = Program.SumOfOddNodes(node);

            Assert.Equal(5, result);
        }

        [Fact]
        public void TreeWithEmptyNode()
        {
            Node node = new Node();
            
            Assert.Throws<NullReferenceException>(() => Program.SumOfOddNodes(node));
        }
    }
}
