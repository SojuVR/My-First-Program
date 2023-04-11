class PlayerInfo
{
    public static void playerinfo()
    {
        string username = TextColor.rl();

        TextColor.wl("Hello, " + username + ", figured you looked like that. You have pictures in the computer.");
        TextColor.wl("And are you male, female, or other?");
        
        string sex = TextColor.rl().ToLower();
        while (!sex.Contains("male") && !sex.Contains("female") && !sex.Contains("other"))
        {
            TextColor.wl("Sorry, I only know male, female, or other right now, still exploring.");
            sex = TextColor.rl().ToLower();
        }
        if (sex.Contains("male"))
        {
            sex = "male";
        }
        else if (sex.Contains("female"))
        {
            sex = "female";
        }
        else if (sex.Contains("other"))
        {
            sex = "other";
        }
        if (sex == "male" || sex == "female")
        {
            TextColor.wl("Ah, " + sex + ". You look it.");
        }
        TextColor.wl("And how old are you, " + username + "?"); //trying out response-based
        int age = -1;
        age = FailSafe.Failsafe(age);
        if (age >= 18)
        {
            TextColor.wl(age + "? You're a full adult then.");
        }
        else
        {
            TextColor.wl(age + "? Wow. Still young.");
        }
        TextColor.wl("And what is your height in inches?");
        int height = -1;
        height = FailSafe.Failsafe(height);
        if (height >= 70 && sex == "male")
        {
            TextColor.wl(height + "? You're kind of tall for a guy.");
        }
        else if (height >= 70 && sex == "female")
        {
            TextColor.wl(height + "? You're really tall for a girl.");
        }
        else if (height >= 70 && sex == "other")
        {
            TextColor.wl(height + "? You're really tall.");
        }
        else if (height >= 67 && height <= 69 && sex == "male")
        {
            TextColor.wl(height + "? EH, you're kind of average for a guy.");
        }
        else if (height >= 67 && height <= 69 && sex == "female")
        {
            TextColor.wl(height + "? You're pretty tall for a girl.");
        }
        else if (height >= 67 && height <= 69 && sex == "other")
        {
            TextColor.wl(height + "? You're somewhat average.");
        }
        else if (height < 67 && age < 18)
        {
            TextColor.wl(height + "? Short, but you are young and still growing.");
        }
        else if (height < 67 && sex == "female")
        {
            TextColor.wl(height + "? For a girl your shortness doesn't matter at this point.");
        }
        else if (height < 67 && sex == "male")
        {
            TextColor.wl(height + "? You're real short for a guy.");
        }
        else if (height < 67 && sex == "other")
        {
            TextColor.wl(height + "? Well, big personality!.");
        }
    }
}