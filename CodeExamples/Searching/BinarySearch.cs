namespace CodeExamples.Searching
{
    public class BinarySearch
    {
        public int Search(int[] valuesToSearch, int valueToFind)
        {
            int high = valuesToSearch.Length - 1;
            int low = 0;
            while (low <= high)
            {
                int mid = (int)((uint)(low + high) / 2);
                if (valuesToSearch[mid] > valueToFind)
                    high = mid - 1;
                else if (valuesToSearch[mid] < valueToFind)
                    low = mid + 1;
                else
                    return mid;
            }
            return -1; // No matching value in the array.
        }
    }
}