public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int somme = n * (n + 1) / 2;
        int actual = nums.Sum();
        return somme - actual;
    }
}
