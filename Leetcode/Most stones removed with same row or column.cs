var visited = new HashSet<int[]>();
        var qu = new Queue<int[]>();
        int res = 0;
        foreach(var item in stones)
        {
            if (visited.Contains(item)) continue;
            res++;
            qu.Enqueue(item);
            while(qu.Count > 0)
            {
                var q = qu.Dequeue();
                visited.Add(q);
                foreach(var v in stones.Where (x => x[0] == q[0] || x[1] == q[1]))
                {
                    if (!visited.Contains(v)) qu.Enqueue(v);
                }
            }
        }
        return stones.Length - res;
