using System;
using System.Collections.Generic;
using Graphs.Classes;

namespace DepthFirstGraph
{
    public class Program
    {
        static void Main(string[] args)
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

            List<Vertex> depthFirstList = DepthFirst(graph);
            Console.Write("Pre-order, depth first list of graph at root node A: ");
            foreach (Vertex node in depthFirstList)
            {
                Console.Write($" {node.Value} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Takes in a graph and returns a list of nodes in pre-order, depth first order.
        /// </summary>
        /// <param name="graph">Adjecency list graph</param>
        /// <returns>List of nodes</returns>
        public static List<Vertex> DepthFirst(Graph graph)
        {
            if (graph.Vertices.Count == 0)
            {
                return null;
            }

            List<Vertex> result = new List<Vertex>();
            Vertex root = graph.Vertices[0];

            result = DepthFirstHelper(graph, result, root);
            return result;
        }

        /// <summary>
        /// Helper method to DepthFirst() that perfoms pre-order, depth first traversal of a graph and adds its nodes to a list.
        /// </summary>
        /// <param name="graph">Adjacency list graph</param>
        /// <param name="list">List collecting nodes in pre-order</param>
        /// <param name="root">Starting node for depth first traversal</param>
        /// <returns>List of nodes</returns>
        public static List<Vertex> DepthFirstHelper(Graph graph, List<Vertex> list, Vertex root)
        {
            root.Visited = true;
            list.Add(root);

            foreach (Edge edge in root.Edge)
            {
                if (!edge.Neighbor.Visited)
                {
                    DepthFirstHelper(graph, list, edge.Neighbor);
                }
            }

            return list;
        }
    }
}
