using System;
using HappyTrees.Classes;

namespace MaxVaue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(12);
            node.Left = new Node(0);
            node.Right = new Node(5);
            node.Left.Left = new Node(13);
            node.Left.Right = new Node(-4);
            node.Right.Right = new Node(3);
            node.Right.Right.Left = new Node(25);

            Console.WriteLine("             12             ");
            Console.WriteLine("             / \\           ");
            Console.WriteLine("            0   5           ");
            Console.WriteLine("           / \\   \\        ");
            Console.WriteLine("          13  -4  3         ");
            Console.WriteLine("                 /          ");
            Console.WriteLine("                25          ");
            Console.WriteLine("                            ");
            Console.WriteLine($"Maximum node value is: {FindMaxValue(node)}");
            Console.WriteLine();
        }

        /// <summary>
        /// Find the maximum node value of a given binary tree by recusively storing each root node value of its left and right child and comparing it to their parent node after leaving the call stack, then storing the greater value until finally returning the last max value.
        /// </summary>
        /// <param name="root">Root node of binary tree</param>
        /// <returns>Maximum node value</returns>
        public static int FindMaxValue(Node root)
        {
            int max = int.MinValue;

            try
            {
                if (root == null)
                {
                    return max;
                }

                max = (int)root.Value;

                int leftMax = FindMaxValue(root.Left);
                int rightMax = FindMaxValue(root.Right);

                if (leftMax > max)
                {
                    max = leftMax;
                }
                if (rightMax > max)
                {
                    max = rightMax;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return max;
        }
    }
}
