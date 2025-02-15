static bool anagrams(string s1, string s2)
{
    var hashMap1 = new Dictionary<char, int>();
    var hashMap2 = new Dictionary<char, int>();

    for (int i = 0; i < s1.Length; i++)
    {
        if (hashMap1.ContainsKey(s1[i]))
        {
            hashMap1[s1[i]]++;
        }
        else
        {
            hashMap1[s1[i]] = 1;
        }
    }

    for (int i = 0; i < s1.Length; i++)
    {
        if (hashMap2.ContainsKey(s1[i]))
        {
            hashMap2[s1[i]]++;
        }
        else
        {
            hashMap2[s1[i]] = 1;
        }
    }

    return hashMap1.Equals(hashMap2);
}