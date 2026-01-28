public class ArrayExercises4
{
    public static bool IsPalindrome(int[] input)
    {
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
