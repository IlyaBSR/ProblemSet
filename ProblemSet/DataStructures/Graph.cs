using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet.DataStructures
{
    public class Graph<T>
    {
        private bool bidirectional = false;
        public List<GraphNode<T>> Nodes { get; set; }

        public Graph(bool bidirectional) 
        {
            this.Nodes = new List<GraphNode<T>>();
            this.bidirectional = bidirectional;
        }

        public List<GraphEdge<T>> AllEdges()
        {
            List<GraphEdge<T>> allEdges = new List<GraphEdge<T>>();
            foreach (GraphNode<T> node in this.Nodes)
            {
                foreach (GraphEdge<T> edge in node.Edges)
                {
                    allEdges.Add(edge);
                }
            }

            return allEdges;
        }

        public List<GraphEdge<T>> AllEdgesSorted()
        {
            List<GraphEdge<T>> allEdges = this.AllEdges();
            allEdges.Sort(new GraphEdgeComparitor<T>());
            return allEdges;
        }

        public GraphNode<T> AddGraphNode(T data)
        {
            GraphNode<T> newNode = new GraphNode<T>(data);
            this.Nodes.Add(newNode);
            return newNode;
        }

        public void AddGraphEdge(GraphNode<T> source, GraphNode<T> destination, float weight = 1)
        {
            GraphEdge<T> newEdge = new GraphEdge<T>(source, destination, weight);
            source.Edges.Add(newEdge);

            if (bidirectional)
            {
                newEdge = new GraphEdge<T>(destination, source, weight);
            }
        }
    }

    public class GraphEdgeComparitor<T> : IComparer<GraphEdge<T>>
    {
        public int Compare(GraphEdge<T> edge1, GraphEdge<T> edge2)
        {
            return edge1.Weight.CompareTo(edge2.Weight);
        }
    }
}
