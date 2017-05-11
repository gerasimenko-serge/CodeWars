// https://www.codewars.com/kata/57a0e5c372292dd76d000d7e

using System.Linq;

namespace Solution
{
    public static class Program
    {
        public static string repeatStr(int n, string s)
        {
            return string.Join("", Enumerable.Repeat(s, n));
        }
    }
}