static double maxValue(double[] numbers)
{
    var maxValue = numbers[0];
    for(int i = 0; i < numbers.Length; i++)
    {
        if(maxValue < numbers[i])
        {
            maxValue = numbers[i];
        }
    }
    // todo
    return maxValue;
}

Console.WriteLine(maxValue([6, 2, 1, 3, 14]));