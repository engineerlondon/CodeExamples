﻿using CodeExamples.MediumQuestions;
using NUnit.Framework;

namespace CodeExamplesTests.MediumQuestionsTests
{
    // https://www.youtube.com/watch?v=GBuHSRDGZBY
    public class FindPairClosestToTargetFromArraysTest
    {
        [Test]
        public void DistanceGetDistaceTest()
        {
            var target = 20;
            var dist = new Pair(20, 9, target);

            Assert.AreEqual(9, dist.DistToTarget);
        }

        [Test]
        public void FindPairClosestTo24FromTwoArraysTest()
        {
            var arr1 = new[] { 4, 1, 2, 10, 5, 20, 19 };
            var arr2 = new[] { 1, 3, 8, 2, 9, 2 };
            var target = 24;

            var result = FindClosestPair.FindClosestPairFromTwoArrays(arr1, arr2, target);

            Assert.AreEqual(1, result.DistToTarget);
        }

        [Test]
        public void FindPairClosestTo860FromTwoArraysTest()
        {
            var arr1 = new[] { 1, 3, 8, 2, 9, 5, int.MinValue, 500, 800, -40, -1000, -40 };
            var arr2 = new[] { 4, 1, 2, 10, 5, 20, 120, 2000, int.MaxValue, 11, -1000, 8 };
            var target = 860;

            var result = FindClosestPair.FindClosestPairFromTwoArrays(arr1, arr2, target);

            Assert.AreEqual(40, result.DistToTarget);
        }

        [Test]
        public void FindPairClosestRandomPairFromTwoDifferentSizeArraysTest()
        {
            int[] arr1 =
            {
                8586, 4916, 5843, 4589, 4331, 9177, -6992, 8780, 8948, -4101, -8390, 8900, 3165, -5036, 5136, -420,
                3868, 9700, 3924, -3041, -4483, -8856, -3565, -4697, 1812, 2103, -8455, 8361, -2569, 8488, 6245, 6304,
                -8980, -3969, -422, 1273, -6731, -2400, 4409, -9780, -2776, -533, 7970, 9449, 1908, -5483, -8328, 4147,
                4112, -4641, 1730, -9490, 7088, -5676, -5217, 7442, -1519, 540, -7224, -7772, 7631, -5354, 1349, -9540,
                -347, -4694, 7880, -2866, 5385, -6138, -3690, -3733, -4710, 3704, 9734, 6050, -6827, -3015, 3394, -2706,
                430, -2602, -5751, -7929, -3243, 5735, 9215, 6695, -8753, 2135, -7208, 2729, -5177, 2181, -7412, -7423,
                8118, 7510, -205, -3399
            };

            int[] arr2 =
            {
                4269, -8505, 7145, 5481, 1797, 233, -9603, -723, 3702, 3918, -3910, -8816, -4114, -6750, -8930, 3580,
                -8556, 3109, 1115, 7156, 7932, -4338, 7189, -3207, -9342, 5892, -1364, 4000, -6978, -8706, -9486, 5831,
                2106, 2515, 7866, -8703, 5584, -659, -9617, 2354, -7820, -1160, -6192, 5877, -9490, -4549, -1348, 5511,
                -822, -4532, -5982, -7889, 2268, -2568, 800, -1394, -5695, 351, 4823, 5905, -8403, -3604, -3745, 2407,
                3403, 259, -922, 3371, -4617, 9773, 7996, 2102, 2725, 8761, 4976, -909, -8146, -8688, -3718, 5206,
                -2761, 3124, -5179, 7553, 7276, 8403, -6437, -5327, -8286, -741, 6991, -4768, 4518, -5522, 757, 5784,
                -7416, 1401, -7527, 251
            };

            var target = 500;

            var result = FindClosestPair.FindClosestPairFromTwoArrays(arr1, arr2, target);

            //4409 -3910 = 499
            Assert.AreEqual(1, result.DistToTarget);
        }

        [Test]
        public void FindPairClosestBruteForcePairFromTwoDifferentSizeArraysTest()
        {
            int[] arr1 =
            {
                8586, 4916, 5843, 4589, 4331, 9177, -6992, 8780, 8948, -4101, -8390, 8900, 3165, -5036, 5136, -420,
                3868, 9700, 3924, -3041, -4483, -8856, -3565, -4697, 1812, 2103, -8455, 8361, -2569, 8488, 6245, 6304,
                -8980, -3969, -422, 1273, -6731, -2400, 4409, -9780, -2776, -533, 7970, 9449, 1908, -5483, -8328, 4147,
                4112, -4641, 1730, -9490, 7088, -5676, -5217, 7442, -1519, 540, -7224, -7772, 7631, -5354, 1349, -9540,
                -347, -4694, 7880, -2866, 5385, -6138, -3690, -3733, -4710, 3704, 9734, 6050, -6827, -3015, 3394, -2706,
                430, -2602, -5751, -7929, -3243, 5735, 9215, 6695, -8753, 2135, -7208, 2729, -5177, 2181, -7412, -7423,
                8118, 7510, -205, -3399
            };

            int[] arr2 =
            {
                4269, -8505, 7145, 5481, 1797, 233, -9603, -723, 3702, 3918, -3910, -8816, -4114, -6750, -8930, 3580,
                -8556, 3109, 1115, 7156, 7932, -4338, 7189, -3207, -9342, 5892, -1364, 4000, -6978, -8706, -9486, 5831,
                2106, 2515, 7866, -8703, 5584, -659, -9617, 2354, -7820, -1160, -6192, 5877, -9490, -4549, -1348, 5511,
                -822, -4532, -5982, -7889, 2268, -2568, 800, -1394, -5695, 351, 4823, 5905, -8403, -3604, -3745, 2407,
                3403, 259, -922, 3371, -4617, 9773, 7996, 2102, 2725, 8761, 4976, -909, -8146, -8688, -3718, 5206,
                -2761, 3124, -5179, 7553, 7276, 8403, -6437, -5327, -8286, -741, 6991, -4768, 4518, -5522, 757, 5784,
                -7416, 1401, -7527, 251
            };

            var target = 500;

            var result = FindClosestPair.FindPairBruteForce(arr1, arr2, target);

            //4409 -3910 = 499
            Assert.AreEqual(1, result.DistToTarget);
        }
    }
}