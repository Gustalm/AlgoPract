// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static bool IsValid(string s)
{
    var closingBracketsStack = new Stack<char>();

    for(int i =0; i< s.Length; i++)
    {
        switch (s[i])
        {
            case '(':
                closingBracketsStack.Push(')');
                break;
            case '{':
                closingBracketsStack.Push('}');
                break;
            case '[':
                closingBracketsStack.Push(']');
                break;
            default:
                if(closingBracketsStack.Count == 0 || !closingBracketsStack.Pop().Equals(s[i]))
                {
                    return false;
                }
                break;
        }
    }

    return closingBracketsStack.Count == 0;
}



//static bool IsValid(string s)
//{
//    var charStack = new Stack<char>();
//    var closeBrackets = new HashSet<char>() { ')', ']', '}' };


//    for (int i = 0; i < s.Length; i++)
//    {
//        if(IsOpenBracket(s[i]))
//        {
//            charStack.Push(s[i]);
//            continue;
//        }

//        if(charStack.TryPop(out var lastChar))
//        {
//            if(IsValidBracket(lastChar, s[i]))
//            {
//                continue;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        else
//        {
//            charStack.Push(s[i]);
//        }

//    }


//    return charStack.Count == 0;
//}


//static bool IsOpenBracket(char currentBracket)
//{
//    var openBrackets = new HashSet<char>() { '(', '[', '{' };

//    return openBrackets.Contains(currentBracket) ;
//}


// static bool IsValidBracket(char previousBracket, char currentBracket)
//{
//    var respectiveCloseBrackets = new Dictionary<char, char>() { { '(', ')' }, { '[', ']' }, { '{', '}' } };

//    if(!respectiveCloseBrackets.TryGetValue(previousBracket, out var correspondingCloseBracket))
//    {
//        return false;
//    }

//    return IsOpenBracket(currentBracket) || currentBracket.Equals(respectiveCloseBrackets[previousBracket]);
//}
