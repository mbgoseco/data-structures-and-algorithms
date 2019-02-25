using System;
using Xunit;
using Graphs;
using Graphs.Classes;
using System.Collections.Generic;

namespace XUnitTestGraphs
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNodeToGraph()
        {
            Graph graph = new Graph();

            Vertex node = (Vertex)graph.AddNode("A");

            Assert.Contains(node, graph.Vertices);
        }

        [Fact]
        public void EdgeCanBeAddedToGraph()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            Vertex B = (Vertex)graph.AddNode("B");

            graph.AddEdge(A, B, 15);
            Vertex neighbor = graph.Vertices.Find(v => v.Value == "A").Edge.Find(e => e.Neighbor == B).Neighbor;

            Assert.Equal(B, neighbor);
        }

        [Fact]
        public void CanGetGraphNodeList()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");

            var list = graph.GetNodes();

            Assert.IsType<List<Vertex>>(list);
        }
    }
}
