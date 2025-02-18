public class FizzBuzzSolution {
    public IList<string> FizzBuzz(int n) {
        var x = new string[n];
        for(int i = 0; i < n; i++){
            if((i+1) % 3 == 0) {
                x[i] = "Fizz"; 
            }
            if((i+1) % 5 == 0) {
                x[i] += "Buzz"; 
            }
            if(x[i] == null) {
                x[i] = (i+1).ToString();
            }
        }
        return x;
    }
}
/*
 * Given an integer n, return a string array answer (1-indexed) where:
   
   answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
   answer[i] == "Fizz" if i is divisible by 3.
   answer[i] == "Buzz" if i is divisible by 5.
   answer[i] == i (as a string) if none of the above conditions are true.
 */