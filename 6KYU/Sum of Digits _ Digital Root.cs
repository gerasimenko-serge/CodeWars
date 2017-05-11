// https://www.codewars.com/kata/541c8630095125aba6000c00

using System;
public class Number
{
    public int DigitalRoot(long n)
    {
        return (Convert.ToInt32(n % 9) == 0 && n > 0) ? 9 : Convert.ToInt32(n % 9);
    }
}
