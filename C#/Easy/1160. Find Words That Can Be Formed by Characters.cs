public class Solution {
    public int CountCharacters(string[] words, string chars) 
    {
        Dictionary<char, int> availableChars = GetCharFrequency(chars);

        int result = 0;

        foreach (string word in words) 
        {
            Dictionary<char, int> wordFreq = GetCharFrequency(word);

            bool canFormWord = true;

            foreach (var kvp in wordFreq) 
            {
                if (!availableChars.ContainsKey(kvp.Key) || availableChars[kvp.Key] < kvp.Value) 
                {
                    canFormWord = false;
                    break;
                }
            }

            if (canFormWord) 
            {
                result += word.Length;
            }
        }

        return result;
    }

    private Dictionary<char, int> GetCharFrequency(string str) 
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char c in str) 
        {
            if (frequency.ContainsKey(c)) 
            {
                frequency[c]++;
            } 
            
            else
            {
                frequency[c] = 1;
            }
        }

        return frequency;
    }
}
