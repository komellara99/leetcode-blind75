public class IsPalindromeSolution2 {
    public bool IsPalindrome(string s) {
        var word = new string(s.ToLower().Where(char.IsLetterOrDigit).ToArray());

        var left = 0;
        var right = word.Length-1;

        while(left < right){
            if(word[left] != word[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}
/*
 * A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
   
   Given a string s, return true if it is a palindrome, or false otherwise.
 */