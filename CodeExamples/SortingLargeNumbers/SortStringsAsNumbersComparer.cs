using System.Collections.Generic;

namespace CodeExamples.SortingLargeNumbers
{
    internal class SortStringsAsNumbersComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            //https://www.hackerrank.com/sungmkim80
            // If the length is not the same, we return the difference.
            // A negative # means, x Length is shorter, 0 means the same (this doesn't occur) and a positive # means Y is bigger
            if (x.Length != y.Length) return x.Length - y.Length;

            // Now the length is the same.
            // Compare the number from the first digit.
            for (int i = 0; i < x.Length; i++)
            {
                char left = x[i];
                char right = y[i];
                if (left != right)
                    return left - right;
            }

            // Default: "0" means both numbers are the same.
            return 0;
        }
    }
}