using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTrees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<int> ArrayList = new List<int>();

        public BinaryTree(Node node)
        {
            Root = node;
        }

        public BinaryTree()
        {

        }

        /// <summary>
        /// Recursively stores the node values of the tree BEFORE traversing to the next and returns them as an array.
        /// </summary>
        /// <param name="root">Root node of binary tree</param>
        /// <returns>Array of node values</returns>
        public int[] PreOrder(Node root)
        {
            try
            {
                ArrayList.Add(root.Value);

                if (root.Left != null)
                {
                    PreOrder(root.Left);
                }
                if (root.Right != null)
                {
                    PreOrder(root.Right);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return ArrayList.ToArray();
        }

        /// <summary>
        /// Stores the node values of the tree, starting at the left most leaf and recursively adding back upward, then adding as it goes down the right side, and returns them as an array.
        /// </summary>
        /// <param name="root">Root node of binary tree</param>
        /// <returns>Array of node values</returns>
        public int[] InOrder(Node root)
        {
            try
            {
                if (root.Left != null)
                {
                    InOrder(root.Left);
                }

                ArrayList.Add(root.Value);

                if (root.Right != null)
                {
                    InOrder(root.Right);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return ArrayList.ToArray();
        }

        /// <summary>
        /// Stores the node values of the tree, returning the left side of the tree from the bottom up, then the right side from the bottom up, then finally the top root, then returns them as an array.
        /// </summary>
        /// <param name="root">Root node of binary tree</param>
        /// <returns>Array of node values</returns>
        public int[] PostOrder(Node root)
        {
            try
            {
                if (root.Left != null)
                {
                    PostOrder(root.Left);
                }
                if (root.Right != null)
                {
                    PostOrder(root.Right);
                }

                ArrayList.Add(root.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ArrayList.ToArray();
        }
    }
}
