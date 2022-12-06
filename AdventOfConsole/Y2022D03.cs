namespace AdventOfConsole;

public static class Y2022D03
{
    public static string Part1(string[] data)
    {
        var sum = 0;
        foreach (var content in data)
        {
            var result = 0;
            var front = content[..(content.Length / 2)];
            var back = content[(content.Length / 2)..];

            var shared = front.Intersect(back).Distinct().First();

            if (char.IsUpper(shared))
            {
                result = 26 + (shared % 32);
            }
            else
            {
                result = shared % 32;
            }

            Console.WriteLine($"{shared} {result}");

            sum += result;
        }

        return sum.ToString();
    }

    public static string Part2(string[] data)
    {
        var sum = 0;

        for (int i = 0; i < data.Length; i += 3)
        {
            var result = 0;
            var first = data[i].ToList();
            var second = data[i + 1].ToList();
            var third = data[i + 2].ToList();

            var badge = first.Intersect(second).Intersect(third).First();

            if (char.IsUpper(badge))
            {
                result = 26 + (badge % 32);
            }
            else
            {
                result = badge % 32;
            }
            sum += result;
        }
        return sum.ToString();
    }
}
