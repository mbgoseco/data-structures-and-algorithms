using System;
using System.Collections.Generic;
using HappyTrees.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        public static List<object> ArrayList = new List<object>();

        static void Main(string[] args)
        {
            Node FBTree = new Node(7);
            FBTree.Left = new Node(5);
            FBTree.Left.Left = new Node(2);
            FBTree.Left.Right = new Node(30);
            FBTree.Right = new Node(9);
            FBTree.Right.Left = new Node(8);
            FBTree.Right.Right = new Node(45);

            BinaryTree tree = new BinaryTree(FBTree);

            object[] result = FizzBuzzTree(tree.Root);

            foreach (object i in result)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();
        }

        public static object[] FizzBuzzTree(Node root)
        {

            try
            {
                if ((int)root.Value % 15 == 0)
                {
                    root.Value = "FizzBuzz";
                }
                else if ((int)root.Value % 3 == 0)
                {
                    root.Value = "Fizz";
                }
                else if ((int)root.Value % 5 == 0)
                {
                    root.Value = "Buzz";
                }
                
                ArrayList.Add(root.Value);

                if (root.Left != null)
                {
                    FizzBuzzTree(root.Left);
                }
                if (root.Right != null)
                {
                    FizzBuzzTree(root.Right);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return ArrayList.ToArray();
        }
    }
}
