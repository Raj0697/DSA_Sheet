public int FindTheCity(int n, int[][] edges, int distanceThreshold) 
    {
        var graph = new Dictionary<int, Dictionary<int, int>>();
        for(int i = 0; i < n; i++)
            graph[i] = new Dictionary<int,int>();
        
        foreach(var edge in edges)
        {
            int u = edge[0], v = edge[1], w = edge[2];
            graph[u][v] = w;
            graph[v][u] = w;
        }
        
        int min = n + 1, result = 0;
        for(int i = 0; i < n; i++)
        {
            int count = BFS(graph, distanceThreshold, i);
            if(count <= min)
            {
                min = count;
                result = i;
            }
        }
        
        return result;
    }
    
    private int BFS(Dictionary<int, Dictionary<int, int>> graph, int distanceThreshold, int node)
    {
        var queue = new Queue<int>();
        var visited = new Dictionary<int, int>();
        queue.Enqueue(node);
        visited[node] = 0;
        while(queue.Count != 0)
        {
            int curr = queue.Dequeue(), currDist = visited[curr];
            foreach(var kvp in graph[curr])
            {
                int neighbor = kvp.Key, dist = kvp.Value;
                if(currDist + dist <= distanceThreshold)
                {
                    if(!visited.ContainsKey(neighbor) || visited[neighbor] > currDist + dist)
                    {
                        visited[neighbor] = currDist + dist;
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }
        
        return visited.Count();
    }
