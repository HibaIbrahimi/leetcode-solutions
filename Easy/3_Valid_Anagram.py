from collections import Counter

class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        # Step 1: Clean s
        clean_s = ""
        s = s.lower()
        for c in s:
            if c.isalnum():
                clean_s += c

        # Step 2: Clean t
        clean_t = ""
        t = t.lower()
        for c in t:
            if c.isalnum():
                clean_t += c

        # Step 3:compare

        #It’s like a special dictionary that counts time appearing of each character in something
        return Counter(clean_s) == Counter(clean_t)
