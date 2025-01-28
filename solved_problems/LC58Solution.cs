public class LengthOfLastWordSolution {
    public int LengthOfLastWord(string s) {
        var strings = s.Split(" ");
        var lastWord = strings.Length - 1;

        while (lastWord >= 0){
            if(strings[lastWord].Length > 0) return strings[lastWord].Length;
            lastWord--;
        }
        return 0;
    }
}

/*
 * Given a string s consisting of words and spaces, return the length of the last word in the string.
   
   A word is a maximal 
   substring
    consisting of non-space characters only.
   
    
   
   Example 1:
   
   Input: s = "Hello World"
   Output: 5
   Explanation: The last word is "World" with length 5.
   Example 2:
   
   Input: s = "   fly me   to   the moon  "
   Output: 4
   Explanation: The last word is "moon" with length 4.
   Example 3:
   
   Input: s = "luffy is still joyboy"
   Output: 6
   Explanation: The last word is "joyboy" with length 6.
 */