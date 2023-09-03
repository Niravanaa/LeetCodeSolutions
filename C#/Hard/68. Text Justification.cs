public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        IList<string> result = new List<string>();
        int startIndex = 0;

        while (startIndex < words.Length) {
            int endIndex = FindEndIndex(words, startIndex, maxWidth);
            result.Add(CreateLine(words, startIndex, endIndex, maxWidth));
            startIndex = endIndex + 1;
        }

        return result;
    }

    private int FindEndIndex(string[] words, int startIndex, int maxWidth) {
        int endIndex = startIndex;
        int currentWidth = words[startIndex].Length;

        while (endIndex + 1 < words.Length && currentWidth + 1 + words[endIndex + 1].Length <= maxWidth) {
            endIndex++;
            currentWidth += 1 + words[endIndex].Length;
        }

        return endIndex;
    }

    private string CreateLine(string[] words, int startIndex, int endIndex, int maxWidth) {
        StringBuilder line = new StringBuilder();

        if (startIndex == endIndex || endIndex == words.Length - 1) {
            // Left-justify for single-word lines or the last line
            for (int i = startIndex; i <= endIndex; i++) {
                line.Append(words[i]);
                if (i < endIndex)
                    line.Append(' ');
            }
            while (line.Length < maxWidth) {
                line.Append(' ');
            }
        } else {
            int totalSpaces = maxWidth;
            for (int i = startIndex; i <= endIndex; i++) {
                totalSpaces -= words[i].Length;
            }

            int gaps = endIndex - startIndex;
            int spacesPerGap = totalSpaces / gaps;
            int extraSpaces = totalSpaces % gaps;

            for (int i = startIndex; i <= endIndex; i++) {
                line.Append(words[i]);
                if (i < endIndex) {
                    for (int j = 0; j < spacesPerGap; j++) {
                        line.Append(' ');
                    }
                    if (extraSpaces > 0) {
                        line.Append(' ');
                        extraSpaces--;
                    }
                }
            }
        }

        return line.ToString();
    }
}
