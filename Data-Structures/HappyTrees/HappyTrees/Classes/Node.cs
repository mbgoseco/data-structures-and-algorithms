using System;
using System.Collections.Generic;
using System.Text;

namespace HappyTrees.Classes
{
    public class Node
    {
        public object Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node()
        {

        }

        public Node(object value)
        {
            Value = value;
        }
    }
}
