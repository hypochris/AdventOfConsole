namespace AdventOfConsole;

public static class Y2022D06
{
    public static string Part1(string[] data)
    {
        var result = 0;
        var input = data[0];
        for (int i = 0; i < input.Length - 5; i++)
        {
            if (input.Substring(i, 4).Distinct().Count() == 4)
            {
                result = i + 4;
                break;
            }
        }
        return result.ToString();
    }

    public static string Part2(string[] data)
    {
        var result = 0;
        var input = data[0];
        for (int i = 0; i < input.Length - 15; i++)
        {
            if (input.Substring(i, 14).Distinct().Count() == 14)
            {
                result = i + 14;
                break;
            }
        }
        return result.ToString();
    }
}
