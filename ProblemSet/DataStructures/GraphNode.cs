using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet.DataStructures
{
    public class GraphNode<T>
    {
        public T Data { get; set; }

        public List<GraphEdge<T>> Edges { get; set; }

        internal GraphNode(T data)
        {
            this.Data = data;
            this.Edges = new List<GraphEdge<T>>();
        }
    }
}
