class Solution:
    def isPalindrome(self, s: str) -> bool:
        if s == "":
            return True  # empty string is a valid palindrome
        
        cleaned = ""
        s = s.lower()
        for c in s:
            if c.isalnum():
                cleaned += c
        
        return cleaned == cleaned[::-1]
