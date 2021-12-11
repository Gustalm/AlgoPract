// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

var aox = new Solution();
Console.Write(aox.IsPalindrome("A man, a plan, a canal: Panama"));
public class Solution
{ 
//less efficient
//    public bool IsPalindrome(string s)
//    {
//        var regex = new Regex("[^a-zA-Z0-9]");
//        var onlyAlphaNumericString = regex.Replace(s.ToLower(), "");
//        var stringReversed = new String(onlyAlphaNumericString.Reverse().ToArray());


//        return onlyAlphaNumericString.Equals(stringReversed);
//    }

    public bool IsPalindrome(string s)
    {
        var onlyAlphaNumericString = new String(s.ToLower().Where(x => char.IsLetterOrDigit(x)).ToArray());

        return onlyAlphaNumericString.Equals(new String(onlyAlphaNumericString.Reverse().ToArray()));
    }
}