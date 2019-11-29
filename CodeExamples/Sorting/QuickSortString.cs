using System;

namespace CodeExamples.Sorting
{
    public class QuickSortString
    {
        private readonly string[] _arr;

        public QuickSortString(string[] arr)
        {
            _arr = arr;
        }

        public string[] Sort()
        {
            return Sort(0, _arr.Length - 1);
        }

        private string[] Sort(int left, int right)
        {
            int index = Partition(left, right);
            if (left < index - 1)
                Sort(left, index - 1); // Sort LHS
            if (index < right)
                Sort(index, right); // Sort RHS
            return _arr;
        }

        private int Partition(int left, int right)
        {
            string pivot = _arr[(right + left) / 2];

            while (left <= right)
            {
                while (String.Compare(_arr[left], pivot, StringComparison.OrdinalIgnoreCase) < 0)
                    left++;
                while (String.Compare(_arr[right], pivot, StringComparison.OrdinalIgnoreCase) > 0)
                    right--;

                if (left <= right)
                {
                    Swap(left, right);
                    left++;
                    right--;
                }
            }

            return left;
        }

        public int swapCount = 0;

        private void Swap(int left, int right)
        {
            swapCount++;
            if (left == right)
                return;
            var temp = _arr[left];
            _arr[left] = _arr[right];
            _arr[right] = temp;
        }
    }
}