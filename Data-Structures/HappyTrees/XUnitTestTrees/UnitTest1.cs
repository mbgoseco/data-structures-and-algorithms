using System;
using Xunit;
using HappyTrees;
using HappyTrees.Classes;

namespace XUnitTestTrees
{
    public class UnitTest1
    {
        // PreOrder tests
        [Fact]
        public void PreOrderOneToFive()
        {
            BinaryTree test = new BinaryTree();
            Node node = new Node(1);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            object[] result = test.PreOrder(node);

            Assert.Equal(1, result[0]);
            Assert.Equal(2, result[1]);
            Assert.Equal(3, result[2]);
            Assert.Equal(4, result[3]);
            Assert.Equal(5, result[4]);
        }

        [Fact]
        public void PreOrderAllRights()
        {
            BinaryTree test = new BinaryTree();
            Node node = new Node(1);
            node.Right = new Node(2);
            node.Right.Right = new Node(3);
            node.Right.Right.Right = new Node(4);
            node.Right.Right.Right.Right = new Node(5);

            object[] result = test.PreOrder(node);

            Assert.Equal(1, result[0]);
            Assert.Equal(2, result[1]);
            Assert.Equal(3, result[2]);
            Assert.Equal(4, result[3]);
            Assert.Equal(5, result[4]);
        }

        [Fact]
        public void PreOrderOneNode()
        {
            BinaryTree test = new BinaryTree();
            Node node = new Node(1);

            object[] result = test.PreOrder(node);

            Assert.Equal(1, result[0]);
        }

        // InOrder tests
        [Fact]
        public void InOrderOneToFive()
        {
            BinaryTree test = new BinaryTree();
            Node node = new Node(1);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            object[] result = test.InOrder(node);

            Assert.Equal(3, result[0]);
            Assert.Equal(2, result[1]);
            Assert.Equal(4, result[2]);
            Assert.Equal(1, result[3]);
            Assert.Equal(5, result[4]);
        }

        [Fact]
        public void InOrderFarLeftsAndRights()
        {
            BinaryTree test = new BinaryTree();
            Node node = new Node(1);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Left.Left = new Node(4);
            node.Right = new Node(5);
            node.Right.Right = new Node(6);
            node.Right.Right.Right = new Node(7);


            object[] result = test.InOrder(node);

            Assert.Equal(4, result[0]);
            Assert.Equal(3, result[1]);
            Assert.Equal(2, result[2]);
            Assert.Equal(1, result[3]);
            Assert.Equal(5, result[4]);
            Assert.Equal(6, result[5]);
            Assert.Equal(7, result[6]);
        }

        [Fact]
        public void InOrderOneNode()
        {
            BinaryTree test = new BinaryTree();
            Node node = new Node(1);

            object[] result = test.InOrder(node);

            Assert.Equal(1, result[0]);
        }

        // PostOrder Tests
        [Fact]
        public void PostOrderOneToFive()
        {
            BinaryTree test = new BinaryTree();
            Node node = new Node(1);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);

            object[] result = test.PostOrder(node);

            Assert.Equal(3, result[0]);
            Assert.Equal(4, result[1]);
            Assert.Equal(2, result[2]);
            Assert.Equal(5, result[3]);
            Assert.Equal(1, result[4]);
        }

        [Fact]
        public void PostOrderZigZag()
        {
            BinaryTree test = new BinaryTree();
            Node node = new Node(1);
            node.Left = new Node(2);
            node.Left.Right = new Node(3);
            node.Left.Right.Left = new Node(4);
            node.Left.Right.Left.Right = new Node(5);

            object[] result = test.PostOrder(node);

            Assert.Equal(5, result[0]);
            Assert.Equal(4, result[1]);
            Assert.Equal(3, result[2]);
            Assert.Equal(2, result[3]);
            Assert.Equal(1, result[4]);
        }

        [Fact]
        public void PostOrderOneNode()
        {
            BinaryTree test = new BinaryTree();
            Node node = new Node(1);

            object[] result = test.PostOrder(node);

            Assert.Equal(1, result[0]);
        }

        // BST Add tests
        [Fact]
        public void AddTwoBetweenOneAndThree()
        {
            Node node = new Node(3);
            node.Left = new Node(1);
            BinarySearchTree test = new BinarySearchTree(node);

            test.Add(node, 2);

            Assert.Equal(2, test.Root.Left.Right.Value);
        }

        [Fact]
        public void AddOneToEmptyTree()
        {
            BinarySearchTree test = new BinarySearchTree();

            test.Add(new Node(), 1);

            Assert.Equal(1, test.Root.Value);
        }

        [Fact]
        public void AddDupesToLeft()
        {
            BinarySearchTree test = new BinarySearchTree();

            test.Add(new Node(), 5);
            test.Add(test.Root, 2);
            test.Add(test.Root, 7);
            test.Add(test.Root, 3);
            test.Add(test.Root, 3);

            Assert.Equal(3, test.Root.Left.Right.Value);
            Assert.Equal(3, test.Root.Left.Right.Left.Value);
        }

        // BST Contains tests
        [Fact]
        public void FoundOnRightSide()
        {
            BinarySearchTree test = new BinarySearchTree();

            test.Add(test.Root, 5);
            test.Add(test.Root, 2);
            test.Add(test.Root, 7);
            test.Add(test.Root, 3);
            test.Add(test.Root, 4);
            test.Add(test.Root, 9);
            test.Add(test.Root, 11);
            test.Add(test.Root, 8);

            bool result = test.Contains(8);

            Assert.True(result);
        }

        [Fact]
        public void NotFoundInTree()
        {
            BinarySearchTree test = new BinarySearchTree();

            test.Add(test.Root, 5);
            test.Add(test.Root, 2);
            test.Add(test.Root, 7);
            test.Add(test.Root, 3);
            test.Add(test.Root, 4);
            test.Add(test.Root, 9);
            test.Add(test.Root, 11);
            test.Add(test.Root, 8);

            bool result = test.Contains(6);

            Assert.False(result);
        }

        [Fact]
        public void FoundOnFirstNode()
        {
            BinarySearchTree test = new BinarySearchTree();

            test.Add(test.Root, 5);
            test.Add(test.Root, 2);
            test.Add(test.Root, 7);
            test.Add(test.Root, 3);
            test.Add(test.Root, 4);
            test.Add(test.Root, 9);
            test.Add(test.Root, 11);
            test.Add(test.Root, 8);

            bool result = test.Contains(5);

            Assert.True(result);
        }
    }
}
