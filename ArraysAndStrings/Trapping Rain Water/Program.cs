// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



static int Trap(int[] height)
{
    for(int i=0; i < height.Length; i++)
    {

    }

    return 0;
}


static void ExpandFromMidle(int[] height, int start, int end)
{
    while (start >= 0 && end < height.Length)
    {
        start--;
        end++;
    }
}