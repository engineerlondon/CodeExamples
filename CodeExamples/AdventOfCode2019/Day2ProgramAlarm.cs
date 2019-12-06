using System;
using System.Collections.Generic;

namespace CodeExamples.AdventOfCode2019
{
    public class Day2ProgramAlarm
    {
        public List<Instruction> InstructionHistory = new List<Instruction>();

        public int[] IntCodeComputer(int[] arr, int systemId = 0)
        {
            int stepsForward;
            for (int i = 0; i < arr.Length; i += stepsForward)
            {
                var instruction = new Instruction(arr, i, systemId);
                if (instruction.Type == Instruction.ParamMode.Halt)
                    return arr;

                InstructionHistory.Add(instruction);

                // re-factor this:
                stepsForward = ExecuteInstruction(arr, instruction, ref i);
            }

            return arr;
        }

        private static int ExecuteInstruction(int[] arr, Instruction instruction, ref int i)
        {
            if (instruction.Type == Instruction.ParamMode.Multiply)
                arr[instruction.Dest] = instruction.Noun * instruction.Verb;
            else if (instruction.Type == Instruction.ParamMode.Add)
                arr[instruction.Dest] = instruction.Noun + instruction.Verb;
            else if (instruction.Type == Instruction.ParamMode.SetVal)
                arr[instruction.Dest] = instruction.Noun;
            else if (instruction.Type == Instruction.ParamMode.Output)
                Console.WriteLine(instruction.Noun);
            else if (instruction.Type == Instruction.ParamMode.JumpIfTrue)
            {
                if (instruction.Noun != 0)
                {
                    instruction.Size = 0;
                    i = instruction.Verb;
                }
            }
            else if (instruction.Type == Instruction.ParamMode.JumpIfFalse)
            {
                if (instruction.Noun == 0)
                {
                    instruction.Size = 0;
                    i = instruction.Verb;
                }
            }
            else if (instruction.Type == Instruction.ParamMode.LessThan)
            {
                if (instruction.Noun < instruction.Verb)
                    arr[instruction.Dest] = 1;
                else
                {
                    arr[instruction.Dest] = 0;
                }
            }
            else if (instruction.Type == Instruction.ParamMode.Equals)
            {
                if (instruction.Noun == instruction.Verb)
                    arr[instruction.Dest] = 1;
                else
                {
                    arr[instruction.Dest] = 0;
                }
            }
            return instruction.Size;
        }
    }

    public class Instruction
    {
        public enum ParamMode
        {
            Add = 1,
            Multiply = 2,
            SetVal = 3,
            Output = 4,
            JumpIfTrue = 5,
            JumpIfFalse = 6,
            LessThan = 7,
            Equals = 8,
            Halt = 99
        }

        public enum Mode
        {
            Position = 0,
            Immediate = 1
        }

        public Instruction(int[] arr, int i, int systemId)
        {
            Type = SetParamMode(arr[i]);
            if (Type == ParamMode.Halt)
                return;

            Mode[] mode = IntegerToIntArray(arr[i]);

            if (Type == ParamMode.SetVal)
            {
                Size = 2; // because systemId is passed in size is just 2.
                Noun = systemId;
                Dest = arr[i + 1];
            }
            else if (Type == ParamMode.Output)
            {
                Size = 2;
                Noun = mode[1] == Mode.Immediate ? arr[i + 1] : arr[arr[i + 1]];
            }
            else
            {
                if (Type == ParamMode.JumpIfTrue || Type == ParamMode.JumpIfFalse)
                    Size = 3;
                else
                    Size = 4;

                Noun = mode[0] == Mode.Immediate ? arr[i + 1] : arr[arr[i + 1]];
                Verb = mode[1] == Mode.Immediate ? arr[i + 2] : arr[arr[i + 2]];

                // The destination is currently always set using Immediate
                Dest = arr[i + 3];
            }
        }

        private ParamMode SetParamMode(int val)
        {
            if (val == 99)
                return ParamMode.Halt;

            return (ParamMode)(Math.Abs(val) % 10);
        }

        public int Noun { get; set; }
        public int Verb { get; set; }

        public ParamMode Type { get; set; }

        public int Dest { get; set; }
        public int Size { get; set; }

        public static Mode[] IntegerToIntArray(int i)
        {
            i /= 100; // skip the OpCode

            Mode[] digits = new Mode[3];
            for (int j = 0; j < 3; j++)
            {
                digits[j] = (Mode)(i % 10);
                i /= 10;
            }

            return digits;
        }
    }
}