using System.Collections.Generic;
using System.Linq;

namespace CodeExamples.AdventOfCode2019.Day6
{
    public static class Permutations
    {
        //https://codereview.stackexchange.com/questions/226804/linq-for-generating-all-possible-permutations
        public static IEnumerable<T[]> Permutate<T>(this IEnumerable<T> source)
        {
            return permutate(source, Enumerable.Empty<T>());
            IEnumerable<T[]> permutate(IEnumerable<T> reminder, IEnumerable<T> prefix) =>
                !reminder.Any() ? new[] { prefix.ToArray() } :
                    reminder.SelectMany((c, i) => permutate(
                        reminder.Take(i).Concat(reminder.Skip(i + 1)).ToArray(),
                        prefix.Append(c)));
        }
    }
}