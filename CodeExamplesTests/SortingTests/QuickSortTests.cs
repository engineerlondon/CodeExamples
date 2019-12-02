using CodeExamples.Sorting;
using NUnit.Framework;

namespace CodeExamplesTests.SortingTests
{
    public class QuickSortTests
    {
        [Test]
        public void QuickSortSimpleArrayTest()
        {
            int[] expected = { 10, 14, 22, 1000, 1500, 2000, 2001, 2002, 2003 };
            int[] arr = { 22, 1500, 2001, 2002, 1000, 2000, 2003, 10, 14 };

            var quickSort = new QuickSort(arr);

            var result = quickSort.Sort();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void QuickSortSimplesStringArrayTest()
        {
            string[] expected = { "bob", "Carol", "Clair", "Jim", "Zak" };
            string[] arr = { "Zak", "Clair", "Jim", "Carol", "bob" };

            var quickSort = new QuickSortString(arr);

            string[] result = quickSort.Sort();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void QuickSortLargeRandomArrayTest()
        {
            int[] arr =
            {
                8586, 4916, 5843, 4589, 4331, 9177, -6992, 8780, 8948, -4101, -8390, 8900, 3165, -5036, 5136, -420,
                3868, 9700, 3924, -3041, -4483, -8856, -3565, -4697, 1812, 2103, -8455, 8361, -2569, 8488, 6245, 6304,
                -8980, -3969, -422, 1273, -6731, -2400, 4409, -9780, -2776, -533, 7970, 9449, 1908, -5483, -8328, 4147,
                4112, -4641, 1730, -9490, 7088, -5676, -5217, 7442, -1519, 540, -7224, -7772, 7631, -5354, 1349, -9540,
                -347, -4694, 7880, -2866, 5385, -6138, -3690, -3733, -4710, 3704, 9734, 6050, -6827, -3015, 3394, -2706,
                430, -2602, -5751, -7929, -3243, 5735, 9215, 6695, -8753, 2135, -7208, 2729, -5177, 2181, -7412, -7423,
                8118, 7510, -205, -3399
            };

            int[] expected =
            {
                -9780, -9540, -9490, -8980, -8856, -8753, -8455, -8390, -8328, -7929, -7772, -7423, -7412, -7224, -7208,
                -6992, -6827, -6731, -6138, -5751, -5676, -5483, -5354, -5217, -5177, -5036, -4710, -4697, -4694, -4641,
                -4483, -4101, -3969, -3733, -3690, -3565, -3399, -3243, -3041, -3015, -2866, -2776, -2706, -2602, -2569,
                -2400, -1519, -533, -422, -420, -347, -205, 430, 540, 1273, 1349, 1730, 1812, 1908, 2103, 2135, 2181,
                2729, 3165, 3394, 3704, 3868, 3924, 4112, 4147, 4331, 4409, 4589, 4916, 5136, 5385, 5735, 5843, 6050,
                6245, 6304, 6695, 7088, 7442, 7510, 7631, 7880, 7970, 8118, 8361, 8488, 8586, 8780, 8900, 8948, 9177,
                9215, 9449, 9700, 9734
            };

            var quickSort = new QuickSort(arr);
            var result = quickSort.Sort();
            Assert.AreEqual(expected, result);
        }
    }
}