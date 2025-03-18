//< number >< char >
//for example, '2c' or '3a'.
using System.Text;

static string uncompress(string s)
{
    var result = new StringBuilder();
    var lastNumberIndex = 0;
    for (int i = 0; i < s.Length; i++) {
        if (!char.IsNumber(s[i])){
            var number = Convert.ToInt32(s.Substring(lastNumberIndex, i - lastNumberIndex));
            Console.WriteLine(number);
            result.Append(s[i], number);
            lastNumberIndex = i + 1;
        }
        else
        {
            continue;
        }
    }

    return result.ToString();
}

Console.WriteLine(uncompress("2c3a1t"));