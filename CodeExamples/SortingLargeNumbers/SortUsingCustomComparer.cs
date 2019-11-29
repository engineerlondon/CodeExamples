using System;

namespace CodeExamples.SortingLargeNumbers
{
    public class SortUsingCustomComparer
    {
        public string[] Sort(string[] arr)
        {
            //https://www.hackerrank.com/challenges/big-sorting/problem
            var comparer = new SortStringsAsNumbersComparer();
            Array.Sort(arr, comparer);
            return arr;
        }
    }
}