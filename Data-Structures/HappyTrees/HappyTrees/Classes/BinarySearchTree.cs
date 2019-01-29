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
                Add(Root, node.Value);
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
        public Node Add(Node root, object value)
        {
            try
            {
                Node node = new Node(value);
                
                if (Root == null)
                {
                    Root = node;
                    return node;
                }

                Node parent = null;

                while (root != null)
                {
                    parent = root;
                    if ((int)value < (int)root.Value)
                    {
                        root = root.Left;
                    }
                    else
                    {
                        root = root.Right;
                    }
                }

                if ((int)value <= (int)parent.Value)
                {
                    parent.Left = node;
                }
                else
                {
                    parent.Right = node;
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
        /// <param name="value">Target node value to search for</param>
        /// <returns>True if found, false if not</returns>
        public bool Contains(int value)
        {
            try
            {
                if ((int)Root.Value == (int)value) { return true; }

                while (Root != null)
                {
                    if ((int)Root.Value == (int)value)
                    {
                        return true;
                    }
                    else if ((int)value < (int)Root.Value)
                    {
                        Root = Root.Left;
                    }
                    else if ((int)value > (int)Root.Value)
                    {
                        Root = Root.Right;
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
