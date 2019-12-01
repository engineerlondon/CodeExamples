using System;

namespace CodeExamples.MediumQuestions
{
    public class Pair
    {
        public int First { get; }
        public int Second { get; }

        public int Diff { get; }

        public int DistToTarget => Math.Abs(Diff);

        public Pair(int first, int second, int target)
        {
            First = first;
            Second = second;

            Diff = (First + Second) - target;
        }
    }
}