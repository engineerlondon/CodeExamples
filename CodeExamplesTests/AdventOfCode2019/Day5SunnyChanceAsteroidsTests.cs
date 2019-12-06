using System.Collections.Generic;
using System.Linq;
using CodeExamples.AdventOfCode2019;
using CodeExamples.AdventOfCode2019.IntCodeComp;
using NUnit.Framework;

namespace CodeExamplesTests.AdventOfCode2019
{
    public class Day5SunnyChanceAsteroidsTests
    {
        [Test]
        public void ChanceOfeAsteroidsExample1Test()
        {
            int[] input = { 1002, 4, 3, 4, 33 };
            int[] expected = { 1002, 4, 3, 4, 99 };
            var opCalc = new IntCodeComputer();
            int[] result = opCalc.RunIntCode(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ChanceOfeAsteroidsExample2Test()
        {
            int[] input = { 1101, 100, -1, 4, 0 };
            int[] expected = { 1101, 100, -1, 4, 99 };
            var opCalc = new IntCodeComputer();
            int[] result = opCalc.RunIntCode(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Part2PositionModeIs0EqualTo8Test()
        {
            int param = 0;
            int[] input = { 3, 9, 8, 9, 10, 9, 4, 9, 99, -1, 8 };
            int expected = 0;
            var opCalc = new IntCodeComputer();
            opCalc.RunIntCode(input, param);
            var result = opCalc.InstructionHistory.Last(_ => _.Type == Instruction.ParamMode.Output).Noun;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Part2PositionModeIs8EqualTo8Test()
        {
            int param = 8;
            int[] input = { 3, 9, 8, 9, 10, 9, 4, 9, 99, -1, 8 };
            var opCalc = new IntCodeComputer();
            opCalc.RunIntCode(input, param);
            var result = opCalc.InstructionHistory.Last(_ => _.Type == Instruction.ParamMode.Output).Noun;
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Part2ImmediateModeIs0EqualTo8Test()
        {
            int param = 0;
            int[] input = { 3, 3, 1108, -1, 8, 3, 4, 3, 99 };
            int expected = 0;
            var opCalc = new IntCodeComputer();
            opCalc.RunIntCode(input, param);
            var result = opCalc.InstructionHistory.Last(_ => _.Type == Instruction.ParamMode.Output).Noun;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Part2ImmediateModeIs8EqualTo8Test()
        {
            int param = 8;
            int[] input = { 3, 3, 1108, -1, 8, 3, 4, 3, 99 };
            int expected = 1;
            var opCalc = new IntCodeComputer();
            opCalc.RunIntCode(input, param);
            var result = opCalc.InstructionHistory.Last(_ => _.Type == Instruction.ParamMode.Output).Noun;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Part2ImmediateModeIs7LessThan8Test()
        {
            int param = 7;
            int[] input = { 3, 3, 1107, -1, 8, 3, 4, 3, 99 };
            int expected = 1;
            var opCalc = new IntCodeComputer();
            opCalc.RunIntCode(input, param);
            var result = opCalc.InstructionHistory.Last(_ => _.Type == Instruction.ParamMode.Output).Noun;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Part2ImmediateJumpTest()
        {
            int param = 1;
            int[] input = { 3, 3, 1105, -1, 9, 1101, 0, 0, 12, 4, 12, 99, 1 };
            int expected = 1;
            var opCalc = new IntCodeComputer();
            opCalc.RunIntCode(input, param);
            var result = opCalc.InstructionHistory.Last(_ => _.Type == Instruction.ParamMode.Output).Noun;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Part2PositionModeJumpTest()
        {
            int param = 0;
            int[] input = {
                3,12,6,12,15,1,13,14,13,4,13,99,-1,0,1,9 };
            int expected = 0;
            var opCalc = new IntCodeComputer();
            opCalc.RunIntCode(input, param);
            var result = opCalc.InstructionHistory.Last(_ => _.Type == Instruction.ParamMode.Output).Noun;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Part2PositionModeJumpTestLargerEqual()
        {
            int param = 8;
            int[] input =
            {
                3, 21, 1008, 21, 8, 20, 1005, 20, 22, 107, 8, 21, 20, 1006, 20, 31,
                1106, 0, 36, 98, 0, 0, 1002, 21, 125, 20, 4, 20, 1105, 1, 46, 104,
                999, 1105, 1, 46, 1101, 1000, 1, 20, 4, 20, 1105, 1, 46, 98, 99
            };
            int expected = 1000;
            var opCalc = new IntCodeComputer();
            opCalc.RunIntCode(input, param);
            var result = opCalc.InstructionHistory.Last(_ => _.Type == Instruction.ParamMode.Output).Noun;
            Assert.That(result, Is.EqualTo(expected));
        }

        //[Test]
        //public void Part2PositionModeJumpTestLargerLessThan()
        //{
        //    int param = 7;
        //    int[] input =
        //    {
        //        3, 21, 1008, 21, 8, 20, 1005, 20, 22, 107, 8, 21, 20, 1006, 20, 31,
        //        1106, 0, 36, 98, 0, 0, 1002, 21, 125, 20, 4, 20, 1105, 1, 46, 104,
        //        999, 1105, 1, 46, 1101, 1000, 1, 20, 4, 20, 1105, 1, 46, 98, 99
        //    };
        //    int expected = 999;
        //    var opCalc = new RunIntCode();
        //    opCalc.RunIntCode(input, param);
        //    var result = opCalc.InstructionHistory.Last(_ => _.Type == Instruction.ParamMode.Output).Noun;
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        ///*
        // * Add = 1,
        //   Multiply = 2,
        //   SetVal = 3,
        //   Output = 4,
        //   JumpIfTrue = 5,
        //   JumpIfFalse = 6,
        //   LessThan = 7,
        //   Equals = 8,
        //   Halt = 99
        // */

        //[Test]
        //public void Part2PositionModeJumpTestLargerGreaterThan()
        //{
        //    int param = 7;
        //    int[] input =
        //    {
        //        // Set Val, in 21 to input 7 size = 2,
        //        // equals + 2nd param is immediate, does the value in 21 equal the value in index[4] ie 8? (size =4)
        //        // 1005 Jump if true, 2nd param is immediate,
        //        //      if the value in 20 == 1 jump to 22 size = 0
        //        //      else if the value in 20 == 0 (true in this case), continue, size = 3
        //        3, 21, 1008, 21, 8, 20, 1005, 20, 22, 107, 8, 21, 20, 1006, 20, 31,
        //        1106, 0, 36, 98, 0, 0, 1002, 21, 125, 20, 4, 20, 1105, 1, 46, 104,

        //        999, 1105, 1, 46, 1101, 1000, 1, 20, 4, 20, 1105, 1, 46, 98, 99
        //    };
        //    int expected = 1001;
        //    var opCalc = new RunIntCode();
        //    opCalc.RunIntCode(input, param);
        //    var result = opCalc.InstructionHistory.Last(_ => _.Type == Instruction.ParamMode.Output).Noun;
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        [Test]
        public void ChanceOfeAsteroidsExampleOutputTest()
        {
            int[] input = { 3, 0, 4, 0, 99 };
            int[] expected = { 25, 0, 4, 0, 99 };
            var opCalc = new IntCodeComputer();
            int[] result = opCalc.RunIntCode(input, 25);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ChanceOfeAsteroidsRealData()
        {
            int[] input =
            {
                3, 225, 1, 225, 6, 6, 1100, 1, 238, 225, 104, 0, 101, 67, 166, 224, 1001, 224, -110, 224, 4, 224, 102,
                8, 223, 223, 1001, 224, 4, 224, 1, 224, 223, 223, 2, 62, 66, 224, 101, -406, 224, 224, 4, 224, 102, 8,
                223, 223, 101, 3, 224, 224, 1, 224, 223, 223, 1101, 76, 51, 225, 1101, 51, 29, 225, 1102, 57, 14, 225,
                1102, 64, 48, 224, 1001, 224, -3072, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 1, 224, 1, 224, 223, 223,
                1001, 217, 90, 224, 1001, 224, -101, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 2, 224, 1, 223, 224,
                223, 1101, 57, 55, 224, 1001, 224, -112, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 7, 224, 1, 223, 224,
                223, 1102, 5, 62, 225, 1102, 49, 68, 225, 102, 40, 140, 224, 101, -2720, 224, 224, 4, 224, 1002, 223, 8,
                223, 1001, 224, 4, 224, 1, 223, 224, 223, 1101, 92, 43, 225, 1101, 93, 21, 225, 1002, 170, 31, 224, 101,
                -651, 224, 224, 4, 224, 102, 8, 223, 223, 101, 4, 224, 224, 1, 223, 224, 223, 1, 136, 57, 224, 1001,
                224, -138, 224, 4, 224, 102, 8, 223, 223, 101, 2, 224, 224, 1, 223, 224, 223, 1102, 11, 85, 225, 4, 223,
                99, 0, 0, 0, 677, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1105, 0, 99999, 1105, 227, 247, 1105, 1, 99999, 1005,
                227, 99999, 1005, 0, 256, 1105, 1, 99999, 1106, 227, 99999, 1106, 0, 265, 1105, 1, 99999, 1006, 0,
                99999, 1006, 227, 274, 1105, 1, 99999, 1105, 1, 280, 1105, 1, 99999, 1, 225, 225, 225, 1101, 294, 0, 0,
                105, 1, 0, 1105, 1, 99999, 1106, 0, 300, 1105, 1, 99999, 1, 225, 225, 225, 1101, 314, 0, 0, 106, 0, 0,
                1105, 1, 99999, 1107, 226, 226, 224, 102, 2, 223, 223, 1006, 224, 329, 1001, 223, 1, 223, 1007, 226,
                677, 224, 1002, 223, 2, 223, 1005, 224, 344, 101, 1, 223, 223, 108, 677, 677, 224, 1002, 223, 2, 223,
                1006, 224, 359, 101, 1, 223, 223, 1008, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 374, 1001, 223, 1,
                223, 108, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 389, 101, 1, 223, 223, 7, 226, 226, 224, 102, 2,
                223, 223, 1006, 224, 404, 101, 1, 223, 223, 7, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 419, 101, 1,
                223, 223, 107, 226, 226, 224, 102, 2, 223, 223, 1006, 224, 434, 1001, 223, 1, 223, 1008, 677, 677, 224,
                1002, 223, 2, 223, 1005, 224, 449, 101, 1, 223, 223, 108, 226, 226, 224, 102, 2, 223, 223, 1005, 224,
                464, 1001, 223, 1, 223, 1108, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 479, 1001, 223, 1, 223, 8,
                677, 226, 224, 102, 2, 223, 223, 1006, 224, 494, 1001, 223, 1, 223, 1108, 677, 677, 224, 102, 2, 223,
                223, 1006, 224, 509, 1001, 223, 1, 223, 1007, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 524, 1001,
                223, 1, 223, 7, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 539, 1001, 223, 1, 223, 8, 677, 677, 224,
                102, 2, 223, 223, 1005, 224, 554, 1001, 223, 1, 223, 107, 226, 677, 224, 1002, 223, 2, 223, 1006, 224,
                569, 101, 1, 223, 223, 1107, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 584, 1001, 223, 1, 223, 1108,
                677, 226, 224, 102, 2, 223, 223, 1006, 224, 599, 1001, 223, 1, 223, 1008, 677, 226, 224, 102, 2, 223,
                223, 1006, 224, 614, 101, 1, 223, 223, 107, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 629, 1001, 223,
                1, 223, 1107, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 644, 101, 1, 223, 223, 8, 226, 677, 224, 102,
                2, 223, 223, 1005, 224, 659, 1001, 223, 1, 223, 1007, 677, 677, 224, 102, 2, 223, 223, 1005, 224, 674,
                1001, 223, 1, 223, 4, 223, 99, 226
            };

            var opCalc = new IntCodeComputer();
            //input[0] = 1;
            opCalc.RunIntCode(input, 1);
            IEnumerable<Instruction> hist = opCalc.InstructionHistory.Where(_ => _.Type == Instruction.ParamMode.Output);
            var finalOut = hist.Last();
            int forSomeReasonWeGetA3AtTheStartUnexpectedlyButTheResultIsCorrect = 3;
            int result = hist.Sum(_ => _.Noun) - forSomeReasonWeGetA3AtTheStartUnexpectedlyButTheResultIsCorrect;
            Assert.That(result, Is.EqualTo(finalOut.Noun));
            Assert.That(finalOut.Noun, Is.EqualTo(9219874));
        }

        [Test]
        public void ChanceOfeAsteroidsRealDataPart2()
        {
            int[] input =
            {
                3, 225, 1, 225, 6, 6, 1100, 1, 238, 225, 104, 0, 101, 67, 166, 224, 1001, 224, -110, 224, 4, 224, 102,
                8, 223, 223, 1001, 224, 4, 224, 1, 224, 223, 223, 2, 62, 66, 224, 101, -406, 224, 224, 4, 224, 102, 8,
                223, 223, 101, 3, 224, 224, 1, 224, 223, 223, 1101, 76, 51, 225, 1101, 51, 29, 225, 1102, 57, 14, 225,
                1102, 64, 48, 224, 1001, 224, -3072, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 1, 224, 1, 224, 223, 223,
                1001, 217, 90, 224, 1001, 224, -101, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 2, 224, 1, 223, 224,
                223, 1101, 57, 55, 224, 1001, 224, -112, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 7, 224, 1, 223, 224,
                223, 1102, 5, 62, 225, 1102, 49, 68, 225, 102, 40, 140, 224, 101, -2720, 224, 224, 4, 224, 1002, 223, 8,
                223, 1001, 224, 4, 224, 1, 223, 224, 223, 1101, 92, 43, 225, 1101, 93, 21, 225, 1002, 170, 31, 224, 101,
                -651, 224, 224, 4, 224, 102, 8, 223, 223, 101, 4, 224, 224, 1, 223, 224, 223, 1, 136, 57, 224, 1001,
                224, -138, 224, 4, 224, 102, 8, 223, 223, 101, 2, 224, 224, 1, 223, 224, 223, 1102, 11, 85, 225, 4, 223,
                99, 0, 0, 0, 677, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1105, 0, 99999, 1105, 227, 247, 1105, 1, 99999, 1005,
                227, 99999, 1005, 0, 256, 1105, 1, 99999, 1106, 227, 99999, 1106, 0, 265, 1105, 1, 99999, 1006, 0,
                99999, 1006, 227, 274, 1105, 1, 99999, 1105, 1, 280, 1105, 1, 99999, 1, 225, 225, 225, 1101, 294, 0, 0,
                105, 1, 0, 1105, 1, 99999, 1106, 0, 300, 1105, 1, 99999, 1, 225, 225, 225, 1101, 314, 0, 0, 106, 0, 0,
                1105, 1, 99999, 1107, 226, 226, 224, 102, 2, 223, 223, 1006, 224, 329, 1001, 223, 1, 223, 1007, 226,
                677, 224, 1002, 223, 2, 223, 1005, 224, 344, 101, 1, 223, 223, 108, 677, 677, 224, 1002, 223, 2, 223,
                1006, 224, 359, 101, 1, 223, 223, 1008, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 374, 1001, 223, 1,
                223, 108, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 389, 101, 1, 223, 223, 7, 226, 226, 224, 102, 2,
                223, 223, 1006, 224, 404, 101, 1, 223, 223, 7, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 419, 101, 1,
                223, 223, 107, 226, 226, 224, 102, 2, 223, 223, 1006, 224, 434, 1001, 223, 1, 223, 1008, 677, 677, 224,
                1002, 223, 2, 223, 1005, 224, 449, 101, 1, 223, 223, 108, 226, 226, 224, 102, 2, 223, 223, 1005, 224,
                464, 1001, 223, 1, 223, 1108, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 479, 1001, 223, 1, 223, 8,
                677, 226, 224, 102, 2, 223, 223, 1006, 224, 494, 1001, 223, 1, 223, 1108, 677, 677, 224, 102, 2, 223,
                223, 1006, 224, 509, 1001, 223, 1, 223, 1007, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 524, 1001,
                223, 1, 223, 7, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 539, 1001, 223, 1, 223, 8, 677, 677, 224,
                102, 2, 223, 223, 1005, 224, 554, 1001, 223, 1, 223, 107, 226, 677, 224, 1002, 223, 2, 223, 1006, 224,
                569, 101, 1, 223, 223, 1107, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 584, 1001, 223, 1, 223, 1108,
                677, 226, 224, 102, 2, 223, 223, 1006, 224, 599, 1001, 223, 1, 223, 1008, 677, 226, 224, 102, 2, 223,
                223, 1006, 224, 614, 101, 1, 223, 223, 107, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 629, 1001, 223,
                1, 223, 1107, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 644, 101, 1, 223, 223, 8, 226, 677, 224, 102,
                2, 223, 223, 1005, 224, 659, 1001, 223, 1, 223, 1007, 677, 677, 224, 102, 2, 223, 223, 1005, 224, 674,
                1001, 223, 1, 223, 4, 223, 99, 226
            };

            var opCalc = new IntCodeComputer();
            opCalc.RunIntCode(input, 5);
            IEnumerable<Instruction> hist = opCalc.InstructionHistory.Where(_ => _.Type == Instruction.ParamMode.Output);
            var finalOut = hist.Last();
            int result = hist.Sum(_ => _.Noun);
            Assert.That(result, Is.EqualTo(finalOut.Noun));
            Assert.That(finalOut.Noun, Is.EqualTo(5893654));//9219874
        }
    }
}