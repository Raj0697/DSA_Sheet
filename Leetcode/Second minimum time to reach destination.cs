// Create adjacency list for the graph
        var adj = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++) {
            adj[i] = new List<int>();
        }
        foreach (var edge in edges) {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        // Initialize distance arrays
        int[] dist1 = new int[n + 1];
        int[] dist2 = new int[n + 1];
        for (int i = 1; i <= n; i++) {
            dist1[i] = -1;
            dist2[i] = -1;
        }

        // Queue for BFS
        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[] { 1, 1 }); // Start with node 1, with its minimum distance
        dist1[1] = 0;

        while (queue.Count > 0) {
            var temp = queue.Dequeue();
            int node = temp[0];
            int freq = temp[1];

            int timeTaken = freq == 1 ? dist1[node] : dist2[node];

            // If the current light is red, wait till the path turns green
            if ((timeTaken / change) % 2 == 1) {
                timeTaken = change * (timeTaken / change + 1) + time;
            } else {
                timeTaken = timeTaken + time;
            }

            foreach (var neighbor in adj[node]) {
                if (dist1[neighbor] == -1) {
                    dist1[neighbor] = timeTaken;
                    queue.Enqueue(new int[] { neighbor, 1 });
                } else if (dist2[neighbor] == -1 && dist1[neighbor] != timeTaken) {
                    if (neighbor == n)
                        return timeTaken;
                    dist2[neighbor] = timeTaken;
                    queue.Enqueue(new int[] { neighbor, 2 });
                }
            }
        }
        return 0; // If the second minimum distance is not found
