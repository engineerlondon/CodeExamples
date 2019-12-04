using System.Collections.Generic;

namespace CodeExamples.AdventOfCode2019
{
    public class Day1TheTyrannyOfTheRocketEquation
    {
        public List<long> TheTyrannyOfTheRocketEquationPart1(List<int> input)
        {
            List<long> results = new List<long>(input.Count);
            foreach (var mass in input)
            {
                int divResult = mass / 3;
                int subResult = divResult - 2;
                results.Add(subResult);
            }

            return results;
        }

        public List<long> TheTyrannyOfTheRocketEquationPart2(List<int> input)
        {
            List<long> results = new List<long>(input.Count);
            foreach (var mass in input)
            {
                int divResult = mass / 3;
                int subResult = divResult - 2;
                long fuelForFuel = TheTyrannyOfTheRocketEquationPart2(subResult);
                results.Add(fuelForFuel);
            }

            return results;
        }

        private long TheTyrannyOfTheRocketEquationPart2(long input)
        {
            var additionalFuel = (input / 3) - 2;
            if (additionalFuel > 0)
                input += TheTyrannyOfTheRocketEquationPart2(additionalFuel);

            return input;
        }
    }
}