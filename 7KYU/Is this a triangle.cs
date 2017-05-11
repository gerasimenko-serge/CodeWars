// https://www.codewars.com/kata/56606694ec01347ce800001b

public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        return (a + b > c && b + c > a && a + c > b);
    }
}