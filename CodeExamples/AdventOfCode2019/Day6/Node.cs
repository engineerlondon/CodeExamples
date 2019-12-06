using System;
using System.Collections.Generic;

namespace CodeExamples.AdventOfCode2019.Day6
{
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