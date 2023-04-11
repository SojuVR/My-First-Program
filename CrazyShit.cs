// See https://aka.ms/new-console-template for more information

//Change the appearance

//Start a conversation

Console.Title = "My First Program";
Console.WindowHeight = 40;

TextColor.wl("Hi!");

TextColor.rl();

TextColor.wl("You suck at typing.");

TextColor.rl();

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Don't care, didn't ask.");

TextColor.wl("What is your name? I know it, just curious if it is you on the screen.");

PlayerInfo.playerinfo();

Activities.activities();

TextColor.wl("This is the end of my first program. Thanks!");
//Wait before closing
Console.ReadKey();

