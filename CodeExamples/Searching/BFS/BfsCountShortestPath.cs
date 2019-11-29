using System.Collections.Generic;

namespace CodeExamples.Searching.BFS
{
    /// <summary>
    /// Finds the shortest path to a node
    /// </summary>
    public class BfsCountShortestPath
    {
        public int Search<T>(BfsNode.Node<T> root, T elementToFind)
        {
            var dist = new Dictionary<T, int>();
            var queue = new Queue<BfsNode.Node<T>>();
            root.Marked = true;
            queue.Enqueue(root);
            dist.Add(root.Name, 0);

            while (queue.Count > 0)
            {
                var elem = queue.Dequeue();

                if (elem.Name.Equals(elementToFind))
                    return dist[elem.Name];

                foreach (BfsNode.Node<T> n in elem.Children)
                {
                    if (!n.Marked)
                    {
                        n.Marked = true;
                        queue.Enqueue(n);
                        if (!dist.ContainsKey(n.Name))
                            dist.Add(n.Name, dist[elem.Name] + 1);
                    }
                }
            }

            return -1;
        }
    }
}