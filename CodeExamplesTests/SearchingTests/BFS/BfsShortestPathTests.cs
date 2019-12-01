using System.Collections.Generic;
using CodeExamples.Searching.BFS;
using NUnit.Framework;

namespace CodeExamplesTests.SearchingTests.BFS
{
    public class BfsShortestPathTests
    {
        [Test]
        public void BfsCountShortestPath()
        {
            var alex = new BfsNode.Node<string>("Alex");
            var rob = new BfsNode.Node<string>("Rob");
            var garry = new BfsNode.Node<string>("Garry");

            // Khalid is friends with alex, rob and garry
            var khalid = new BfsNode.Node<string>("Khalid")
            {
                Children = new List<BfsNode.Node<string>>
                    {alex, rob, garry}
            };
            // Andrew if friends with Alex and Khalid
            var andrew = new BfsNode.Node<string>("Andrew")
            {
                Children = new List<BfsNode.Node<string>>
                    {khalid, alex}
            };
            // Helen is friends with Andrew
            var helen = new BfsNode.Node<string>("Helen")
            {
                Children = new List<BfsNode.Node<string>> { andrew }
            };
            // Bob is friends with Helen and Khalid
            // Shortest path to Alex = Bob -> Khalid -> Alex.
            // Longer path to Alex = Bob -> helen -> Andrew -> Alex.
            // Even longer path Alex = Bob -> helen -> Andrew -> Khalid -> Alex.
            BfsNode.Node<string> head = new BfsNode.Node<string>("Bob")
            {
                Children = new List<BfsNode.Node<string>>
                { helen, khalid}
            };

            var bfs = new BfsCountShortestPath();
            var result = bfs.Search(head, "Alex");
            int expected = 2;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void BfsCountShortestNoChildNodesNoMatchPath()
        {
            BfsNode.Node<string> head = new BfsNode.Node<string>("bob");

            var bfs = new BfsCountShortestPath();
            var result = bfs.Search(head, "Alex");
            int expected = -1;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void BfsCountShortestNoChildNodesMatchPath()
        {
            BfsNode.Node<string> head = new BfsNode.Node<string>("bob");

            var bfs = new BfsCountShortestPath();
            var result = bfs.Search(head, "bob");
            int expected = 0;
            Assert.AreEqual(expected, result);
        }
    }
}