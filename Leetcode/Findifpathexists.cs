public class solution
{
public bool ValidPath(int n, int[][] edges, int start, int end) {
	var parents = Enumerable.Range(0, n).ToArray();
	int find(int u) => parents[u] == u ? u : parents[u] = find(parents[u]);
	Array.ForEach(edges, e => parents[find(e[0])] = find(e[1]));
	return find(start) == find(end);
}
}
