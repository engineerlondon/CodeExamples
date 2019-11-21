using System;
using System.Linq;
using Xunit;
using CodeExamples;

namespace CodeExamplesTests
{
    public class BinarySearchTests
    {
        [Fact]
        public void SearchFindSecondValueArrayTest()
        {
            BinarySearch search = new BinarySearch();
            int[] arr = { 10, 14, 22, 1000, 1500, 2000, 2001, 2002, 2003 };
            int result = search.Search(arr, 14);
            Assert.Equal(1, result);
        }

        [Fact]
        public void SearchFindIntMaxValue()
        {
            BinarySearch search = new BinarySearch();
            int[] arr = { 10, 14, 22, 1000, 1500, 2000, 2001, 2002, int.MaxValue };
            int result = search.Search(arr, int.MaxValue);
            Assert.Equal(8, result);
        }

        [Fact]
        public void SearchValueDoesNotExistTest()
        {
            BinarySearch search = new BinarySearch();
            int[] arr = { 10, 14, 22, 1000, 1500, 2000, 2001, 2002, 2003 };
            int result = search.Search(arr, 5);
            Assert.Equal(-1, result);
        }
    }
}