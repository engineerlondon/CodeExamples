using System;
using System.Collections.Generic;
using Xunit;
using CodeExamples.EasyQuestions;

namespace CodeExamplesTests.EasyQuestions
{
    // https://www.youtube.com/watch?v=GBuHSRDGZBY
    public class FindPairClosestToTargetFromArraysTest
    {
        [Fact]
        public void FindPairClosestTo24FromTwoArraysTest()
        {
            var arr1 = new[] { 1, 3, 8, 2, 9, 2 };
            var arr2 = new[] { 4, 1, 2, 10, 5, 20 };
            var target = 24;

            var result = FindClosestPair.FindClosestPairFromTwoArrays(arr1, arr2, target);
            var expected = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(3, 20),
                new Tuple<int, int>(20, 3),
                new Tuple<int, int>(5, 20),
                new Tuple<int, int>(20, 5)
            };
            Assert.Contains(result, expected);
        }

        [Fact]
        public void FindPairClosestTo1000FromTwoArraysTest()
        {
            var arr1 = new[] { 1, 3, 8, 2, 9, 5, int.MinValue, 500, 800, -40, -1000, -40 };
            var arr2 = new[] { 4, 1, 2, 10, 5, 20, 120, 2000, int.MaxValue, 11, -1000, 8 };
            var target = 860;

            var result = FindClosestPair.FindClosestPairFromTwoArrays(arr1, arr2, target);
            var expected = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(800, 20)
            };
            Assert.Contains(result, expected);
        }
    }
}