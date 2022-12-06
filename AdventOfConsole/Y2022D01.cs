using System;

namespace AdventOfConsole;
public static class Y2022D01
{
    public static string Part1(string[] data)
    {
        var most = 0;
        var sum = 0;
        foreach (var d in data)
        {
            var isElve = !int.TryParse(d, out _);
            var x = !isElve ? int.Parse(d) : 0;

            if (isElve)
                sum = 0;

            sum += x;

            if (sum > most)
                most = sum;
        }
        return most.ToString();
    }

    public static string Part2(string[] data)
    {
        var most = new int[3] { 0, 0, 0 };
        var sum = 0;
        foreach (var d in data)
        {
            var isElve = !int.TryParse(d, out _);
            var x = !isElve ? int.Parse(d) : 0;

            if (isElve)
                sum = 0;

            sum += x;

            if (sum > most[0])
            {
                most[0] = sum;
                most = most.OrderBy(x => x).ToArray();
            }
        }
        return most.Sum().ToString();
    }
}
