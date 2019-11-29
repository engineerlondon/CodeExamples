using System;

namespace CodeExamples.Sorting
{
    public class RadixSort
    {
        //https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-10.php
        public int[] Sort(int[] arr)
        {
            int[] tmp = new int[arr.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                var j = 0;
                int i;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = arr[i] << shift >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }

            return arr;
        }
    }
}