// https://www.codewars.com/kata/54ff3102c1bad923760001f3

using System.Linq;
using System.Collections.Generic;
public static class Kata
{
    public static int GetVowelCount(string str)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        return str.Count(ch => vowels.Contains(ch)); ;
    }
}
