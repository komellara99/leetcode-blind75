public class IsValidSolution {
    public bool IsValid(string s) {
        if(s.Length%2 != 0) return false;

        Stack<char> stack = new Stack<char>();
        var dict = new Dictionary<char, char>{{ ')', '(' },{ '}', '{' },{ ']', '[' }};

        foreach(var p in s.ToCharArray()){
            if(dict.ContainsValue(p)){
                stack.Push(p);
                continue;
            }
            if(stack.Count == 0 || stack.Peek() != dict[p]) return false;
            stack.Pop();
        }
        return (stack.Count == 0);
    }
}

/*
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
   
   An input string is valid if:
   
   Open brackets must be closed by the same type of brackets.
   Open brackets must be closed in the correct order.
   Every close bracket has a corresponding open bracket of the same type.
    
   
   Example 1:
   
   Input: s = "()"
   
   Output: true
   
   Example 2:
   
   Input: s = "()[]{}"
   
   Output: true
   
   Example 3:
   
   Input: s = "(]"
   
   Output: false
   
   Example 4:
   
   Input: s = "([])"
   
   Output: true
 */