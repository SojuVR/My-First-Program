class TextColor
{
    public static void wl(string line)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(line);
    }

    public static string rl()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        return Console.ReadLine();
    }
}