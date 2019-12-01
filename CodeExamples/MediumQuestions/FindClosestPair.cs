using System;

namespace CodeExamples.MediumQuestions
{
    public class FindClosestPair
    {
        public static Pair FindClosestPairFromTwoArrays(int[] arr1, int[] arr2, int target)
        {
            // O(nLogn)
            Array.Sort(arr1);
            Array.Sort(arr2);

            int y = 0;
            int x = arr2.Length - 1;

            var closest = new Pair(arr1[0], arr2[0], target);
            while (y < arr1.Length && x >= 0)
            {
                var thisPair = new Pair(arr1[y], arr2[x], target);

                if (thisPair.DistToTarget == 0)
                    return thisPair;

                if (thisPair.DistToTarget < closest.DistToTarget)
                    closest = thisPair;

                if (thisPair.Diff < 0) y++;
                else x--;
            }

            return closest;
        }

        public static Pair FindPairBruteForce(int[] arr1, int[] arr2, int target)
        {
            //Brute Force, O(n ^ 2)
            Pair closest = null;
            if (arr1.Length > 0 && arr2.Length > 0)
                closest = new Pair(arr1[0], arr2[0], target);

            foreach (var arr1Val in arr1)
            {
                foreach (var arr2Val in arr2)
                {
                    var thisDistance = new Pair(arr1Val, arr2Val, target);

                    if (closest.DistToTarget > thisDistance.DistToTarget)
                    {
                        closest = thisDistance;
                    }
                }
            }

            return closest;
        }
    }
}