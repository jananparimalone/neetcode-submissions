public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++) {
            char current = s[i];
            if(current=='[' || current=='{' || current=='(') {
                stack.Push(current);
            }
            else if (current==')' || current==']' || current=='}') {
                if (stack.Count == 0) return false;
                char last = stack.Pop();
                if (current == ')' && last != '(') return false;
                if (current == ']' && last != '[') return false;
                if (current == '}' && last != '{') return false;
            }
        }
        return stack.Count == 0;
    }
}