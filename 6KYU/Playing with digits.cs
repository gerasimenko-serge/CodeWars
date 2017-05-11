// https://www.codewars.com/kata/5552101f47fc5178b1000050

using System;

public class DigPow
{
    public static long digPow(int n, int p)
    {
        double sum = 0;

        for (int i = 0; i < n.ToString().Length; i++)
        {
            sum += Math.Pow(Int32.Parse(n.ToString()[i].ToString()), p + i);
        }

        return sum % n == 0 ? Convert.ToInt32(sum) / n : -1;
    }
}