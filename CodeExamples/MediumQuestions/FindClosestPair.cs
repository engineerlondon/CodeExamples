using System;

namespace CodeExamples.MediumQuestions
{
    public class FindClosestPair
    {
        public static Distance FindClosestPairFromTwoArrays(int[] arr1, int[] arr2, in int target)
        {
            // Modified binary search, if we sort each array at a cost of O(NlogN),
            Array.Sort(arr1);
            Array.Sort(arr2);

            // now modified binary search, if the values combined at the same indices?

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = target - arr1[i];
            //}

            //Brute Force, O(n ^ 2)
            Distance closest = null;
            if (arr1.Length > 0 && arr2.Length > 0)
                closest = new Distance(arr1[0], arr2[0]);

            foreach (var arr1Val in arr1)
            {
                foreach (var arr2Val in arr2)
                {
                    var thisDistance = new Distance(arr1Val, arr2Val);

                    if (closest.GetDistance(target) > thisDistance.GetDistance(target))
                    {
                        closest = thisDistance;
                    }
                }
            }

            return closest;
        }
    }
}