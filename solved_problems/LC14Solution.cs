public class LongestCommonPrefixSolution {
    public string LongestCommonPrefix(string[] strs) {
        var result = "";
        if(strs.Length == 1) return strs[0];
        
        for(int i = 0; i < strs.Min(x=>x.Length); i++){
            var current = strs[0][i];
            for (int j = 1; j < strs.Length; j++){
                if(strs[j][i] != current) return result;
                if( j == strs.Length - 1) result += current;
            }
        }
        return result;
    }
}

/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
*/