//this is my first medium problem ever , happy to reach to this point !
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int currentSum = nums[0];
        int maxSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}

//explication
// exemple de leetcode meme nums = [-2,1,-3,4,-1,2,1,-5,4]

// Initialisation

// currentSum = nums[0] = -2
// maxSum = -2
// i = 1 → valeur = 1
// continuer ? → -2 + 1 = -1
// repartir ? → 1
// 👉 on prend le max → currentSum = 1
// 👉 maxSum = max(-2, 1) = 1

// i = 2 → valeur = -3
// continuer ? → 1 + (-3) = -2
// repartir ? → -3
// 👉 currentSum = -2
// 👉 maxSum = 1

// i = 3 → valeur = 4
// continuer ? → -2 + 4 = 2
// repartir ? → 4
// 👉 currentSum = 4
// 👉 maxSum = 4

// i = 4 → valeur = -1
// continuer ? → 4 + (-1) = 3
// repartir ? → -1
// 👉 currentSum = 3
// 👉 maxSum = 4

// i = 5 → valeur = 2
// continuer ? → 3 + 2 = 5
// 👉 currentSum = 5
// 👉 maxSum = 5

// i = 6 → valeur = 1
// continuer ? → 5 + 1 = 6
// 👉 currentSum = 6
// 👉 maxSum = 6 ✅

// (le reste ne dépasse pas 6)
