using System;
using System.Collections.Generic;

namespace CodeExamples.AdventOfCode2019.IntCodeComp
{
    public class IntCodeComputer
    {
        public List<Instruction> InstructionHistory = new List<Instruction>();

        public int[] RunIntCode(int[] arr, int systemId = 0)
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
            switch (instruction.Type)
            {
                case Instruction.ParamMode.Multiply:
                    arr[instruction.Dest] = instruction.Noun * instruction.Verb;
                    break;

                case Instruction.ParamMode.Add:
                    arr[instruction.Dest] = instruction.Noun + instruction.Verb;
                    break;

                case Instruction.ParamMode.SetVal:
                    arr[instruction.Dest] = instruction.Noun;
                    break;

                case Instruction.ParamMode.Output:
                    Console.WriteLine(instruction.Noun);
                    break;

                case Instruction.ParamMode.JumpIfTrue:
                    if (instruction.Noun != 0)
                    {
                        instruction.Size = 0;
                        i = instruction.Verb;
                    }
                    break;

                case Instruction.ParamMode.JumpIfFalse:
                    if (instruction.Noun == 0)
                    {
                        instruction.Size = 0;
                        i = instruction.Verb;
                    }
                    break;

                case Instruction.ParamMode.LessThan:
                    if (instruction.Noun < instruction.Verb)
                        arr[instruction.Dest] = 1;
                    else
                        arr[instruction.Dest] = 0;
                    break;

                case Instruction.ParamMode.Equals:
                    if (instruction.Noun == instruction.Verb)
                        arr[instruction.Dest] = 1;
                    else
                        arr[instruction.Dest] = 0;
                    break;

                default:
                    throw new ArgumentException($"Un-handled instruction type encountered: {instruction.Type}");
            }

            return instruction.Size;
        }
    }
}