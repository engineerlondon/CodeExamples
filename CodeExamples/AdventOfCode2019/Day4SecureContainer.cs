using System;
using System.Collections.Generic;

namespace CodeExamples.AdventOfCode2019
{
    public class Day4SecureContainer
    {
        public int FindIntThatMatchesRules(int low, int high)
        {
            List<int> solutions = new List<int>();
            int counter = 0;
            /*
               It is a six-digit number.
               The value is within the range given in your puzzle input.
               Two adjacent digits are the same (like 22 in 122345).
               Going from left to right, the digits never decrease; they only ever increase or stay the same (like 111123 or 135679).

             */

            for (int i = low; i <= high; i++)
            {
                var numAsString = i.ToString();
                if (numAsString.Length != 6)
                    continue;
                var previous = '@';
                var twoAdjacent = false;

                foreach (var elem in numAsString.ToCharArray())
                {
                    if (elem == previous)
                    {
                        twoAdjacent = true;
                        break;
                    }
                    previous = elem;
                }
                if (!twoAdjacent)
                    continue;

                int previousCharVal = numAsString[5];
                bool increasing = true;
                for (int j = 4; j >= 0; j--)
                {
                    if (numAsString[j] > previousCharVal)
                    {
                        increasing = false;
                    }

                    previousCharVal = numAsString[j];
                }

                if (increasing)
                {
                    solutions.Add(i);
                    counter++;
                }
            }

            return counter;
        }
    }
}