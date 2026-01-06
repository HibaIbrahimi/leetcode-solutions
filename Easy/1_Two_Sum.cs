public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[0];
    }
}

/////using hash Map

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>(); // A mapping to store numbers and their indices
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i]; // Find the required number to reach the target
            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i }; // Return indices of the complement and current number
            }
            numMap[nums[i]] = i; // Store the number with its index
        }
        return new int[] { }; // This line is never reached due to the problem guarantee
    }
}
