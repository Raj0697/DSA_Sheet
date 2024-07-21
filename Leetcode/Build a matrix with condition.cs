Dictionary<int, HashSet<int>> rowMap = new (), rowDepsMap = new (), colMap = new (), colDepsMap = new ();
        for (int i = 0; i < k; i++)
        {
            rowMap[i] = new ();
            rowDepsMap[i] = new ();
            colMap[i] = new ();
            colDepsMap[i] = new ();
        }

        FillData(rowConditions, rowMap, rowDepsMap);
        FillData(colConditions, colMap, colDepsMap);

        int[] rows = new int[k], cols = new int[k];
        if (Iterate(rowMap, rowDepsMap, rows) == false || Iterate(colMap, colDepsMap, cols) == false) return new int[0][];

        int[][] ans = new int[k][];
        for (int i = 0; i < k; i++) ans[i] = new int[k];
        for (int i = 0; i < k; i++) ans[rows[i]][cols[i]] = i + 1;

        return ans;

        void FillData(int[][] conditions, Dictionary<int, HashSet<int>> map, Dictionary<int, HashSet<int>> depsMap)
        {
            for (int i = 0; i < conditions.Length; i++)
            {
                map[conditions[i][0] - 1].Add(conditions[i][1] - 1);
                depsMap[conditions[i][1] - 1].Add(conditions[i][0] - 1);
            }
        }

        bool Iterate(Dictionary<int, HashSet<int>> map, Dictionary<int, HashSet<int>> depsMap, int[] res)
        {
            Queue<int> q = new ();
            foreach (var (num, deps) in depsMap)
            {
                if (deps.Count == 0) q.Enqueue(num);
            }

            if (q.Count == 0) return false;

            int index = 0;
            while (q.Count > 0)
            {
                int current = q.Dequeue();
                res[current] = index;

                foreach (var next in map[current])
                {
                    depsMap[next].Remove(current);
                    if (depsMap[next].Count == 0) q.Enqueue(next);
                }

                index++;
            }

            return index == k;
