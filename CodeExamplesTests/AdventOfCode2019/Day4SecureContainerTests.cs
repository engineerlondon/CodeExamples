using System;
using System.Collections.Generic;
using System.Text;
using CodeExamples.AdventOfCode2019;
using NUnit.Framework;
using NUnit.Framework.Internal;

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
    }
}