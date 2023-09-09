public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        List<char> magLetters = new List<char>();

        for (int i = 0; i < magazine.Length; i++)
        {
            magLetters.Add(magazine[i]);
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (magLetters.Contains(ransomNote[i]))
            {
                magLetters.Remove(ransomNote[i]);

                continue;
            }

            else
            {
                return false;
            }
        }

        return true;
    }
}