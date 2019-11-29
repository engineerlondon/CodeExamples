using System.Collections.Generic;
using System.Linq;
using CodeExamples.Searching.BFS;
using Xunit;

namespace CodeExamplesTests.Searching.BFS
{
    public class BreadthFirstSearchTests
    {
        [Fact]
        public void BfsStingFindNode()
        {
            BfsNode.Node<string> head = new BfsNode.Node<string>("bob")
            {
                Children = new List<BfsNode.Node<string>>
                {
                    new BfsNode.Node<string>("Rob"),
                    new BfsNode.Node<string>("Garry"),
                    new BfsNode.Node<string>("Helen")
                    {
                        Children = new List<BfsNode.Node<string>>
                            {new BfsNode.Node<string>("Andrew")}
                    }
                }
            };

            BreadthFirstSearch bfs = new BreadthFirstSearch();
            var result = bfs.Search(head, "Helen");
            var firstChildVal = result.Children.FirstOrDefault().Name;
            Assert.Equal("Andrew", firstChildVal);
        }

        [Fact]
        public void BfsIntegerFindNode()
        {
            BfsNode.Node<int> head = new BfsNode.Node<int>(1)
            {
                Children = new List<BfsNode.Node<int>>
                {
                    new BfsNode.Node<int>(200),
                    new BfsNode.Node<int>(500),
                    new BfsNode.Node<int>(1000)
                    {
                        Children = new List<BfsNode.Node<int>>
                            {new BfsNode.Node<int>(99)}
                    }
                }
            };

            BreadthFirstSearch bfs = new BreadthFirstSearch();
            var result = bfs.Search(head, 1000);
            var foo = result.Children.FirstOrDefault().Name;
            Assert.Equal(99, foo);
        }
    }
}