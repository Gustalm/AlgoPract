static List<int> pairProduct(List<int> numbers, int target)
{
    var hashMap = new Dictionary<int, int>();
    for (int i = 0; i < numbers.Count; i++)
    {
        if (target % numbers[i] != 0)
        {
            continue;
        }

        var numberLeft = target / numbers[i];
        if (hashMap.ContainsKey(numberLeft)){
            return [i, hashMap[numberLeft]];
        }

        hashMap.Add(numbers[i], i);
    }

    return [];
}