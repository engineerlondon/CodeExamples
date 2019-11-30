using System;
using System.Collections.Generic;
using System.Net.Mime;

namespace CodeExamples.EasyQuestions
{
    public class FindClosestPair
    {
        public static Tuple<int, int> FindClosestPairFromTwoArrays(int[] arr1, int[] arr2, in int target)
        {
            // Modified binary search, if we sort each array at a cost of O(NlogN),
            Array.Sort(arr1);
            Array.Sort(arr2);

            // now modified binary search, if the values combined at the same indices?

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = target - arr1[i];
            }

            // Brute Force, O(n^2)
            //Tuple<int, int> closest = new Tuple<int, int>(0, 0);
            //foreach (var arr1Val in arr1)
            //{
            //    foreach (var arr2Val in arr2)
            //    {
            //        int existingDistance = target - (closest.Item1 + closest.Item2);
            //        int thisDistance = (target - (arr1Val + arr2Val));
            //        if (thisDistance < 0)
            //            thisDistance *= -1;
            //        if (existingDistance > thisDistance)
            //        {
            //            closest = new Tuple<int, int>(arr1Val, arr2Val);
            //        }
            //    }
            //}

            return closest;
        }
    }
}