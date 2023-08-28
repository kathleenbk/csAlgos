// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int arrayLength = nums.Length;

        if (nums.Length < 2) return Array.Empty<int>();

        for (int i = 0; i < arrayLength; i++)
        {
            for (int j = i + 1; j < arrayLength; j++)
            {
                if (nums[i] + nums[j] == target) return new int[] { i, j };
            }
        }
        return Array.Empty<int>();
    }
}
