public class Solution 
{
    public int FindJudge(int n, int[][] trust) 
    {
        Dictionary<int, List<int>> trustGraph = new Dictionary<int, List<int>>();

        HashSet<int> candidates = new HashSet<int>();

        for (int i = 1; i <= n; i++)
        {
            trustGraph[i] = new List<int>();

            candidates.Add(i);
        }

        foreach (var pair in trust)
        {
            int personA = pair[0];
            int personB = pair[1];

            trustGraph[personA].Add(personB);

            candidates.Remove(personA);
        }

        if (candidates.Count != 1)
        {
            return -1;
        }

        int potentialJudge = candidates.First();

        foreach (var person in trustGraph.Keys)
        {
            if (person != potentialJudge && !trustGraph[person].Contains(potentialJudge))
            {
                return -1;
            }
        }

        return potentialJudge; 
    }
}