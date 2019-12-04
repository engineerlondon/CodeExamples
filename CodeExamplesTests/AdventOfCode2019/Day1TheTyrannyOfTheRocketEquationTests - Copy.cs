using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeExamples.AdventOfCode2019;
using NUnit.Framework;

namespace CodeExamplesTests.AdventOfCode2019
{
    internal class Day1TheTyrannyOfTheRocketEquationTests
    {
        [Test]
        public void TheTyrannyOfTheRocketEquationTestExampleData()
        {
            List<int> input = new List<int> { 12, 14, 1969, 100756 };
            var fuelCalc = new Day1TheTyrannyOfTheRocketEquation();
            List<long> results = fuelCalc.TheTyrannyOfTheRocketEquationPart1(input);
            Assert.That(results[0], Is.EqualTo(2));
            Assert.That(results[1], Is.EqualTo(2));
            Assert.That(results[2], Is.EqualTo(654));
            Assert.That(results[3], Is.EqualTo(33583));
        }

        [Test]
        public void TheTyrannyOfTheRocketEquationTestActualData()
        {
            List<int> input = new List<int>
            {
                50962, 126857, 127476, 136169, 62054, 116866, 123235, 147126, 146767, 140795, 54110, 106452, 98413,
                114925, 141914, 54864, 120093, 118166, 81996, 143924, 145941, 96950, 126488, 85764, 111438, 63278,
                147558, 128982, 123857, 58646, 80757, 98260, 97143, 136609, 99349, 63167, 142129, 144645, 97212, 70162,
                98044, 125931, 103859, 67890, 67797, 79263, 134255, 130303, 73367, 103091, 97315, 74892, 82311, 51157,
                79802, 138401, 108423, 63111, 61441, 102862, 53184, 125543, 147413, 117762, 106771, 115805, 66424,
                85851, 53101, 82736, 136768, 130745, 140135, 101770, 55349, 143419, 60108, 84990, 91544, 75240, 92709,
                134369, 140901, 59910, 63641, 54966, 104671, 71950, 60358, 127289, 147362, 70799, 82870, 108630, 53450,
                106888, 129843, 53227, 58758, 137751
            };
            var fuelCalc = new Day1TheTyrannyOfTheRocketEquation();
            var results = fuelCalc.TheTyrannyOfTheRocketEquationPart1(input);

            Assert.That(results.Sum(), Is.EqualTo(3336439));
        }

        [Test]
        public void TheTyrannyOfTheRocketEquationTestActualDataPartTwoExample1()
        {
            var fuelCalc = new Day1TheTyrannyOfTheRocketEquation();
            var result = fuelCalc.TheTyrannyOfTheRocketEquationPart2(new List<int> { 12 });

            Assert.That(result.Sum(), Is.EqualTo(2));
        }

        [Test]
        public void TheTyrannyOfTheRocketEquationTestActualDataPartTwoExample2()
        {
            var fuelCalc = new Day1TheTyrannyOfTheRocketEquation();
            var result = fuelCalc.TheTyrannyOfTheRocketEquationPart2(new List<int> { 1969 });
            Assert.That(result.Sum(), Is.EqualTo(966));
        }

        [Test]
        public void TheTyrannyOfTheRocketEquationPart2TestActualData()
        {
            List<int> input = new List<int>
            {
                50962, 126857, 127476, 136169, 62054, 116866, 123235, 147126, 146767, 140795, 54110, 106452, 98413,
                114925, 141914, 54864, 120093, 118166, 81996, 143924, 145941, 96950, 126488, 85764, 111438, 63278,
                147558, 128982, 123857, 58646, 80757, 98260, 97143, 136609, 99349, 63167, 142129, 144645, 97212, 70162,
                98044, 125931, 103859, 67890, 67797, 79263, 134255, 130303, 73367, 103091, 97315, 74892, 82311, 51157,
                79802, 138401, 108423, 63111, 61441, 102862, 53184, 125543, 147413, 117762, 106771, 115805, 66424,
                85851, 53101, 82736, 136768, 130745, 140135, 101770, 55349, 143419, 60108, 84990, 91544, 75240, 92709,
                134369, 140901, 59910, 63641, 54966, 104671, 71950, 60358, 127289, 147362, 70799, 82870, 108630, 53450,
                106888, 129843, 53227, 58758, 137751
            };
            var fuelCalc = new Day1TheTyrannyOfTheRocketEquation();
            var result = fuelCalc.TheTyrannyOfTheRocketEquationPart2(input);

            Assert.That(result.Sum(), Is.EqualTo(5001791));
        }
    }
}