using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeExamples.AdventOfCode2019
{
    public class Day6UniversalOrbitMap
    {
        public Dictionary<Guid, int> VisitedDist { get; private set; }

        public Node AddListToGraph(Node head, List<OrbitDesc> input)
        {
            var nodeDesc = input.Where(_ => _.Center == head.Center).ToList();

            foreach (var child in nodeDesc)
            {
                var orbiter = new Node(child.Orbiter);
                orbiter.Parents.Add(head);
                head.Orbiters.Add(AddListToGraph(orbiter, input));
            }

            return head;
        }

        public int CountTotalOrbits(Node head)
        {
            FindNode(head);
            int counter = 0;
            foreach (var visited in VisitedDist)
            {
                counter += visited.Value;
            }

            return counter;
        }

        /// <summary>
        /// BFS of nodes O(logn) time
        /// </summary>
        /// <param name="head">The node from which to start the search</param>
        /// <param name="nodeToFind">The name of the Orbiter we are looking for. If left blank the search will iterate all nodes</param>
        /// <returns>The node that matches the name or null if no node with the name exists</returns>
        public Node FindNode(Node head, string nodeToFind = "")
        {
            VisitedDist = new Dictionary<Guid, int>();
            Queue<Node> queue = new Queue<Node>();
            VisitedDist.Add(head.Uid, 0);
            queue.Enqueue(head);

            while (queue.Count > 0)
            {
                var elem = queue.Dequeue();
                if (!string.IsNullOrEmpty(nodeToFind) &&
                    elem.Center.Equals(nodeToFind, StringComparison.InvariantCultureIgnoreCase))
                    return elem;

                foreach (var orbiter in elem.Parents)
                {
                    if (!VisitedDist.ContainsKey(orbiter.Uid))
                    {
                        VisitedDist.Add(orbiter.Uid, VisitedDist[elem.Uid] + 1);
                        queue.Enqueue(orbiter);
                    }
                }

                foreach (var orbiter in elem.Orbiters)
                {
                    if (!VisitedDist.ContainsKey(orbiter.Uid))
                    {
                        VisitedDist.Add(orbiter.Uid, VisitedDist[elem.Uid] + 1);
                        queue.Enqueue(orbiter);
                    }
                }
            }

            return null;
        }

        public int CountDistanceBetweenPoints(Node head, string find)
        {
            var elem = FindNode(head, find);

            return VisitedDist[elem.Uid];
        }
    }

    public class ReadInputFromFile
    {
        public static IEnumerable<OrbitDesc> ReadFile(FileInfo fi)
        {
            if (!fi.Exists)
                throw new ArgumentException(@"The file {fi.FullName} does not exist.");

            var result = new List<OrbitDesc>();
            using (TextReader tr = new StreamReader(fi.OpenRead()))
            {
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    string[] parts = line.Split(')');
                    result.Add(new OrbitDesc(parts[0]) { Orbiter = parts[1] });
                }
            }

            return result;
        }
    }

    public class OrbitDesc
    {
        public OrbitDesc(string center)
        {
            Center = center;
        }

        public string Center { get; }
        public string Orbiter;
    }

    public class Node
    {
        public Guid Uid = Guid.NewGuid();
        public List<Node> Orbiters = new List<Node>();
        public List<Node> Parents = new List<Node>();

        public Node(string center)
        {
            Center = center;
        }

        public string Center { get; }
    }
}