// https://www.codewars.com/kata/5541f58a944b85ce6d00006a

public class ProdFib
{
    public static ulong[] productFib(ulong prod)
    {
        // Time : 561ms
        ulong i = 0, flag = 1, result = 0;

        while (flag == 1)
        {
            result = fib(i) * fib(i + 1);
            if (result < prod)
                i++;
            else
            {
                if (result == prod)
                    break;
                else
                    flag = 0;
            }
        }

        return new ulong[3] { fib(i), fib(i + 1), flag };
    }

    static ulong fib(ulong n)
    {
        ulong[] f = new ulong[3];
        f[1] = 1;
        for (int i = 2; i <= (int)n; i++)
        {
            f[i % 3] = f[(i + 1) % 3] + f[(i + 2) % 3];
        }
        return f[n % 3];
    }
}