using System;
using System.Linq;
using CodeExamples.EasyQuestions;
using NUnit.Framework;

namespace CodeExamplesTests.EasyQuestionsTests
{
    public class MergeTwoSortedListsTest
    {
        [Test]
        public void MergeTwoLargeSortedArrays()
        {
            int Min = int.MinValue;
            int Max = int.MaxValue;
            Random randNum = new Random();
            int[] arr = Enumerable
                .Repeat(0, 1000)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();
            int split = 300;
            var arr1 = arr.Take(split).ToArray();
            var arr2 = arr.Skip(split).ToArray();
            Array.Sort(arr1);
            Array.Sort(arr2);

            var merge = new MergeTwoSortedLists();
            int[] result = merge.Merge(arr1, arr2);

            Array.Sort(arr);
            Assert.AreEqual(arr, result);
        }

        [Test]
        public void MergeTwoSmallSimpleArrays()
        {
            int Min = 0;
            int Max = 50;
            Random randNum = new Random();
            int[] arr = Enumerable
                .Repeat(0, 50)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();
            int split = 10;
            var arr1 = arr.Take(split).ToArray();
            var arr2 = arr.Skip(split).ToArray();
            Array.Sort(arr1);
            Array.Sort(arr2);

            var merge = new MergeTwoSortedLists();
            int[] result = merge.Merge(arr1, arr2);

            Array.Sort(arr);
            Assert.AreEqual(arr, result);
        }
    }
}