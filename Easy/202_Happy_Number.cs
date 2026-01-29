using System.Collections.Generic;

public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();

        while (n != 1)
        {
            if (seen.Contains(n))
            {
                return false; // boucle détectée
            }

            seen.Add(n);
            n = Next(n);
        }

        return true;
    }

    private int Next(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n = n / 10;
        }

        return sum;
    }
}
