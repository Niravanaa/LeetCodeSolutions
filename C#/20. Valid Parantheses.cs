public class Solution {
    public bool IsValid(string s) {
        if (s.Length == 1)
        {
            return false;
        }

        Stack st = new Stack();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '}')
            {
                if (st.Count == 0 || (char) st.Peek() != '{')
                {
                    return false;
                }
                
                st.Pop();
            }
            else if (s[i] == ']')
            {
                if (st.Count == 0 || (char) st.Peek() != '[')
                {
                    return false;
                }
                
                st.Pop();
            }
            else if (s[i] == ')')
            {
                if (st.Count == 0 || (char) st.Peek() != '(')
                {
                    return false;
                }
                
                st.Pop();
            }
            else
            {
                st.Push(s[i]);
            }
        }

        return st.Count == 0;
    }
}
