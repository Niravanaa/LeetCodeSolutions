public class Solution {
    public bool BuddyStrings(string s, string goal) {
        if (s.Length != goal.Length)
        {
            return false;
        }

        int differences = 0;

        List<int> indexes = new List<int>();

        for (int i = 0; i < s.Length; i++) 
        {
            if (differences > 2) 
            {
                return false;
            }

            if (s[i] != goal[i]) 
            {
                indexes.Add(i);

                differences++;
            }
        }

        // If there are no differing characters, check if s contains duplicate characters.
        if (differences == 0) 
        {
            HashSet<char> seen = new HashSet<char>();

            foreach (char c in s) 
            {
                if (seen.Contains(c)) 
                {
                    return true;
                }

                seen.Add(c);
            }

            return false;
        }

        if (differences == 2) 
        {
            int[] indexesArray = indexes.ToArray();

            char[] sFlipped = s.ToCharArray();

            char temp = sFlipped[indexesArray[0]];

            sFlipped[indexesArray[0]] = sFlipped[indexesArray[1]];

            sFlipped[indexesArray[1]] = temp;

            string flipped = new string(sFlipped);

            if (flipped == goal) 
            {
                return true;
            }
        }

        return false;
    }
}
