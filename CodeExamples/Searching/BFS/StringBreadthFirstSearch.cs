using System.Collections.Generic;

namespace CodeExamples.Searching.BFS
{
    public class StringBreadthFirstSearch
    {
        public class SimpleNode
        {
            public IEnumerable<SimpleNode> Children = new List<SimpleNode>();
            public bool Marked;
            public string Name { get; }

            public SimpleNode(string name)
            {
                Name = name;
            }
        }

        public SimpleNode Search(SimpleNode root, string elementToFind)
        {
            var queue = new Queue<SimpleNode>();
            root.Marked = true;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var elem = queue.Dequeue();
                if (elem.Name == elementToFind)
                {
                    return elem;
                }

                foreach (SimpleNode n in elem.Children)
                {
                    if (!n.Marked)
                    {
                        n.Marked = true;
                        queue.Enqueue(n);
                    }
                }
            }

            return null;
        }
    }
}