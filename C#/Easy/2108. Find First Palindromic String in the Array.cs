public class Solution 
{
    public string FirstPalindrome(string[] words) 
    {
        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                return word;
            }
        }

        return "";
    }

    private bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
