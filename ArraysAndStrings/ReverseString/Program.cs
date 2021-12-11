// See https://aka.ms/new-console-template for more information


ReverseString(new char[] { 'h', 'e', 'l','a', 'l', 'o' });

Console.WriteLine("Hello, World!");



static void ReverseString(char[] s)
{
    var helperPointerCount = 0;
    var array = new char[s.Length];

    var firstCounter = 0;
    var secondCounter = s.Length - 1;


    while(firstCounter < secondCounter)
    {
        var swapValue = s[secondCounter];

        s[secondCounter] = s[firstCounter];
        s[firstCounter] = swapValue;

        firstCounter++;
        secondCounter--;
    }    


    Console.WriteLine(string.Join(',', s));
}