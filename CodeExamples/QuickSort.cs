using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExamples
{
    public class QuickSort
    {
        private int[] _arr;

        public QuickSort(int[] arr)
        {
            _arr = arr;
        }

        public int[] Sort()
        {
            return Sort(0, _arr.Length - 1);
        }

        private int[] Sort(int left, int right)
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
            int pivot = _arr[(left + right) / 2];

            while (left <= right)
            {
                while (_arr[left] < pivot)
                    left++;
                while (_arr[right] > pivot)
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

        private void Swap(int left, int right)
        {
            if (left == right)
                return;
            var temp = _arr[left];
            _arr[left] = _arr[right];
            _arr[right] = temp;
        }
    }
}