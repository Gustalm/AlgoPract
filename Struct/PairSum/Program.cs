using static System.Runtime.InteropServices.JavaScript.JSType;

static List<int> pairSum(List<int> numbers, int target)
{
    var hashMap = new Dictionary<int, int>();
    for (int i = 0; i < numbers.Count; i++)
    {
        var numberLeft = target - numbers[i];
        if (hashMap.ContainsKey(numberLeft))
        {
            return [i, hashMap[numberLeft]];
        }
        else
        {
            hashMap.Add(numbers[i], i);
        }
    }

    return [];
}