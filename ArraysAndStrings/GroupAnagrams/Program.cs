// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Hello, World!");
GroupAnagrams(new string[] { "a" });


static IList<IList<string>> GroupAnagrams(string[] strs)
{
    var anagrams = new Dictionary<string, List<string>>();

    for(int i = 0; i < strs.Length; i++)
    {
        var anagram = strs[i];
        var sortedAnagram =  String.Concat(anagram.OrderBy(character => character));

        if (anagrams.TryGetValue(sortedAnagram, out var anagramsList))
        {
            anagramsList.Add(strs[i]);
            anagrams[sortedAnagram] = anagramsList;
        }
        else
        {
            var anagramList = new List<string>(){ strs[i] };
            anagrams.Add(sortedAnagram, anagramList);
        }
    }

   var result = new List<IList<string>>();
   result.AddRange(anagrams.Select(x => x.Value));

    return result;
}