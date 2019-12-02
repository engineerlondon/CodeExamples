using NUnit.Framework;

namespace CodeExamplesTests.MediumQuestionsTests
{
    public class ProductOfArrayTest
    {
        [Test]
        public void CalculateProductArrTest()
        {
            var arr1 = new[] { 1, 2, 3, 4, 5 };
            var expected = new[] { 120, 60, 40, 30, 24 };
            /*
            2 * 3 * 4 * 5 = 120
            1 * 3 * 4 * 5 = 60
            1 * 2 * 4 * 5 = 40
            1 * 2 * 3 * 5 = 30
            1 * 2 * 3 * 4 = 24
            */
            // Calculate the product of all then divide by the number in question O(n)

            var result = CodeExamples.MediumQuestions.CalculateProductArr.CalcProducts(arr1);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculateProductWithoutDivideArrTest()
        {
            var arr1 = new[] { 1, 2, 3, 4, 5 };
            var expected = new[] { 120, 60, 40, 30, 24 };
            /*
            2 * 3 * 4 * 5 = 120
            1 * 3 * 4 * 5 = 60
            1 * 2 * 4 * 5 = 40
            1 * 2 * 3 * 5 = 30
            1 * 2 * 3 * 4 = 24
            */

            var result = CodeExamples.MediumQuestions.CalculateProductArr.CalcProductsWithoutDivide(arr1);
            Assert.AreEqual(expected, result);
        }
    }
}