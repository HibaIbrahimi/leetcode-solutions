public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        int i = 0; // Slow pointer to track the last unique element

        for (int j = 1; j < nums.Length; j++)
        { // Fast pointer
            if (nums[j] != nums[i])
            {
                i++; // Move slow pointer
                nums[i] = nums[j]; // Update the next unique element
            }
        }

        // The number of unique elements is i + 1
        return i + 1;
    }
}
