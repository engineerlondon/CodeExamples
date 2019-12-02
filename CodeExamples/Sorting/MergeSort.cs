using System;

namespace CodeExamples.Sorting
{
    public class MergeSort
    {
        public void Sort(int[] arr)
        {
            int[] helper = new int[arr.Length];
            DoMergeSort(arr, helper, 0, arr.Length - 1);
        }

        private void DoMergeSort(int[] arr, int[] helper, int left, int right)
        {
            if (left < right)
            {
                int mid = (right + left) / 2;
                DoMergeSort(arr, helper, left, mid);
                DoMergeSort(arr, helper, mid + 1, right);
                Merge(arr, helper, left, mid, right);
            }
        }

        private void Merge(int[] arr, int[] helper, int left, int mid, int right)
        {
            // Copy both halves into the helper array.
            for (int i = left; i <= right; i++)
            {
                helper[i] = arr[i];
            }

            int helperLeft = left;
            int helperRight = mid + 1;
            int current = left;

            while (helperLeft <= mid && helperRight <= right)
            {
                if (helper[helperLeft] <= helper[helperRight])
                {
                    arr[current] = helper[helperLeft];
                    helperLeft++;
                }
                else
                {
                    arr[current] = helper[helperRight];
                    helperRight++;
                }

                current++;
            }

            int remaining = mid - helperLeft;
            for (int i = 0; i <= remaining; i++)
            {
                arr[current + i] = helper[helperLeft + i];
            }
        }
    }
}