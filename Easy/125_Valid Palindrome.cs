using System.Linq;
using System.Collections.Generic;

class Solution
{
    public bool IsPalindrome(string originalString)
    {
        string resultString = new string(
            originalString.Where(c => char.IsLetterOrDigit(c)).ToArray()
        );

        string sClean = resultString.ToLower();

        string reversed = new string(sClean.Reverse().ToArray());

        return sClean == reversed;
    }

    //another solution

    public bool IsPalindrome(string s)
    {
        var clean = s.ToLower().Where(x => char.IsLetterOrDigit(x));
        return clean.Reverse().SequenceEqual(clean);
    }

    //another one using stack and queue

    public bool IsPalindrome(string s)
    {
        Stack<char> stack = new Stack<char>();
        Queue<char> queue = new Queue<char>();

        foreach (char c in s.ToLower())
        {
            if (char.IsLetterOrDigit(c))
            {
                stack.Push(c);
                queue.Enqueue(c);
            }
        }

        while (queue.Count > 0)
        {
            if (queue.Dequeue() != stack.Pop())
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsValidPalindrome(string s)
    {
        if (s == null)
            return false;

        string clean = System.Text.RegularExpressions.Regex
            .Replace(s, @"[^a-zA-Z0-9]", "")
            .ToLower();

        int left = 0;
        int right = clean.Length - 1;

        while (left < right)
        {
            if (clean[left] != clean[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
