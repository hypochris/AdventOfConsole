using AdventOfConsole;

try
{
    var dataPath = Environment.GetCommandLineArgs()[1];
    var part = int.Parse(Environment.GetCommandLineArgs()[2]);

    var filename = Path.GetFileNameWithoutExtension(dataPath);

    var data = File.ReadAllLines(dataPath);

    var result = ((filename, part)) switch
    {
        ("202201", 1) => Y2022D01.Part1(data),
        ("202201", 2) => Y2022D01.Part2(data),
        ("202202", 1) => Y2022D02.Part1(data),
        ("202202", 2) => Y2022D02.Part2(data),
        ("202203", 1) => Y2022D03.Part1(data),
        ("202203", 2) => Y2022D03.Part2(data),
        ("202204", 1) => Y2022D04.Part1(data),
        ("202204", 2) => Y2022D04.Part2(data),
        ("202205", 1) => Y2022D05.Part1(data),
        ("202205", 2) => Y2022D05.Part2(data),
        ("202206", 1) => Y2022D06.Part1(data),
        ("202206", 2) => Y2022D06.Part2(data),
        _ => "Nothing to run",
    };

    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine("Error getting arguments");
    Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
}
