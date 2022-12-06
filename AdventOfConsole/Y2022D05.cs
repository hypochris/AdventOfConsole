namespace AdventOfConsole;

public static class Y2022D05
{
    public static string Part1(string[] data)
    {
        var cargo = GetStacks(data);

        var on = false;
        foreach (var row in data)
        {
            if (on)
            {
                var steps = row.Split(' ');
                var step = int.Parse(steps[1]);
                var from = int.Parse(steps[3]);
                var to = int.Parse(steps[5]);

                Console.WriteLine($"{step} {from} {to}");

                for (var i = 0; i < step; i++)
                {
                    cargo[to - 1].Add(cargo[from - 1].Last());
                    cargo[from - 1].RemoveAt(cargo[from - 1].Count - 1);
                }
                foreach (var x in cargo)
                {
                    Console.WriteLine(string.Join(' ', x));
                }
                Console.WriteLine("\n");
            }
            else
            {
                on = row.Trim()?.Length == 0;
            }
        }

        return string.Join(null, cargo.Select(x => x.Last()));
    }

    public static string Part2(string[] data)
    {
        var cargo = GetStacks(data);

        var on = false;
        foreach (var row in data)
        {
            if (on)
            {
                var steps = row.Split(' ');
                var step = int.Parse(steps[1]);
                var from = int.Parse(steps[3]);
                var to = int.Parse(steps[5]);

                Console.WriteLine($"{step} {from} {to}");

                var newStack = new List<char>();
                for (var i = 0; i < step; i++)
                {
                    newStack = newStack.Prepend(cargo[from - 1].Last()).ToList();
                    cargo[from - 1].RemoveAt(cargo[from - 1].Count - 1);
                }
                cargo[to - 1].AddRange(newStack);
                foreach (var x in cargo)
                {
                    Console.WriteLine(string.Join(' ', x));
                }
                Console.WriteLine("\n");
            }
            else
            {
                on = row.Trim()?.Length == 0;
            }
        }

        return string.Join(null, cargo.Select(x => x.Last()));
    }

    private static List<List<char>> GetStacks(string[] data)
    {
        var cargo1 = new List<List<char>>();

        foreach (var row in data)
        {
            if (int.TryParse(row[1].ToString(), out _))
                break;

            var stack = new List<char>();

            for (var i = 1; i < row.Length; i += 4)
            {
                stack = stack.Append(row[i]).ToList();
            }
            cargo1 = cargo1.Append(stack).ToList();
        }

        var cargo = new List<List<char>>();
        for (int i = 0; i < cargo1[0].Count; i++)
        {
            var stack = new List<char>();
            for (int j = 0; j < cargo1.Count; j++)
            {
                if (cargo1[j][i] != ' ')
                    stack = stack.Prepend(cargo1[j][i]).ToList();
            }
            cargo = cargo.Append(stack).ToList();
        }

        foreach (var x in cargo)
        {
            Console.WriteLine(string.Join(' ', x));
        }
        Console.WriteLine("\n");

        return cargo;
    }
}
