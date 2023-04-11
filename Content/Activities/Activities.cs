class Activities
{
    public static void activities()
    {
        TextColor.wl("Do some math for me, would you? I want to test your brain. Press 'Y' to begin.");
while (Console.ReadKey().Key != ConsoleKey.Y)
{
    ;
}
int answer = -1;
int attempts = 0;
while (answer != 6)
{
    Console.Write("\n4 * 3 / 2 = ");
    answer = -1;
    answer = FailSafe.Failsafe(answer);
    if (answer != 6)
    {
        TextColor.wl("Wrong! That's disappointing, try again.");
    }
    else
    {
        TextColor.wl("Correct!");
    }
    attempts++;
}
if (attempts == 1)
{
    TextColor.wl("Took you " + attempts + " try. That's all.");
}
else
{
    TextColor.wl("Took you " + attempts + " tries. That's all.");
}
TextColor.wl("I'm sure you know, but I'm just trying to get to know you.\nList your favorite movies for me. Type 'done' when finished.");
string movie = TextColor.rl().ToLower();
List<string> movies = new List<string>();
while (movie != "done")
{
    movies.Add(movie);
    movie = TextColor.rl().ToLower();
    if (string.IsNullOrWhiteSpace(movie))
    {
        TextColor.wl("I need you to actually type something.");
        movies.Remove(movie);
    }
}
if (movie == "done")
{
    movies.Remove("done");
}
TextColor.wl("\nCool! So your favorite movies are (alphabetically):");
movies.Sort();
for (int i = 0; i < movies.Count; i++)
{
    TextColor.wl(movies[i]);
}
TextColor.wl("\nAlright, let's see if you are smart enough to count.\nType any sentence.");
string sentence1 = TextColor.rl();
int wordcount1 = Words.words(sentence1);
TextColor.wl("How many words/numbers did you type? Give me a number.");
int answer01 = -1;
answer01 = FailSafe.Failsafe(answer01);
if (answer01 == wordcount1)
{
    TextColor.wl("Correct!");
}
else
{
    TextColor.wl("Wrong. You are stupid.");
}
TextColor.wl("Do it again. Type another sentence.");
string sentence2 = TextColor.rl();
int wordcount2 = Words.words(sentence2);
TextColor.wl("How many words/numbers did you type? Give me a number.");
int answer03 = -1;
answer03 = FailSafe.Failsafe(answer03);
if (answer03 == wordcount2)
{
    TextColor.wl("Correct!");
}
else
{
    TextColor.wl("Wrong. You are stupid.");
}
    }
}