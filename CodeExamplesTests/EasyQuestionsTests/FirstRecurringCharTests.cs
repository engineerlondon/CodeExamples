using CodeExamples.EasyQuestions;
using NUnit.Framework;

namespace CodeExamplesTests.EasyQuestionsTests
{
    // Question: https://www.youtube.com/watch?v=GJdiM-muYqc
    public class FirstRecurringCharTests
    {
        [Test]
        public void FindFirstRecurringCharTests()
        {
            var result = FirstRecurringChar.FindFirstChar("ABCA");
            Assert.AreEqual('A', result);
        }

        [Test]
        public void FindFirstRecurringCharMultipleReccuringTests()
        {
            var result = FirstRecurringChar.FindFirstChar("BCABA");
            Assert.AreEqual('B', result);
        }

        [Test]
        public void FindFirstRecurringCharNullTests()
        {
            var result = FirstRecurringChar.FindFirstChar("ABC");
            Assert.Null(result);
        }
    }
}