private static int ShortestPath(IDictionary<int, List<(int to, int weight)>> graph, int source, int target) {
        long[] result = Enumerable
            .Repeat(long.MaxValue, graph.Count)
            .ToArray();

        result[source] = 0;

        Queue<int> agenda = new Queue<int>();
        HashSet<int> visited = new() { source };

        agenda.Enqueue(source);

        while (agenda.Count > 0) {
            var node = agenda.Dequeue();

            visited.Remove(node);

            foreach (var next in graph[node]) {
                if (next.weight < 0)
                    continue;

                if (result[node] + next.weight < result[next.to]) {
                    result[next.to] = result[node] + next.weight;

                    if (visited.Add(next.to))
                        agenda.Enqueue(next.to);
                }
            }
        }

        return result[target] == long.MaxValue ? int.MaxValue : (int)result[target];
    }

    public int[][] ModifiedGraphEdges(int n, int[][] edges, int source, int destination, int target) {
        var graph = Enumerable
            .Range(0, n)
            .ToDictionary(i => i, i => new List<(int to, int weight)>());

        foreach (var edge in edges) {
            graph[edge[0]].Add((edge[1], edge[2]));
            graph[edge[1]].Add((edge[0], edge[2]));
        }

        int A = ShortestPath(graph, source, destination);

        if (A < target)
            return Array.Empty<int[]>();

        if (A == target) {
            foreach (var edge in edges)
                if (edge[2] == -1)
                    edge[2] = target + 1;

            return edges;
        }

        foreach (var edge in edges) {
            if (edge[2] != -1)
                continue;

            int a = edge[0];
            int b = edge[1];

            edge[2] = 1;

            graph[a].Remove((b, -1));
            graph[a].Add((b, 1));

            graph[b].Remove((a, -1));
            graph[b].Add((a, 1));

            int B = ShortestPath(graph, source, destination);

            if (B <= target) {
                edge[2] = 1 + target - B;

                foreach (var e in edges) {
                    if (e[2] < 0)
                        e[2] = target + 1; // <- will not be accepted if int.MaxValue is used
                }

                return edges;
            }
        }

        return Array.Empty<int[]>();
    }
