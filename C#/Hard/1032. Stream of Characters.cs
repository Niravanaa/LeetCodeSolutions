public class TrieNode
{
    public Dictionary<char, TrieNode> Children { get; private set; }
    public bool IsEndOfWord { get; set; }

    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
        IsEndOfWord = false;
    }
}

public class StreamChecker
{
    private TrieNode root;
    private List<char> queries;

    public StreamChecker(string[] words)
    {
        root = new TrieNode();
        queries = new List<char>();

        foreach (string word in words)
        {
            InsertReverse(word);
        }
    }

    private void InsertReverse(string word)
    {
        TrieNode current = root;
        char[] arr = word.ToCharArray();
        Array.Reverse(arr);

        foreach (char c in arr)
        {
            if (!current.Children.ContainsKey(c))
            {
                current.Children[c] = new TrieNode();
            }
            current = current.Children[c];
        }

        current.IsEndOfWord = true;
    }

    public bool Query(char letter)
    {
        queries.Add(letter);
        TrieNode current = root;

        for (int i = queries.Count - 1; i >= 0; i--)
        {
            char c = queries[i];
            if (current.Children.ContainsKey(c))
            {
                current = current.Children[c];
                if (current.IsEndOfWord)
                {
                    return true;
                }
            }
            else
            {
                break;
            }
        }

        return false;
    }
}