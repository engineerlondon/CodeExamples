using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CodeExamples.AdventOfCode2019
{
    public class Day2ProgramAlarm
    {
        public List<Instruction> Instruction = new List<Instruction>();

        public int[] IntCodeComputer(int[] arr)
        {
            for (int i = 0; i < arr.Length; i += 4)
            {
                if (arr[i].Equals(99))
                    return arr;

                var instruction = new Instruction
                {
                    Noun = arr[arr[i + 1]],
                    Verb = arr[arr[i + 2]],
                    Dest = arr[i + 3],
                    Type = arr[i]
                };

                this.Instruction.Add(instruction);

                if (instruction.Type.Equals(1))
                    arr[instruction.Dest] = instruction.Noun + instruction.Verb;
                else if (arr[i].Equals(2))
                    arr[instruction.Dest] = instruction.Noun * instruction.Verb;
            }

            return arr;
        }
    }

    public class Instruction
    {
        public int Noun { get; set; }
        public int Verb { get; set; }

        public int Dest { get; set; }

        public int Type { get; set; }
    }
}