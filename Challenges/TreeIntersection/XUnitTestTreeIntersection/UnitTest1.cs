using System;
using Xunit;
using HappyTrees.Classes;
using HashTables.Classes;
using TreeIntersection;

namespace XUnitTestTreeIntersection
{
    public class UnitTest1
    {
        [Fact]
        public void FindsAllMatchingNodes()
        {
            BinaryTree treeOne = new BinaryTree();
            treeOne.Root = new Node(12);
            treeOne.Root.Left = new Node(0);
            treeOne.Root.Right = new Node(5);
            treeOne.Root.Left.Left = new Node(13);
            treeOne.Root.Left.Right = new Node(-4);
            treeOne.Root.Right.Right = new Node(3);
            treeOne.Root.Right.Right.Left = new Node(25);

            BinaryTree treeTwo = new BinaryTree();
            treeTwo.Root = new Node(7);
            treeTwo.Root.Left = new Node(40);
            treeTwo.Root.Right = new Node(13);   // Intersect
            treeTwo.Root.Left.Left = new Node(22);
            treeTwo.Root.Left.Right = new Node(-10);
            treeTwo.Root.Right.Right = new Node(3);  // Intersect
            treeTwo.Root.Left.Right.Left = new Node(-4); // Intersect
            treeTwo.Root.Right.Right.Left = new Node(111);
            treeTwo.Root.Right.Right.Right = new Node(25);   // Intersect

            object[] result = Program.TreeIntersection(treeOne, treeTwo);
            object[] expected = { 13, 3, -4, 25 };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TreesHaveNoMatchingNodes()
        {
            BinaryTree treeOne = new BinaryTree();
            treeOne.Root = new Node(12);
            treeOne.Root.Left = new Node(0);
            treeOne.Root.Right = new Node(5);
            treeOne.Root.Left.Left = new Node(13);
            treeOne.Root.Left.Right = new Node(-4);
            treeOne.Root.Right.Right = new Node(3);
            treeOne.Root.Right.Right.Left = new Node(25);

            BinaryTree treeTwo = new BinaryTree();
            treeTwo.Root = new Node(42);
            treeTwo.Root.Left = new Node(44);
            treeTwo.Root.Right = new Node(-9);   
            treeTwo.Root.Left.Left = new Node(101);
            treeTwo.Root.Left.Right = new Node(33);
            treeTwo.Root.Right.Right = new Node(98);  
            treeTwo.Root.Left.Right.Left = new Node(21); 
            treeTwo.Root.Right.Right.Left = new Node(74);
            treeTwo.Root.Right.Right.Right = new Node(66);   

            object[] result = Program.TreeIntersection(treeOne, treeTwo);

            Assert.Empty(result);
        }

        [Fact]
        public void AllNodeValuesMatch()
        {
            BinaryTree treeOne = new BinaryTree();
            treeOne.Root = new Node(1);
            treeOne.Root.Left = new Node(2);
            treeOne.Root.Right = new Node(3);
            treeOne.Root.Left.Left = new Node(4);
            treeOne.Root.Left.Right = new Node(5);
            treeOne.Root.Right.Right = new Node(6);

            BinaryTree treeTwo = new BinaryTree();
            treeTwo.Root = new Node(3);
            treeTwo.Root.Left = new Node(1);
            treeTwo.Root.Right = new Node(2);
            treeTwo.Root.Left.Left = new Node(5);
            treeTwo.Root.Left.Right = new Node(6);
            treeTwo.Root.Right.Right = new Node(4);

            object[] result = Program.TreeIntersection(treeOne, treeTwo);

            Assert.Equal(6, result.Length);
        }

        [Fact]
        public void EmptyTreesReturnNull()
        {
            BinaryTree treeOne = new BinaryTree();
            BinaryTree treeTwo = new BinaryTree();

            object[] result = Program.TreeIntersection(treeOne, treeTwo);

            Assert.Null(result);
        }
    }
}
