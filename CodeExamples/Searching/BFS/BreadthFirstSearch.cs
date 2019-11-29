using System.Collections.Generic;

namespace CodeExamples.Searching.BFS
{
    public class BreadthFirstSearch
    {
        public BfsNode.Node<T> Search<T>(BfsNode.Node<T> root, T elementToFind)
        {
            var queue = new Queue<BfsNode.Node<T>>();
            root.Marked = true;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var elem = queue.Dequeue();
                if (elem.Name.Equals(elementToFind))
                {
                    return elem;
                }

                foreach (BfsNode.Node<T> n in elem.Children)
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