class FailSafe
{
    public static int Failsafe(int num)
    {
        while (num <= 0)
        {
            try
            {
                num = Convert.ToInt32(TextColor.rl());
                return num;
            }
            catch (System.Exception)
            {
                Random phrase = new Random();

                int choosephrase = 0;

                choosephrase = phrase.Next(1, 5);
                switch (choosephrase)
                {
                    case 1:
                        TextColor.wl("Please type just a number.");
                        break;
                    case 2:
                        TextColor.wl("I need just a number please.");
                        break;
                    case 3:
                        TextColor.wl("Can you please use just a number?");
                        break;
                    case 4:
                        TextColor.wl("I only want a number.");
                        break;
                }
            }
        }
        return num;
    }
}