using System.Collections.Generic;
using System.Linq;
using CodeExamples.Searching.BFS;
using NUnit.Framework;

namespace CodeExamplesTests.SearchingTests.BFS
{
    public class StringBreadthFirstSearchTest
    {
        [Test]
        public void StringBfsSearchTest()
        {
            var head = new StringBreadthFirstSearch.SimpleNode("bob")
            {
                Children = new List<StringBreadthFirstSearch.SimpleNode>
                {
                    new StringBreadthFirstSearch.SimpleNode("Rob"),
                    new StringBreadthFirstSearch.SimpleNode("Garry"),
                    new StringBreadthFirstSearch.SimpleNode("Helen")
                    {
                        Children = new List<StringBreadthFirstSearch.SimpleNode>
                            {new StringBreadthFirstSearch.SimpleNode("Andrew")}
                    }
                }
            };

            StringBreadthFirstSearch bfs = new StringBreadthFirstSearch();
            var result = bfs.Search(head, "Helen");
            var firstChildVal = result.Children.FirstOrDefault().Name;
            Assert.AreEqual("Andrew", firstChildVal);
        }
    }
}