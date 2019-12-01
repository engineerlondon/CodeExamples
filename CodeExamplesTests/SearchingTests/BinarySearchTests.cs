using CodeExamples.Searching;
using NUnit.Framework;

namespace CodeExamplesTests.SearchingTests
{
    public class BinarySearchTests
    {
        [Test]
        public void SearchFindSecondValueArrayTest()
        {
            BinarySearch search = new BinarySearch();
            int[] arr = { 10, 14, 22, 1000, 1500, 2000, 2001, 2002, 2003 };
            int result = search.Search(arr, 14);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void SearchFindIntMaxValue()
        {
            BinarySearch search = new BinarySearch();
            int[] arr = { 10, 14, 22, 1000, 1500, 2000, 2001, 2002, int.MaxValue };
            int result = search.Search(arr, int.MaxValue);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void SearchValueDoesNotExistTest()
        {
            BinarySearch search = new BinarySearch();
            int[] arr = { 10, 14, 22, 1000, 1500, 2000, 2001, 2002, 2003 };
            int result = search.Search(arr, 5);
            Assert.AreEqual(-1, result);
        }
    }
}