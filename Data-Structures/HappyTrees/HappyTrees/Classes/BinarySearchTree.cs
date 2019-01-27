using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTrees.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node node)
        {
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                Add(node, node.Value);
            }
        }

        public BinarySearchTree()
        {

        }

        /// <summary>
        /// Traverses the nodes of the binary search tree that are directly greater than of less than the given value. When it reaches a leaf, it creates a new node in the position greater than or less than that leaf.
        /// </summary>
        /// <param name="root">Root of the binary search tree</param>
        /// <param name="value">Value of the node to create in order on the tree</param>
        /// <returns>New node</returns>
        public Node Add(Node root, int value)
        {
            try
            {
                if (root == null)
                {
                    root = new Node(value);
                    Root = root;
                }
                else if (root.Value == value)
                {
                    root.Left = Add(root.Left, value);
                }
                else if (value < root.Value)
                {
                    root.Left = Add(root.Left, value);
                }
                else if (value > root.Value)
                {
                    root.Right = Add(root.Right, value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return root;
        }

        /// <summary>
        /// Searches the tree for a matching node value, traversing left if the target value is less than the node value, or right if the target value is greater than the node value. Returns true is target is found, false if not.
        /// </summary>
        /// <param name="root">Root of the binary search tree</param>
        /// <param name="value">Target node value to search for</param>
        /// <returns>True if found, false if not</returns>
        public bool Contains(Node root, int value)
        {
            try
            {
                if (root.Value == value) { return true; }

                while (root != null)
                {
                    if (root.Value == value)
                    {
                        return true;
                    }
                    else if (value < root.Value)
                    {
                        root = root.Left;
                    }
                    else if (value > root.Value)
                    {
                        root = root.Right;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }
    }
}
