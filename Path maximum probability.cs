var graph = new Dictionary<int, Dictionary<int, double>>();
        for(int i = 0; i < n; i++)
            graph[i] = new Dictionary<int, double>();
        
        for(int i = 0; i < edges.Length; i++)
        {
            int u = edges[i][0], v = edges[i][1];
            graph[u][v] = succProb[i];
            graph[v][u] = succProb[i];
        }
        
        var prob = new Dictionary<int, double>();
        for(int i = 0; i < n; i++)
            prob[i] = 0;
        prob[start] = 1.0;
        var queue = new Queue<int>();
        queue.Enqueue(start);

        while(queue.Count != 0)
        {
            var curr = queue.Dequeue();
            foreach(var edge in graph[curr])
            {
                int next = edge.Key;
                double p = edge.Value;
                if(prob[next] < (prob[curr] * p))
                {
                    queue.Enqueue(next);
                    prob[next] = prob[curr] * p;
                }
            }
        }
        
        return prob[end];
