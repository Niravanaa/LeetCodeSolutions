public class MapSum {
    private TrieNode root;

    public MapSum() {
        root = new TrieNode();
    }

    public void Insert(string key, int val) {
        TrieNode node = root;

        foreach (char ch in key) {
            if (!node.Children.ContainsKey(ch)) {
                node.Children[ch] = new TrieNode();
            }
            node = node.Children[ch];
        }

        node.Value = val;
    }

    public int Sum(string prefix) {
        TrieNode node = root;

        foreach (char ch in prefix) {
            if (node.Children.ContainsKey(ch)) {
                node = node.Children[ch];
            } else {
                return 0;
            }
        }

        return SumValues(node);
    }

    private int SumValues(TrieNode node) {
        int sum = node.Value;

        foreach (var childNode in node.Children.Values) {
            sum += SumValues(childNode);
        }

        return sum;
    }

    private class TrieNode {
        public Dictionary<char, TrieNode> Children { get; private set; }
        public int Value { get; set; }

        public TrieNode() {
            Children = new Dictionary<char, TrieNode>();
            Value = 0;
        }
    }
}
