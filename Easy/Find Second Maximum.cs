public class ArrayExercises
{
    public static int SecondMaximum(int[] input)
    {
        if (input == null || input.Length < 2)
        {
            throw new ArgumentException("Array must contain at least 2 elements.");
        }

        int max1 = int.MinValue;
        int max2 = int.MinValue;

        for (int i = 0; i < input.Length; i++)
        {
            int x = input[i];

            if (x > max1)
            {
                max2 = max1;
                max1 = x;
            }
            else if (x > max2 && x != max1)
            {
                max2 = x;
            }
        }

        if (max2 == int.MinValue)
        {
            throw new InvalidOperationException("No second distinct maximum exists.");
        }

        return max2;
    }
}
