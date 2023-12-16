public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        HashSet<string> sourceCities = new HashSet<string>();
        Dictionary<string, int> destinationFreq = new Dictionary<string, int>();
        
        // Iterate through the paths and count source and destination cities
        foreach (var path in paths) {
            string source = path[0];
            string destination = path[1];
            
            sourceCities.Add(source);
            
            if (!destinationFreq.ContainsKey(destination)) {
                destinationFreq.Add(destination, 0);
            }
            destinationFreq[destination]++;
        }

        // Find the destination city that appears only once and is not in source cities
        foreach (var pair in destinationFreq) {
            if (pair.Value == 1 && !sourceCities.Contains(pair.Key)) {
                return pair.Key;
            }
        }

        return ""; // Return empty string if no such city found
    }
}