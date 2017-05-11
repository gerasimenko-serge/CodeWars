// https://www.codewars.com/kata/56747fd5cb988479af000028

public class Kata
{
    public static string GetMiddle(string s)
    {
        int index = s.Length / 2;
        return (s.Length % 2 == 1) ? s.Substring(index, 1) : s.Substring(index - 1, 2);
    }
}