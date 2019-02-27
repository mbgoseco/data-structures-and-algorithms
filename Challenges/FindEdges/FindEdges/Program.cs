using System;
using System.Collections.Generic;
using Graphs.Classes;

namespace FindEdges
{
    public class Program
    {
        static void Main(string[] args)
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

            string[] cities = { "Seattle", "Los Angeles", "Riverside" };
            Tuple<bool, int> result = GetEdge(graph, cities);

            Console.WriteLine("Is direct flight possible from Seattle to Los Angeles to Riverside? If so how much?");
            Console.WriteLine($"{result.Item1}, ${result.Item2}");
        }

        /// <summary>
        /// Determines if a squeuence of nodes in a graph with values matching an array of cities have edges that directly connect one another.
        /// </summary>
        /// <param name="graph">Graph with nodes named after cities</param>
        /// <param name="cities">Array of city names</param>
        /// <returns>Tuple with boolean result of found path and sum weight of edges</returns>
        public static Tuple<bool, int> GetEdge(Graph graph ,string[] cities)
        {
            bool directPath = false;
            int cost = 0;

            for (int i = 0; i < cities.Length - 1; i++)
            {
                List<Edge> nodeEdges = graph.GetNeighbors(new Vertex(cities[i]));

                if (!nodeEdges.Exists(n => n.Neighbor.Value.ToString() == cities[i + 1]))
                {
                    Tuple<bool, int> result = new Tuple<bool, int>(false, 0);
                    return result;
                }
                else
                {
                    directPath = true;
                    cost += nodeEdges.Find(n => n.Neighbor.Value.ToString() == cities[i + 1]).Weight;
                }
            }

            return new Tuple<bool, int>(directPath, cost);
        }
    }
}
