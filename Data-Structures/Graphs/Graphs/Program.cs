using System;
using System.Collections.Generic;
using Graphs.Classes;

namespace Graphs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Make some nodes
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");

            // Count the nodes
            Console.WriteLine($"Number of nodes in graph: {graph.Size()}");

            // Make some edges
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            graph.AddEdge(A, B, 15);
            graph.AddEdge(A, C, 7);

            // Get neighbors of node
            Console.WriteLine("Neighbors and weights of node A:");
            List<Edge> resultA = graph.GetNeighbors(A);
            foreach (Edge edge in resultA)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }
            Console.WriteLine("Neighbors and weights of node C:");
            List<Edge> resultC = graph.GetNeighbors(C);
            foreach (Edge edge in resultC)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }

            // Add some more nodes
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");

            // Get list of nodes in graph
            List<Vertex> nodes = graph.GetNodes();
            Console.Write("List of nodes in graph: ");
            foreach (Vertex node in nodes)
            {
                Console.Write($" {node.Value} ");
            }
            Console.WriteLine();
        }
    }
}
