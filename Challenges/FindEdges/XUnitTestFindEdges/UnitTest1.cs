using System;
using Xunit;
using FindEdges;
using Graphs.Classes;

namespace XUnitTestFindEdges
{
    public class UnitTest1
    {
        [Fact]
        public void PathOfManyCitiesReturnsTrue()
        {
            Graph graph = new Graph();
            graph.AddNode("Houston");
            graph.AddNode("Seattle");
            graph.AddNode("Los Angeles");
            graph.AddNode("Cookeville");
            graph.AddNode("Riverside");
            Vertex A = new Vertex("Houston");
            Vertex B = new Vertex("Seattle");
            Vertex C = new Vertex("Los Angeles");
            Vertex D = new Vertex("Cookeville");
            Vertex E = new Vertex("Riverside");
            graph.AddEdge(A, B, 50);
            graph.AddEdge(A, C, 32);
            graph.AddEdge(B, C, 110);
            graph.AddEdge(C, D, 99);
            graph.AddEdge(C, E, 159);
            graph.AddEdge(D, E, 75);

            string[] cities = { "Cookeville", "Riverside", "Los Angeles", "Houston", "Seattle" };
            Tuple<bool, int> result = Program.GetEdge(graph, cities);
            Tuple<bool, int> expected = new Tuple<bool, int>(true, 316);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void NoDirectPathReturnsFalse()
        {
            Graph graph = new Graph();
            graph.AddNode("Houston");
            graph.AddNode("Seattle");
            graph.AddNode("Los Angeles");
            graph.AddNode("Cookeville");
            graph.AddNode("Riverside");
            Vertex A = new Vertex("Houston");
            Vertex B = new Vertex("Seattle");
            Vertex C = new Vertex("Los Angeles");
            Vertex D = new Vertex("Cookeville");
            Vertex E = new Vertex("Riverside");
            graph.AddEdge(A, B, 50);
            graph.AddEdge(A, C, 32);
            graph.AddEdge(B, C, 110);
            graph.AddEdge(C, D, 99);
            graph.AddEdge(C, E, 159);
            graph.AddEdge(D, E, 75);

            string[] cities = { "Riverside", "Houston", "Seattle" };
            Tuple<bool, int> result = Program.GetEdge(graph, cities);
            Tuple<bool, int> expected = new Tuple<bool, int>(false, 0);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SingleCityArrayReturnsFalse()
        {
            Graph graph = new Graph();
            graph.AddNode("Houston");
            graph.AddNode("Seattle");
            graph.AddNode("Los Angeles");
            graph.AddNode("Cookeville");
            graph.AddNode("Riverside");
            Vertex A = new Vertex("Houston");
            Vertex B = new Vertex("Seattle");
            Vertex C = new Vertex("Los Angeles");
            Vertex D = new Vertex("Cookeville");
            Vertex E = new Vertex("Riverside");
            graph.AddEdge(A, B, 50);
            graph.AddEdge(A, C, 32);
            graph.AddEdge(B, C, 110);
            graph.AddEdge(C, D, 99);
            graph.AddEdge(C, E, 159);
            graph.AddEdge(D, E, 75);

            string[] cities = { "Seattle" };
            Tuple<bool, int> result = Program.GetEdge(graph, cities);
            Tuple<bool, int> expected = new Tuple<bool, int>(false, 0);

            Assert.Equal(expected, result);
        }
    }
}
