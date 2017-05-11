// https://www.codewars.com/kata/590adadea658017d90000039

using System.Linq;
using System.Collections.Generic;

namespace CodeWars
{
    public class Kata
    {
        private Dictionary<int, int> multiply = new Dictionary<int, int>()
        {
            { 1, 0},
            { 2, 1},
            { 3, 10}
        };

        private Dictionary<string, int> points = new Dictionary<string, int>()
        {
            { "Jack", 1},
            { "Queen", 2},
            { "King", 3},
            { "Bar", 4},
            { "Cherry", 5},
            { "Seven", 6},
            { "Shell", 7},
            { "Bell", 8},
            { "Star", 9},
            { "Wild", 10}
        };

        public int fruit(List<string[]> reels, int[] spins)
        {
            var valuePoints = spins.Select((m, n) => reels[n][m]);
            var result = valuePoints.Select(m => points[m])
                                    .GroupBy(m => m)
                                    .Select(m => new { m.Key, Count = m.Count() })
                                    .OrderByDescending(m => m.Count)
                                    .ToList();


            return multiply[result[0].Count] * result[0].Key * (result.Any(m => m.Key == 10 && m.Count == 1) ? 2 : 1);
        }
    }
}