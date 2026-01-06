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
}
