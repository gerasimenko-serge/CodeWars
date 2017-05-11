// https://www.codewars.com/kata/54ff0d1f355cfd20e60001fc

using System;

public static class Kata
{
    public static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
          if (n > 1 && n < 12)
            return Factorial(n - 1) * n;
        else throw new ArgumentOutOfRangeException("Sorry");
    }
}