// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var aox = SingleNumber(new int[] { 4, 1, 2, 1, 2 });

//static int SingleNumber(int[] nums)
//{
//    var numbers = new HashSet<int>();

//    for(int i = 0; i < nums.Length; i++)
//    {
//        if(numbers.TryGetValue(nums[i], out var result))
//        {
//            numbers.Remove(nums[i]);
//            continue;
//        }

//        numbers.Add(nums[i]);
//    }

//    return numbers.FirstOrDefault();
//}


static int SingleNumber(int[] nums)
{
    //Dictionary<int, int> numFrequency = new Dictionary<int, int>();
    int result = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        result ^= nums[i];
        /*if (!numFrequency.ContainsKey(nums[i]))
        {
            numFrequency.Add(nums[i], 1);
        }
        else
        {
            numFrequency[nums[i]] = numFrequency[nums[i]] + 1;
        }*/
    }

    //return numFrequency.FirstOrDefault(x => x.Value == 1).Key;
    return result;
}
