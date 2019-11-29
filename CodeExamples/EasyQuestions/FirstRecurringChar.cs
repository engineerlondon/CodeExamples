namespace CodeExamples.EasyQuestions
{
    public class FirstRecurringChar
    {
        public static char? FindFirstChar(string input)
        {
            int[] arr = new int[26];
            var chars = input.ToCharArray();
            // O(n)
            foreach (var t in chars)
            {
                int charVal = t - 65;
                if (arr[charVal] != 0)
                    return (char)(charVal + 65);
                arr[charVal] = 1;
            }

            return null;
        }
    }
}