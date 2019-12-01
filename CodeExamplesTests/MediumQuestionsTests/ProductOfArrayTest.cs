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
            var result = CodeExamples.MediumQuestions.CalculateProductArr.CalcProducts(arr1);
            Assert.AreEqual(expected, result);
        }
    }
}