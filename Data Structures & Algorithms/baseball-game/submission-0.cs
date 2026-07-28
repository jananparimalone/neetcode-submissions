public class Solution {
    public int CalPoints(string[] operations) {
        int newScore = 0;
        Stack<int> numbers = new Stack<int>();
        for(int i = 0; i < operations.Length; i++) {
            if(operations[i] == "+") {
                int top = numbers.Pop();
                int nextToTop = numbers.Peek();
                int current = top + nextToTop;
                numbers.Push(top);
                numbers.Push(current);
            }
            else if(operations[i] == "D") {
                numbers.Push(numbers.Peek() * 2);
            }
            else if(operations[i] == "C") {
                numbers.Pop();
            }
            else {
                numbers.Push(int.Parse(operations[i]));
            }
        }
        newScore = numbers.Sum();
        return newScore;
    }
}
