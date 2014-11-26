using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet.DataStructures
{
    public class GraphEdge<T>
    {
        public GraphNode<T> SourceNode { get; private set; }
        public GraphNode<T> DestinationNode { get; private set; }

        public float Weight { get; private set; }

        public GraphEdge(GraphNode<T> source, GraphNode<T> destionation, float weight)
        {
            this.SourceNode = source;
            this.DestinationNode = destionation;
            this.Weight = weight;
        }
    }
}
