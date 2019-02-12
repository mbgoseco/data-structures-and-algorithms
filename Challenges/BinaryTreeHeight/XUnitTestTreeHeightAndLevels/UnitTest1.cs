using System;
using Xunit;
using BinaryTreeHeight;
using HappyTrees.Classes;

namespace XUnitTestTreeHeightAndLevels
{
    public class UnitTest1
    {
        /// <summary>
        /// Tree height tests
        /// </summary>
        [Fact]
        public void TreeReturnsHeightThree()
        {
            Node node = new Node(5);
            node.Left = new Node(2);
            node.Right = new Node(4);
            node.Left.Left = new Node(6);
            node.Left.Right = new Node(11);
            node.Right.Right = new Node(9);
            node.Left.Left.Right = new Node(7);
            node.Right.Right.Left = new Node(1);

            int result = Program.CalculateBinaryTreeHeight(node);

            Assert.Equal(3, result);
        }

        [Fact]
        public void SingleNodeTreeReturnsZero()
        {
            Node node = new Node(5);

            int result = Program.CalculateBinaryTreeHeight(node);

            Assert.Equal(0, result);
        }

        [Fact]
        public void NullTreeReturnsZeroHeight()
        {
            Node node = null;

            int result = Program.CalculateBinaryTreeHeight(node);

            Assert.Equal(0, result);
        }

        /// <summary>
        /// Tree level tests
        /// </summary>
        [Fact]
        public void TreeReturnsHeightFour()
        {
            Node node = new Node(5);
            node.Left = new Node(2);
            node.Right = new Node(4);
            node.Left.Left = new Node(6);
            node.Left.Right = new Node(11);
            node.Right.Right = new Node(9);
            node.Left.Left.Right = new Node(7);
            node.Right.Right.Left = new Node(1);

            int result = Program.CalculateBinaryTreeLevels(node);

            Assert.Equal(4, result);
        }

        [Fact]
        public void SingleNodeTreeReturnsOne()
        {
            Node node = new Node(5);

            int result = Program.CalculateBinaryTreeLevels(node);

            Assert.Equal(1, result);
        }

        [Fact]
        public void NullTreeReturnsZeroLevels()
        {
            Node node = null;

            int result = Program.CalculateBinaryTreeLevels(node);

            Assert.Equal(0, result);
        }
    }
}
