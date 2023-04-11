class Words
{
    public static int words(string sentence)
    {
        int wordcount = sentence.Split(' ').Length;
        return wordcount;
    }
}