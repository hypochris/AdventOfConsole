namespace AdventOfConsole;

public static class Y2022D04
{
    public static string Part1(string[] data)
    {
        var sum = 0;

        foreach (var draw in data)
        {
            var draws = draw.Split(',');
            var firsts = draws[0].Split('-');
            var seconds = draws[1].Split('-');

            var first = int.Parse(firsts[0]);
            var second = int.Parse(firsts[1]);
            var third = int.Parse(seconds[0]);
            var fourth = int.Parse(seconds[1]);

            Console.WriteLine($"{string.Join(", ", firsts)} - {string.Join(", ", seconds)}");

            if ((first >= third && second <= fourth) ||
                (first <= third && second >= fourth))
            {
                Console.WriteLine("yes");
                sum++;
            }
        }

        return sum.ToString();
    }

    public static string Part2(string[] data)
    {
        var sum = 0;

        foreach (var draw in data)
        {
            var draws = draw.Split(',');
            var firsts = draws[0].Split('-');
            var seconds = draws[1].Split('-');

            var first = int.Parse(firsts[0]);
            var second = int.Parse(firsts[1]);
            var third = int.Parse(seconds[0]);
            var fourth = int.Parse(seconds[1]);


            var firstRange = Enumerable.Range(first, second - first + 1);
            var secondRange = Enumerable.Range(third, fourth - third + 1);

            if (firstRange.Intersect(secondRange).Any())
            {
                Console.WriteLine("yes");
                sum++;
            }
        }

        return sum.ToString();
    }
}
