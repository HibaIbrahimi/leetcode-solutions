public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int length = 0;
        int i = s.Length - 1;

        // Ignorer les espaces à la fin
        while (i >= 0 && s[i] == ' ')
            i--;

        // Compter les caractères du dernier mot
        while (i >= 0 && s[i] != ' ')
        {
            length++;
            i--;
        }

        return length;
    }
}
