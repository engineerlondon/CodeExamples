namespace CodeExamples.MediumQuestions
{
    public class CalculateProductArr
    {
        public static int[] CalcProducts(int[] arr)
        {
            if (arr.Length < 1)
            {
                return arr;
            }

            int product = 1;
            foreach (var value in arr)
            {
                product *= value;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = product / arr[i];
            }

            return arr;
        }

        public static int[] CalcProductsWithoutDivide(int[] arr)
        {
            if (arr.Length < 1)
            {
                return arr;
            }

            /*
                2 * 3 * 4 * 5 = 120
                1 * 3 * 4 * 5 = 60
                1 * 2 * 4 * 5 = 40
                1 * 2 * 3 * 5 = 30
                1 * 2 * 3 * 4 = 24
            */

            var result = new int[arr.Length];

            return result;
        }
    }
}