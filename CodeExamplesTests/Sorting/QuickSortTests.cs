using System;
using System.Linq;
using CodeExamples.Sorting;
using Xunit;

namespace CodeExamplesTests.Sorting
{
    public class QuickSortTests
    {
        [Fact]
        public void QuickSortSimpleArrayTest()
        {
            int[] expected = { 10, 14, 22, 1000, 1500, 2000, 2001, 2002, 2003 };
            int[] arr = { 22, 1500, 2001, 2002, 1000, 2000, 2003, 10, 14 };

            var quickSort = new QuickSort(arr);

            var result = quickSort.Sort();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void QuickSortSimplesStringArrayTest()
        {
            string[] expected = { "bob", "Carol", "Clair", "Jim", "Zak" };
            string[] arr = { "Zak", "Clair", "Jim", "Carol", "bob" };

            var quickSort = new QuickSortString(arr);

            string[] result = quickSort.Sort();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void QuickSortLargeRandomArrayTest()
        {
            int Min = int.MinValue;
            int Max = int.MaxValue;
            Random randNum = new Random();
            int[] arr = Enumerable
                .Repeat(0, 100000)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();

            int[] expected = new int[arr.Length];
            arr.CopyTo(expected, 0);
            Array.Sort(expected);

            var quickSort = new QuickSort(arr);
            var result = quickSort.Sort();
            Assert.Equal(expected, result);
        }
    }
}