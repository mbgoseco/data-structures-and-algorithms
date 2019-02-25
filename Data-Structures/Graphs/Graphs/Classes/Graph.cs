using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph
    {
        public List<Vertex> Vertices { get; set; } = new List<Vertex>();

        public Object AddNode(Object value)
        {
            Vertex node = new Vertex(value);
            Vertices.Add(node);
            return node;
        }

        public void AddEdge(Vertex vertA, Vertex vertB, int weight)
        {
            Edge edgeA = new Edge(vertB, weight);
            Vertices.Find(v => v.Value == vertA.Value).Edge.Add(edgeA);

            Edge edgeB = new Edge(vertA, weight);
            Vertices.Find(v => v.Value == vertB.Value).Edge.Add(edgeB);
        }

        public List<Vertex> GetNodes()
        {
            return Vertices;
        }

        public List<Edge> GetNeighbors(Vertex node)
        {
            return Vertices.Find(v => v.Value == node.Value).Edge;
        }

        public int Size()
        {
            return Vertices.Count;
        }
    }
}
