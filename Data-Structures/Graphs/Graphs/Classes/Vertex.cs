using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Vertex
    {
        public List<Edge> Edge { get; set; } = new List<Edge>();
        public Object Value { get; set; }

        public Vertex(Object value)
        {
            Value = value;
        }
    }
}
