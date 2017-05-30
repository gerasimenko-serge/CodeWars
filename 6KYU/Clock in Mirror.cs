public class Kata
{
    public static string WhatIsTheTime(string timeInMirror)
    {
        var hourInMirror = 12 - int.Parse(timeInMirror.Substring(0, 2));
        var minuteInMirror = (60 - int.Parse(timeInMirror.Substring(3))) % 60;
        if (minuteInMirror != 0) --hourInMirror;
        if (hourInMirror <= 0) hourInMirror += 12;
        return $"{hourInMirror:00}:{minuteInMirror:00}";
    }
}
        