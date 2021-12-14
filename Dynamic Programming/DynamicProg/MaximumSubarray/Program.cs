// See https://aka.ms/new-console-template for more information

var aox = MaxSubArray(new int[] { 5, 4, -1, 7, 8 });
Console.WriteLine("Hello, World!");

//[5,4,-1,7,8]
static int MaxSubArray(int[] nums)
{
    var maxSum = nums[0];
    var sum = 0;

    foreach (var currentNumber in nums)
    {
        sum += currentNumber; 

        if (currentNumber > sum)
            sum = currentNumber;

        if (sum > maxSum)
            maxSum = sum;
    }

    return maxSum;
}