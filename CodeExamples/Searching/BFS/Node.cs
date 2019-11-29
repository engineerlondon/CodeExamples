using System.Collections.Generic;

namespace CodeExamples.Searching.BFS
{
    public class BfsNode
    {
        public class Node<T>
        {
            public IEnumerable<Node<T>> Children = new List<Node<T>>();
            public bool Marked;
            public T Name { get; set; }

            public Node(T name)
            {
                Name = name;
            }
        }
    }
}