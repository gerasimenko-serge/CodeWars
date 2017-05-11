// https://www.codewars.com/kata/583203e6eb35d7980400002a

using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
    public static int CountSmileys(string[] smileys)
    {
        return smileys.Count(word => Regex.IsMatch(word, @"[:;][-~]{0,1}[D)]"));
    }
}
