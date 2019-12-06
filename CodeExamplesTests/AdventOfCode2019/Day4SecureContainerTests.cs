using CodeExamples.AdventOfCode2019;
using NUnit.Framework;

namespace CodeExamplesTests.AdventOfCode2019
{
    public class Day4SecureContainerTests
    {
        [Test]
        public void FindIntThatMatchesRulesTestExample0()
        {
            Day4SecureContainer container = new Day4SecureContainer();
            int result = container.FindIntThatMatchesRules(111111, 111111);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void FindIntThatMatchesRulesTestExample1()
        {
            Day4SecureContainer container = new Day4SecureContainer();
            int result = container.FindIntThatMatchesRules(223450, 223450);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void FindIntThatMatchesRulesTestExample2()
        {
            Day4SecureContainer container = new Day4SecureContainer();
            int result = container.FindIntThatMatchesRules(123789, 123789);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void FindIntThatMatchesRulesTestExample3()
        {
            Day4SecureContainer container = new Day4SecureContainer();
            int result = container.FindIntThatMatchesRules(135679, 135679);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void FindIntThatMatchesRulesTestExample4()
        {
            Day4SecureContainer container = new Day4SecureContainer();
            int result = container.FindIntThatMatchesRules(111123, 111123);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void FindIntThatMatchesRuleActualDataTest()
        {
            Day4SecureContainer container = new Day4SecureContainer();
            int result = container.FindIntThatMatchesRules(145852, 616942);
            Assert.That(result, Is.EqualTo(1767));
        }

        [Test]
        public void FindIntThatMatchesRulePart2Example1Test()
        {
            Day4SecureContainer container = new Day4SecureContainer();
            int result = container.FindIntThatMatchesRules(112233, 112233, 2);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void FindIntThatMatchesRulePart2Example2Test()
        {
            Day4SecureContainer container = new Day4SecureContainer();
            int result = container.FindIntThatMatchesRules(123444, 123444, 2);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void FindIntThatMatchesRulePart2Example3Test()
        {
            Day4SecureContainer container = new Day4SecureContainer();
            int result = container.FindIntThatMatchesRules(111122, 111122, 2);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void FindIntThatMatchesRuleActualDataPar2Test()
        {
            Day4SecureContainer container = new Day4SecureContainer();
            int result = container.FindIntThatMatchesRules(145852, 616942, 2);
            Assert.That(result, Is.EqualTo(1192));
        }
    }
}