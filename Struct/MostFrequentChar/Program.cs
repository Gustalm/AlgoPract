static char mostFrequentChar(string s)
{
    var hashCount = new Dictionary<char, int> { { s[0], 1 } };
    for(int i = 1; i < s.Length; i++)
    {
        if (hashCount.ContainsKey(s[i]))
        {
            hashCount[s[i]]++;
        }
        else
        {
            hashCount[s[i]] = 1;
        }
    }

    var mostFrequent = '\0';
    for (int i = 0; i < s.Length; i++)
    {
        if (mostFrequent == '\0' || hashCount[s[i]] > hashCount[mostFrequent])
        {
            mostFrequent = s[i];
        }
    }

    Console.WriteLine(mostFrequent);
    return mostFrequent;
}

mostFrequentChar("mississippi");