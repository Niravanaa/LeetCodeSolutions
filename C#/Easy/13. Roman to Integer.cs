public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanNumerals = new Dictionary<char, int>();

        int answer = 0;

        romanNumerals.Add('I', 1);
        romanNumerals.Add('V', 5);
        romanNumerals.Add('X', 10);
        romanNumerals.Add('L', 50);
        romanNumerals.Add('C', 100);
        romanNumerals.Add('D', 500);
        romanNumerals.Add('M', 1000);

        for (int i = 0; i < s.Length; i++)
        {
            if (i == s.Length - 1)
            {
                answer += romanNumerals[s[i]];
                
                break;
            }

            if (s[i] == 'I')
            {
                if (s[i + 1] == 'V')
                {
                    answer += 4;

                    i++;

                    continue;
                }

                if (s[i + 1] == 'X')
                {
                    answer += 9;

                    i++;

                    continue;
                }
            }

            if (s[i] == 'X')
            {
                if (s[i + 1] == 'L')
                {
                    answer += 40;

                    i++;

                    continue;
                }

                if (s[i + 1] == 'C')
                {
                    answer += 90;
                    
                    i++;

                    continue;
                }
            }

            if (s[i] == 'C')
            {
                if (s[i + 1] == 'D')
                {
                    answer += 400;

                    i++;

                    continue;
                }

                if (s[i + 1] == 'M')
                {
                    answer += 900;

                    i++;
                    
                    continue;
                }
            }

            answer += romanNumerals[s[i]];

        }

        return answer;
    }
}