// See https://aka.ms/new-console-template for more information

LongestPalindrome("baAb");
Console.WriteLine("Hello, World!");


static string LongestPalindrome(string s)
{

    for (int i = 0; i < s.Length; i++)
    {
        var len1 = LongesPalindromExtendingFromMidle(s, i, i + 1);
        var len2 = LongesPalindromExtendingFromMidle(s, i, i);

    }

    return String.Empty;
}


static int LongesPalindromExtendingFromMidle(string s, int start, int end)
{
    if (string.IsNullOrEmpty(s) || end < start)
        return 0;

    var palindromes = new List<string>();
    string longestPalindrome = string.Empty;

    while (start >= 0 && end < s.Length && s[start] == s[end])
    {
        start--;
        end++;
    }

    return end - start - 1;
}
