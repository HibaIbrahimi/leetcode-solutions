public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            set1.Add(nums1[i]);
        }

        HashSet<int> set2 = new HashSet<int>();
        for (int j = 0; j < nums2.Length; j++)
        {
            if (set1.Contains(nums2[j]))
            {
                set2.Add(nums2[j]);
            }
        }

        int[] result = new int[set2.Count];
        int k = 0;

        foreach (int x in set2)
        {
            result[k] = x;
            k++;
        }
        return result;
    }
}
