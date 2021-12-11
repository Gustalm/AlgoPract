// See https://aka.ms/new-console-template for more information
using System.Text;


var aox = Solution.MyAtoi(" - 91283472332");
Console.WriteLine("Hello, World!");


public static class Solution
{
    public static int MyAtoi(string s)
    {
        var numberString = new StringBuilder();
        var validChars = new List<char>() { '+', '-', '.' };
        var stopper = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (i == s.Length - 1 & !char.IsDigit(s[i]))
            {
                break;
            }

            if (s[i].Equals(' '))
            {
                continue;
            }

            if (!stopper && !char.IsDigit(s[i]) && !validChars.Contains(s[i]))
            {
                return 0;
            }

            if (char.IsDigit(s[i]) || validChars.Contains(s[i]))
            {
                numberString.Append(s[i]);
                stopper = true;
            }
            else if (stopper & numberString.Length > 0)
            {
                break;
            }
        }


        var longNumber = Convert.ToInt64(Math.Round(Double.Parse(numberString.ToString())));
        int result = 0;
        result = longNumber < int.MinValue ? int.MinValue : longNumber > int.MaxValue ? int.MaxValue : (int)longNumber;

        return result;
    }
}