using System;
using System.Linq;
public class Kata
{
    public bool IsPrime(int number)
    {
        if (Math.Abs(number) > 1)
        {
            return Enumerable.Range(1, Math.Abs(number))
                    .Where(x => Math.Abs(number) % x == 0)
                    .SequenceEqual(new[] { 1, Math.Abs(number) });
        }
        return false;
    }
}