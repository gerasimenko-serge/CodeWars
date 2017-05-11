// https://www.codewars.com/kata/5667e8f4e3f572a8f2000039

using System;
using System.Linq;

public static class Accumul
{
    public static String Accum(string s)
    {
        return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }
}