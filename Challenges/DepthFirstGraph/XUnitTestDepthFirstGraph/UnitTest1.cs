using System;
using Xunit;
using DepthFirstGraph;
using Graphs.Classes;
using System.Collections.Generic;

namespace XUnitTestDepthFirstGraph
{
    public class UnitTest1
    {
        [Fact]
        public void GraphReturnsPreOrderList()
        {
            Graph graph = new Graph();
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");
            Vertex E = new Vertex("E");
            Vertex F = new Vertex("F");
            Vertex G = new Vertex("G");
            Vertex H = new Vertex("H");
            Vertex I = new Vertex("I");
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");
            graph.AddNode("H");
            graph.AddNode("I");
            graph.AddEdge(A, B, 5);
            graph.AddEdge(A, C, 5);
            graph.AddEdge(B, D, 5);
            graph.AddEdge(B, E, 5);
            graph.AddEdge(C, F, 5);
            graph.AddEdge(C, G, 5);
            graph.AddEdge(F, G, 5);
            graph.AddEdge(F, H, 5);
            graph.AddEdge(G, H, 5);
            graph.AddEdge(H, I, 5);

            List<Vertex> list = Program.DepthFirst(graph);
            List<object> result = new List<object>();
            foreach (Vertex node in list)
            {
                result.Add(node.Value);
            }
            List<object> expected = new List<object> { "A", "B", "D", "E", "C", "F", "G", "H", "I" };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SingleNodeGraphReturnsRoot()
        {
            Graph graph = new Graph();
            graph.AddNode("A");

            List<Vertex> result = Program.DepthFirst(graph);

            Assert.Equal("A", result[0].Value);
        }

        [Fact]
        public void EmptyGraphReturnsNull()
        {
            Graph graph = new Graph();

            List<Vertex> result = Program.DepthFirst(graph);

            Assert.Null(result);
        }
    }
}
