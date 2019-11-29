namespace CodeExamples.Sorting
{
    public class InsertionSort
    {
        public int[] Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var currentValue = arr[i];
                var j = i - 1;

                while (j >= 0 && arr[j] > currentValue)
                {
                    arr[j + 1] = arr[j--];
                }
                arr[j + 1] = currentValue;
            }

            return arr;
        }
    }
}