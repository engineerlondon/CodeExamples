﻿using CodeExamples.SortingLargeNumbers;
using NUnit.Framework;

namespace CodeExamplesTests.SortingTests
{
    public class SortUsingCustomComparerTests
    {
        [Test]
        public void QuickSortSimpleStringArrayTest()
        {
            string[] expected = { "1", "2", "8", "100", "111", "200",
                "3084193741082937", "3084193741082938", "12303479849857341718340192371" };

            string[] arr = { "8", "1", "2", "100", "12303479849857341718340192371",
                "3084193741082937", "3084193741082938", "111" ,"200" };

            var sort = new SortUsingCustomComparer();

            string[] result = sort.Sort(arr);
            Assert.AreEqual(expected, result);
        }
    }
}