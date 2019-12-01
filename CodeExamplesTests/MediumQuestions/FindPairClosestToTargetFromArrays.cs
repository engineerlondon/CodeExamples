using System;
using System.Collections.Generic;
using CodeExamples.EasyQuestions;
using CodeExamples.MediumQuestions;
using Xunit;

namespace CodeExamplesTests.MediumQuestions
{
    // https://www.youtube.com/watch?v=GBuHSRDGZBY
    public class FindPairClosestToTargetFromArraysTest
    {
        [Fact]
        public void DistanceGetDistaceTest()
        {
            var dist = new Distance(20, 9);
            var target = 20;
            Assert.Equal(9, dist.GetDistance(target));
        }

        [Fact]
        public void FindPairClosestTo24FromTwoArraysTest()
        {
            var arr1 = new[] { 1, 3, 8, 2, 9, 2 };
            var arr2 = new[] { 4, 1, 2, 10, 5, 20 };
            var target = 24;

            var result = FindClosestPair.FindClosestPairFromTwoArrays(arr1, arr2, target);

            Assert.Equal(1, result.GetDistance(target));
        }

        [Fact]
        public void FindPairClosestTo1000FromTwoArraysTest()
        {
            var arr1 = new[] { 1, 3, 8, 2, 9, 5, int.MinValue, 500, 800, -40, -1000, -40 };
            var arr2 = new[] { 4, 1, 2, 10, 5, 20, 120, 2000, int.MaxValue, 11, -1000, 8 };
            var target = 860;

            var result = FindClosestPair.FindClosestPairFromTwoArrays(arr1, arr2, target);

            Assert.Equal(40, result.GetDistance(target));
        }
    }
}