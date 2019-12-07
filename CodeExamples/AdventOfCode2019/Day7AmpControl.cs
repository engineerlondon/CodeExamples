using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeExamples.AdventOfCode2019.IntCodeComp;

namespace CodeExamples.AdventOfCode2019
{
    public class Day7AmpControl
    {
        public int SendPowerToThrusters(int[] phaseSettingInput, int[] input)
        {
            int result = 0;
            foreach (var phaseSetting in phaseSettingInput)
            {
                result = Amplifier(input, phaseSetting, result);
            }

            return result;
        }

        private static int Amplifier(int[] input, int phaseSetting, int lastResult)
        {
            var comp = new IntCodeComputer();
            var queue = new Queue<int>();
            queue.Enqueue(phaseSetting);
            queue.Enqueue(lastResult);
            comp.RunIntCode(input, queue);
            IEnumerable<Instruction> hist = comp.InstructionHistory.Where(_ => _.Type == Instruction.ParamMode.Output);

            return hist.Last().Noun;
        }
    }
}