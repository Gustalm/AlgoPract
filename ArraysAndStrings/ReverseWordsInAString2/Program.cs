// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ReverseWords(new char[] { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' });

static void ReverseWords(char[] s)
{
    ReverseArray(s, 0, s.Length - 1);

    var indexLastSpace = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if(s[i] == ' ')
        {
            if(indexLastSpace == 0)
            {
                ReverseArray(s, 0, i-1);
                indexLastSpace = i;
            }
            else
            {
                ReverseArray(s, indexLastSpace + 1, i - 1);
                indexLastSpace = i;
            }
        }

        if(i == s.Length - 1 && indexLastSpace > 0)
        {
            ReverseArray(s, indexLastSpace + 1, i);
        }

        if (i == s.Length - 1 && indexLastSpace == 0)
        {
            ReverseArray(s, 0, i);
        }
    }
}


static void ReverseArray(char[] array, int firstIndex, int lastIndex)
{
    var firstPointer = firstIndex;
    var secondPointer = lastIndex;

    while (firstPointer < secondPointer)
    {
        var swapValue = array[firstPointer];

        array[firstPointer] = array[secondPointer];
        array[secondPointer] = swapValue;

        firstPointer++;
        secondPointer--;
    }
}


//Doesnt work leetcode, is  in-place, i.e. without allocating extra space.
//static void ReverseWords(char[] s)
//{
//    var valueString = new String(s);

//    var splitedString = valueString.Split(' ');

//    var reJoined = string.Join(' ', splitedString.Reverse());

//    s = reJoined.ToArray();
//}