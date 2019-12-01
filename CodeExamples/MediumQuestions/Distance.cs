namespace CodeExamples.MediumQuestions
{
    public class Distance
    {
        public int First { get; }
        public int Second { get; }

        public int GetDistance(int target)
        {
            var result = target - (First + Second);
            if (result < 0)
                result *= -1;
            return result;
        }

        public Distance(int first, int second)
        {
            First = first;
            Second = second;
        }
    }
}