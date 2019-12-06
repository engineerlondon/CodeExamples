using System;
using System.Diagnostics;
using CodeExamples.AdventOfCode2019;
using CodeExamples.AdventOfCode2019.IntCodeComp;
using NUnit.Framework;

namespace CodeExamplesTests.AdventOfCode2019
{
    public class Day2ProgramAlarmTests
    {
        [Test]
        public void Day2ProgramAlarmExample0DataTest()
        {
            int[] input = { 1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50 };
            int[] expected = { 3500, 9, 10, 70, 2, 3, 11, 0, 99, 30, 40, 50 };
            var opCalc = new IntCodeComputer();
            int[] result = opCalc.RunIntCode(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Day2ProgramAlarmExample1DataTest()
        {
            int[] input = { 1, 0, 0, 0, 99 };
            int[] expected = { 2, 0, 0, 0, 99 };
            var opCalc = new IntCodeComputer();
            int[] result = opCalc.RunIntCode(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Day2ProgramAlarmExample2DataTest()
        {
            int[] input = { 2, 3, 0, 3, 99 };
            int[] expected = { 2, 3, 0, 6, 99 };
            var opCalc = new IntCodeComputer();
            int[] result = opCalc.RunIntCode(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Day2ProgramAlarmExample3DataTest()
        {
            int[] input = { 2, 4, 4, 5, 99, 0 };
            int[] expected = { 2, 4, 4, 5, 99, 9801 };
            var opCalc = new IntCodeComputer();
            int[] result = opCalc.RunIntCode(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Day2ProgramAlarmExample4DataTest()
        {
            int[] input = { 1, 1, 1, 4, 99, 5, 6, 0, 99 };
            int[] expected = { 30, 1, 1, 4, 2, 5, 6, 0, 99 };
            var opCalc = new IntCodeComputer();
            int[] result = opCalc.RunIntCode(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Day2ProgramAlarmRealData()
        {
            int[] input =
            {
                1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 6, 1, 19, 1, 19, 5, 23, 2, 9, 23, 27, 1, 5, 27, 31,
                1, 5, 31, 35, 1, 35, 13, 39, 1, 39, 9, 43, 1, 5, 43, 47, 1, 47, 6, 51, 1, 51, 13, 55, 1, 55, 9, 59, 1,
                59, 13, 63, 2, 63, 13, 67, 1, 67, 10, 71, 1, 71, 6, 75, 2, 10, 75, 79, 2, 10, 79, 83, 1, 5, 83, 87, 2,
                6, 87, 91, 1, 91, 6, 95, 1, 95, 13, 99, 2, 99, 13, 103, 1, 103, 9, 107, 1, 10, 107, 111, 2, 111, 13,
                115, 1, 10, 115, 119, 1, 10, 119, 123, 2, 13, 123, 127, 2, 6, 127, 131, 1, 13, 131, 135, 1, 135, 2, 139,
                1, 139, 6, 0, 99, 2, 0, 14, 0
            };
            input[1] = 12; // noun
            input[2] = 2; // verb
            var opCalc = new IntCodeComputer();
            int[] result = opCalc.RunIntCode(input);
            int outcome = result[0];
            Assert.That(outcome, Is.EqualTo(4090689));
        }

        [Test]
        public void Day2ProgramAlarmRealDataWhatNounAndVerbBruteForce()
        {
            // 77 33
            int noun = 0;
            int verb = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            bool found = false;
            for (int i = 0; i < 100; i++)
            {
                if (found)
                    break;
                for (int j = 0; j < 100; j++)
                {
                    int[] input =
                    {
                        1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 6, 1, 19, 1, 19, 5, 23, 2, 9, 23, 27, 1, 5,
                        27, 31, 1, 5, 31, 35, 1, 35, 13, 39, 1, 39, 9, 43, 1, 5, 43, 47, 1, 47, 6, 51, 1, 51, 13, 55, 1,
                        55, 9, 59, 1, 59, 13, 63, 2, 63, 13, 67, 1, 67, 10, 71, 1, 71, 6, 75, 2, 10, 75, 79, 2, 10, 79,
                        83, 1, 5, 83, 87, 2, 6, 87, 91, 1, 91, 6, 95, 1, 95, 13, 99, 2, 99, 13, 103, 1, 103, 9, 107, 1,
                        10, 107, 111, 2, 111, 13, 115, 1, 10, 115, 119, 1, 10, 119, 123, 2, 13, 123, 127, 2, 6, 127,
                        131, 1, 13, 131, 135, 1, 135, 2, 139, 1, 139, 6, 0, 99, 2, 0, 14, 0
                    };

                    input[1] = i; // noun
                    input[2] = j; // verb
                    var opCalc = new IntCodeComputer();
                    try
                    {
                        int[] result = opCalc.RunIntCode(input);
                        int outcome = result[0];
                        if (outcome == 19690720)
                        {
                            Console.WriteLine("Found solution " + i + " " + j);
                            noun = i;
                            verb = j;
                            found = true;
                            break;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        // we don't care, we are brute forcing the value.
                    }
                }
            }

            Console.WriteLine($"Done {sw.Elapsed}");

            int[] inputVerify =
            {
                1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 6, 1, 19, 1, 19, 5, 23, 2, 9, 23, 27, 1, 5,
                27, 31, 1, 5, 31, 35, 1, 35, 13, 39, 1, 39, 9, 43, 1, 5, 43, 47, 1, 47, 6, 51, 1, 51, 13, 55, 1,
                55, 9, 59, 1, 59, 13, 63, 2, 63, 13, 67, 1, 67, 10, 71, 1, 71, 6, 75, 2, 10, 75, 79, 2, 10, 79,
                83, 1, 5, 83, 87, 2, 6, 87, 91, 1, 91, 6, 95, 1, 95, 13, 99, 2, 99, 13, 103, 1, 103, 9, 107, 1,
                10, 107, 111, 2, 111, 13, 115, 1, 10, 115, 119, 1, 10, 119, 123, 2, 13, 123, 127, 2, 6, 127,
                131, 1, 13, 131, 135, 1, 135, 2, 139, 1, 139, 6, 0, 99, 2, 0, 14, 0
            };

            inputVerify[1] = noun; //77
            inputVerify[2] = verb; //33
            var verifyCalc = new IntCodeComputer();
            int[] verify = verifyCalc.RunIntCode(inputVerify);
            Assert.That(verify[0], Is.EqualTo(19690720));
            Console.WriteLine(100 * noun + verb);
        }
    }
}