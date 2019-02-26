using System;
using System.Collections.Generic;
using Graphs.Classes;

namespace BreadthFirstGraph
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");
            Vertex E = new Vertex("E");
            Vertex F = new Vertex("F");
            graph.AddEdge(A, B, 15);
            graph.AddEdge(A, C, 7);
            graph.AddEdge(B, D, 6);
            graph.AddEdge(C, E, 10);
            graph.AddEdge(D, E, 80);
            graph.AddEdge(D, F, 74);
            graph.AddEdge(E, F, 9999);

            // Get adjacency list from A to F
            List<Vertex> path = graph.BreadthFirst(A);
            Console.Write("Adjecency list of node A: ");
            foreach (Vertex node in path)
            {
                Console.Write($" {node.Value} ");
            }
            Console.WriteLine();
        }
    }
}
