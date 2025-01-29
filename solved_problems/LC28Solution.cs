public class StrStrSolution {
    public int StrStr(string haystack, string needle) {
        if(haystack == needle) return 0;
        for (int i = 0; i <= (haystack.Length - needle.Length); i++){
            if(haystack.Substring(i, needle.Length) == needle) return i;
        }
        return -1;
    }
}

/*
 * Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
   
    
   
   Example 1:
   
   Input: haystack = "sadbutsad", needle = "sad"
   Output: 0
   Explanation: "sad" occurs at index 0 and 6.
   The first occurrence is at index 0, so we return 0.
   
   Example 2:
   
   Input: haystack = "leetcode", needle = "leeto"
   Output: -1
   Explanation: "leeto" did not occur in "leetcode", so we return -1.
 */