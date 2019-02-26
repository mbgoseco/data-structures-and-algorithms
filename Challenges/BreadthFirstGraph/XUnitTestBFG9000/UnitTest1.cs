using System;
using Xunit;
using BreadthFirstGraph;
using Graphs.Classes;
using System.Collections.Generic;

namespace XUnitTestBFG9000
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnRouteAtoG()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");
            Vertex E = new Vertex("E");
            Vertex F = new Vertex("F");
            Vertex G = new Vertex("G");
            graph.AddEdge(A, B, 15);
            graph.AddEdge(A, C, 7);
            graph.AddEdge(A, D, 6);
            graph.AddEdge(B, E, 10);
            graph.AddEdge(C, E, 80);
            graph.AddEdge(D, E, 74);
            graph.AddEdge(E, F, 9);
            graph.AddEdge(F, G, 44);

            List<Vertex> list = graph.BreadthFirst(A);
            object[] result = new object[7];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = list[i].Value;
            }
            object[] expected = { "A", "B", "C", "D", "E", "F", "G" };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanReturnSelfPointingEdge()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            Vertex A = new Vertex("A");
            graph.AddEdge(A, A, 1);

            List<Vertex> result = graph.BreadthFirst(A);

            Assert.Equal("A", result[0].Edge[0].Neighbor.Value);
        }

        [Fact]
        public void CanReturnEdgelessNode()
        {
            Graph graph = new Graph();
            graph.AddNode("Edgeless");
            Vertex edgelessNode = new Vertex("Edgeless");

            List<Vertex> result = graph.BreadthFirst(edgelessNode);

            Assert.Equal("Edgeless", result[0].Value);
        }
    }
}
