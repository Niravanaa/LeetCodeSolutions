public class Solution {
    public string RemoveDuplicateLetters(string s) {
        // Create a stack to store the result characters.
        Stack<char> stack = new Stack<char>();

        // Create a boolean array to keep track of whether a character is already in the stack.
        bool[] inStack = new bool[26];

        // Create a frequency array to count the occurrence of each character in the string.
        int[] count = new int[26];
        foreach (char c in s) {
            count[c - 'a']++;
        }

        foreach (char c in s) {
            // Decrement the count of the current character.
            count[c - 'a']--;

            // Skip characters that are already in the stack.
            if (inStack[c - 'a']) {
                continue;
            }

            // Pop characters from the stack if they are greater than the current character
            // and if there are more occurrences of them in the future.
            while (stack.Count > 0 && c < stack.Peek() && count[stack.Peek() - 'a'] > 0) {
                inStack[stack.Pop() - 'a'] = false;
            }

            // Push the current character into the stack and mark it as inStack.
            stack.Push(c);
            inStack[c - 'a'] = true;
        }

        // Convert the stack to a char array and reverse it to get the correct order.
        char[] resultArray = stack.ToArray();
        Array.Reverse(resultArray);

        // Convert the char array to a string and return it.
        return new string(resultArray);
    }
}
