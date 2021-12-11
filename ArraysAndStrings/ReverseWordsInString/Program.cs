// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ReverseWords("  hello world  ");




static string ReverseWords(string s)
{
    var words = s.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x));

    return string.Join(' ', words.Reverse());
}



//static string ReverseWords2(string s)
//{
//    var words = s.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

//    var firstPointer = 0;
//    var secondPointer = words.Count() - 1;

//    while (firstPointer < secondPointer)
//    {
//        var helper = words[firstPointer];

//        words[firstPointer] = words[secondPointer];
//        words[secondPointer] = helper;

//        firstPointer++;
//        secondPointer--;
//    }



//    return string.Join(' ', words);
//}