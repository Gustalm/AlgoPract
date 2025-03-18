static string longestWord(string sentence)
{
    var words = sentence.Split(' ');
    var biggestWord = "";
    for (int i = 0; i <= words.Length; i++)
    {
        if (words[i].Length >= biggestWord.Length)
        {
            biggestWord = words[i];
        }
    }

    return biggestWord;
}
