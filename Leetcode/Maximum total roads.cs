public class Solution {
    public long MaximumImportance(int n, int[][] roads) {
        int[][] counts = new int[n][];
        int[] importance = new int[n];
        long totalImportance = 0;

        for(int i = 0; i < n; i++) counts[i] = new int[2] {i, 0};

        for(int i = 0; i < roads.Length; i++)
        {
            counts[roads[i][0]][1]++;
            counts[roads[i][1]][1]++;
        }

        Array.Sort(counts, (p, q) => p[1].CompareTo(q[1]));

        for(int i = 0; i < counts.Length; i++) importance[counts[i][0]] = i + 1;

        for(int i = 0; i < roads.Length; i++)
        {
            totalImportance += importance[roads[i][0]] + importance[roads[i][1]];
        }

        return totalImportance;
    }
}
