// See https://aka.ms/new-console-template for more information
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var availableNums = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var valueLeftToTarget = target - nums[i];
            if (availableNums.TryGetValue(valueLeftToTarget, out var index))
            {
                return new int[] { i, index };
            }

            if (!availableNums.ContainsKey(nums[i]))
                availableNums.Add(nums[i], i);
        }

        return new int[2];
    }
}
