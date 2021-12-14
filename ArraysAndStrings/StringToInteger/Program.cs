// See https://aka.ms/new-console-template for more information
using System.Text;


var aox = MyAtoi("-91283472332");
Console.WriteLine("Hello, World!");


static int MyAtoi(string s)
{
    var stringTrimmed = s.Trim();
    var numberString = new StringBuilder();

    for (int i = 0; i < stringTrimmed.Length; i++)
    {
        if(numberString.Length == 0 && (stringTrimmed[i] == '+' || stringTrimmed[i] == '-'))
        {   
            numberString.Append(stringTrimmed[i]);
            continue;
        }
        else      
        if (!char.IsDigit(stringTrimmed[i]) && stringTrimmed[i] != '.')
        {
            break;
        }

        numberString.Append(stringTrimmed[i]);
    }

    if(double.TryParse(numberString.ToString(), out var result))
    {
        if (result > int.MaxValue) return int.MaxValue;
        if (result < int.MinValue) return int.MinValue;

    };
    
    return Convert.ToInt32(Math.Round(result));
}
