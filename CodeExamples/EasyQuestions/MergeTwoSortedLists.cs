using System.Collections.Generic;

namespace CodeExamples.EasyQuestions
{
    public class MergeTwoSortedLists
    {
        public int[] Merge(int[] arr1, int[] arr2)
        {
            var result = new List<int>();
            int i = 0;
            int j = 0;

            while (i < arr1.Length || j < arr2.Length)
            {
                if (i < arr1.Length && j < arr2.Length)
                {
                    if (arr1[i] < arr2[j])
                    {
                        result.Add(arr1[i++]);
                    }
                    else
                    {
                        result.Add(arr2[j++]);
                    }
                }
                else if (i < arr1.Length)
                {
                    result.Add(arr1[i++]);
                }
                else if (j < arr2.Length)
                {
                    result.Add(arr2[j++]);
                }
            }

            return result.ToArray();
        }
    }
}