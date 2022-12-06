namespace AdventOfConsole;

public static class Y2022D02
{
    public static string Part1(string[] data)
    {
        var sum = 0;
        var x = 0;
        foreach (var game in data)
        {
            x++;
            var result = 0;
            var scores = game.Split(' ');
            var opponentScore = GetDraw(scores[0]);
            var ownScore = GetDraw(scores[1]);

            result = ownScore.Item2 + GetScore(ownScore.Item1, opponentScore.Item1);

            sum += result;
            Console.WriteLine($"{x} - {scores[0]} vs {scores[1]} - {result} - {sum}");
        }
        return sum.ToString();
    }

    public static string Part2(string[] data)
    {
        var sum = 0;
        var x = 0;
        foreach (var game in data)
        {
            x++;
            var result = 0;
            var scores = game.Split(' ');
            var opponentScore = GetDraw(scores[0]);
            var ownScore = GetMyDraw(scores[1], opponentScore.Item1);

            result = ownScore.Item2 + GetScore(ownScore.Item1, opponentScore.Item1);

            sum += result;
            Console.WriteLine($"{x} - {scores[0]} vs {scores[1]} - {result} - {sum}");
        }
        return sum.ToString();
    }

    private static int GetScore(Draw mine, Draw theirs)
    {
        if (mine == theirs)
        {
            return 3;
        }
        else if ((mine == Draw.Rock && theirs == Draw.Sciccors)
              || (mine == Draw.Paper && theirs == Draw.Rock)
              || (mine == Draw.Sciccors && theirs == Draw.Paper))
        {
            return 6;
        }
        else
        {
            return 0;
        }
    }

    private static (Draw, int) GetMyDraw(string outcome, Draw their)
    {
        if (outcome == "Y")
        {
            return their switch
            {
                Draw.Rock => (Draw.Rock, 1),
                Draw.Paper => (Draw.Paper, 2),
                Draw.Sciccors => (Draw.Sciccors, 3),
                _ => throw new Exception("biep bop")
            };
        }
        else if (outcome == "Z")
        {
            return their switch
            {
                Draw.Rock => (Draw.Paper, 2),
                Draw.Paper => (Draw.Sciccors, 3),
                Draw.Sciccors => (Draw.Rock, 1),
                _ => throw new Exception("biep bop")
            };
        }
        else if (outcome == "X")
        {
            return their switch
            {
                Draw.Rock => (Draw.Sciccors, 3),
                Draw.Paper => (Draw.Rock, 1),
                Draw.Sciccors => (Draw.Paper, 2),
                _ => throw new Exception("biep bop")
            };
        }
        throw new Exception("biep bop");
    }

    private static (Draw, int) GetDraw(string draw)
        => draw switch
        {
            "X" => (Draw.Rock, 1),
            "Y" => (Draw.Paper, 2),
            "Z" => (Draw.Sciccors, 3),
            "A" => (Draw.Rock, 1),
            "B" => (Draw.Paper, 2),
            "C" => (Draw.Sciccors, 3),
            _ => throw new Exception("bad draw input")
        };

    private enum Draw
    {
        Rock,
        Paper,
        Sciccors
    }
}
