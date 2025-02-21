public class ReverseStrSolution {
    public string ReverseStr(string s, int k) {
        var index = 0;
        char[] charArray = s.ToCharArray();
        while (true){
            if(index >= s.Length) break;
            var end = Math.Min(k, s.Length - index);;
            Array.Reverse(charArray, index, end);
            index += 2*k;
        }
        return new string(charArray);
    }

}

/*
 * Given a string s and an integer k, reverse the first k characters for every 2k characters counting from the start of the string.
   
   If there are fewer than k characters left, reverse all of them. If there are less than 2k but greater than or equal to k characters, then reverse the first k characters and leave the other as original.
 */