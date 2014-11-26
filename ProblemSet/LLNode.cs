using System;

namespace ProblemSet
{
    public class LLNode<T>
    {
        public LLNode (T data) 
        {
            this.Data = data;
        }

        public LLNode<T> Next {get; set;}

        public T Data {get; set;}

        public VisitState Visited {get; set;}
    }

    public enum VisitState 
    {
        Visted,
        Unvisited,
        Visiting
    }
}
