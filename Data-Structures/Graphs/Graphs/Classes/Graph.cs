using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph
    {
        public List<Vertex> Vertices { get; set; } = new List<Vertex>();

        /// <summary>
        /// Adds a node to the graph.
        /// </summary>
        /// <param name="value">Value property of node</param>
        /// <returns>New node</returns>
        public Object AddNode(Object value)
        {
            Vertex node = new Vertex(value);
            Vertices.Add(node);
            return node;
        }

        /// <summary>
        /// Adds an edge to node which connects to another node or itself, and includes a weight value.
        /// </summary>
        /// <param name="vertA">Starting point of edge</param>
        /// <param name="vertB">Endpoint of edge</param>
        /// <param name="weight">Weight of edge</param>
        public void AddEdge(Vertex vertA, Vertex vertB, int weight)
        {
            if (vertA == vertB)
            {
                Vertex point = Vertices.Find(v => v.Value == vertA.Value);
                Edge edge = new Edge(point, weight);
                Vertices.Find(v => v.Value == vertA.Value).Edge.Add(edge);
                return;
            }

            Vertex pointA = Vertices.Find(v => v.Value == vertA.Value);
            Vertex pointB = Vertices.Find(v => v.Value == vertB.Value);

            Edge edgeA = new Edge(pointB, weight);
            pointA.Edge.Add(edgeA);

            Edge edgeB = new Edge(pointA, weight);
            pointB.Edge.Add(edgeB);
        }

        /// <summary>
        /// Returns a list of nodes within the graph
        /// </summary>
        /// <returns>List of nodes</returns>
        public List<Vertex> GetNodes()
        {
            if (Vertices.Count == 0)
            {
                return null;
            }
            else
            {
                return Vertices;
            }
        }

        /// <summary>
        /// Returns a list of neighbors of a given node
        /// </summary>
        /// <param name="node">Node in graph</param>
        /// <returns>List of node's neighbors</returns>
        public List<Edge> GetNeighbors(Vertex node)
        {
            return Vertices.Find(v => v.Value == node.Value).Edge;
        }

        /// <summary>
        /// Returns a count of all the nodes in a graph
        /// </summary>
        /// <returns>Number of nodes in graph</returns>
        public int Size()
        {
            return Vertices.Count;
        }

        public List<Vertex> BreadthFirst(Vertex node)
        {
            Vertex root = Vertices.Find(n => n.Value == node.Value);
            List<Vertex> nodePath = new List<Vertex>();
            Queue<Vertex> nodeQueue = new Queue<Vertex>();

            nodeQueue.Enqueue(root);

            while(nodeQueue.Count > 0)
            {
                Vertex front = nodeQueue.Dequeue();
                front.Visited = true;
                nodePath.Add(front);

                foreach (Edge edge in front.Edge)
                {
                    if (!edge.Neighbor.Visited)
                    {
                        edge.Neighbor.Visited = true;
                        nodeQueue.Enqueue(edge.Neighbor);
                    }
                }
            }

            return nodePath;
        }
    }
}
