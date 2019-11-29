using CodeExamples.EasyQuestions;
using Xunit;

namespace CodeExamplesTests.EasyQuestions
{
    // Question: https://www.youtube.com/watch?v=GJdiM-muYqc
    public class FirstRecurringCharTests
    {
        [Fact]
        public void FindFirstRecurringCharTests()
        {
            var result = FirstRecurringChar.FindFirstChar("ABCA");
            Assert.Equal('A', result);
        }

        [Fact]
        public void FindFirstRecurringCharMultipleReccuringTests()
        {
            var result = FirstRecurringChar.FindFirstChar("BCABA");
            Assert.Equal('B', result);
        }

        [Fact]
        public void FindFirstRecurringCharNullTests()
        {
            var result = FirstRecurringChar.FindFirstChar("ABC");
            Assert.Null(result);
        }
    }
}