using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeExamples.AdventOfCode2019;
using CodeExamples.AdventOfCode2019.Day6;
using NUnit.Framework;

namespace CodeExamplesTests.AdventOfCode2019
{
    internal class Day7AmpControlTests
    {
        //find the largest output signal that can be sent to the thrusters
        [Test]
        public void AmpControlExample1Test()
        {
            Day7AmpControl ampControl = new Day7AmpControl();
            int[] phaseSettingInput = { 4, 3, 2, 1, 0 }; // each phase setting is used exactly once
            int[] input = { 3, 15, 3, 16, 1002, 16, 10, 16, 1, 16, 15, 15, 4, 15, 99, 0, 0 };
            int result = ampControl.SendPowerToThrusters(phaseSettingInput, input);
            Assert.That(result, Is.EqualTo(43210));
        }

        [Test]
        public void AmpControlExample2Test()
        {
            Day7AmpControl ampControl = new Day7AmpControl();
            int[] phaseSettingInput = { 0, 1, 2, 3, 4 }; // each phase setting is used exactly once
            int[] input = { 3,23,3,24,1002,24,10,24,1002,23,-1,23,
                101,5,23,23,1,24,23,23,4,23,99,0,0 };
            int result = ampControl.SendPowerToThrusters(phaseSettingInput, input);
            Assert.That(result, Is.EqualTo(54321));
        }

        [Test]
        public void AmpControlExample3Test()
        {
            Day7AmpControl ampControl = new Day7AmpControl();
            int[] phaseSettingInput = { 1, 0, 4, 3, 2 }; // each phase setting is used exactly once
            int[] input = { 3,31,3,32,1002,32,10,32,1001,31,-2,31,1007,31,0,33,
                1002,33,7,33,1,33,31,31,1,32,31,31,4,31,99,0,0,0 };
            int result = ampControl.SendPowerToThrusters(phaseSettingInput, input);
            Assert.That(result, Is.EqualTo(65210));
        }

        [Test]
        public void AmpControlActualDataTest()
        {
            Day7AmpControl ampControl = new Day7AmpControl();
            int[] input =
            {
                3, 8, 1001, 8, 10, 8, 105, 1, 0, 0, 21, 46, 67, 76, 101, 118, 199, 280, 361, 442, 99999, 3, 9, 1002, 9,
                4, 9, 1001, 9, 2, 9, 102, 3, 9, 9, 101, 3, 9, 9, 102, 2, 9, 9, 4, 9, 99, 3, 9, 1001, 9, 3, 9, 102, 2, 9,
                9, 1001, 9, 2, 9, 1002, 9, 3, 9, 4, 9, 99, 3, 9, 101, 3, 9, 9, 4, 9, 99, 3, 9, 1001, 9, 2, 9, 1002, 9,
                5, 9, 101, 5, 9, 9, 1002, 9, 4, 9, 101, 5, 9, 9, 4, 9, 99, 3, 9, 102, 2, 9, 9, 1001, 9, 5, 9, 102, 2, 9,
                9, 4, 9, 99, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101,
                1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101,
                1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 99, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9,
                1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9,
                102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9,
                101, 2, 9, 9, 4, 9, 99, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9,
                3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4,
                9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 99, 3, 9, 1002, 9, 2,
                9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9,
                9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 1, 9,
                9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 99, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101,
                2, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9,
                1001, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 99
            };

            List<int> phaseSettingInput = new List<int> { 0, 1, 2, 3, 4 }; // each phase setting is used exactly once

            int largest = 0;
            var enumerate = phaseSettingInput.Permutate();
            using (var enumeratePerms = enumerate.GetEnumerator())
            {
                while (enumeratePerms.MoveNext())
                {
                    int result = ampControl.SendPowerToThrusters(enumeratePerms.Current.ToArray(), input);
                    if (result > largest)
                        largest = result;
                }
            }

            Assert.That(largest, Is.EqualTo(87138));
        }
    }
}