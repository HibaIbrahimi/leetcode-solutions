using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        // Stack to keep track of opening brackets
        Stack<char> stack = new Stack<char>();
        // Loop through each character in the string
        foreach (char c in s)
        {
            // If it's an opening bracket, push to stack
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                // If it's a closing bracket, check if stack is empty
                if (stack.Count == 0)
                    return false;

                // Pop the last opening bracket and check if it matches
                char last = stack.Pop();
                if (
                    (c == ')' && last != '(')
                    || (c == '}' && last != '{')
                    || (c == ']' && last != '[')
                )
                {
                    return false;
                }
            }
        }
        // If stack is empty at the end, all brackets matched
        return stack.Count == 0;
    }
}
