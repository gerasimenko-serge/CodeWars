using System;
using System.Linq;
public class Kata
{
    public bool IsPrime(int number)
    {
        var t = Math.Abs(number);
        var a = (int)t / 2;
        var p = Enumerable.Range(2, (int)t / 2)
            .Select(x => t % x != 0);
        var p1 = p.Min();
        return p1;
    }
}