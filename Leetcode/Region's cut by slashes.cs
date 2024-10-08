private class Unions
        {
            private readonly int[] _parents;
            private readonly int[] _ranks;

            public Unions(int n)
            {
                _parents = new int[n];
                _ranks = new int[n];
                for (int i = 0; i < n; i++)
                {
                    _parents[i] = i;
                }
            }

            public int Find(int x)
            {
                if (x != _parents[x])
                {
                    x = Find(_parents[x]);
                }

                return _parents[x];
            }

            public bool Union(int x, int y)
            {
                int px = Find(x);
                int py = Find(y);
                if (px == py)
                {
                    return false;
                }

                if (_ranks[px] > _ranks[py])
                {
                    _parents[py] = px;
                    _ranks[px]++;
                }
                else
                {
                    _parents[px] = py;
                    _ranks[py]++;
                }

                return true;
            }
        }

        private static readonly ((int, int), (int, int))[] _directionsToJoints =
        {
            ((0,1), (2,0)), ((0, -1), (0,2)), ((1,0), (3,1)), ((-1,0), (1,3))
        };

        public int RegionsBySlashes(string[] grid)
        {
            int n = grid.Length;
            Unions sets = new Unions(n*n*4);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int cellLinearIdx = (i * n + j) * 4;
                    var c = grid[i][j];

                    if (c == ' ')
                    {
                        sets.Union(cellLinearIdx, cellLinearIdx + 1);
                        sets.Union(cellLinearIdx, cellLinearIdx + 2);
                        sets.Union(cellLinearIdx, cellLinearIdx + 3);
                    }
                    else if (c == '/')
                    {
                        sets.Union(cellLinearIdx, cellLinearIdx + 1);
                        sets.Union(cellLinearIdx + 2, cellLinearIdx + 3);
                    }
                    else
                    {
                        sets.Union(cellLinearIdx, cellLinearIdx + 3);
                        sets.Union(cellLinearIdx + 1, cellLinearIdx + 2);
                    }

                    foreach (var direction in _directionsToJoints)
                    {
                        int newI = i + direction.Item1.Item1;
                        int newJ = j + direction.Item1.Item2;

                        if (newI >= 0 && newI < n && newJ >= 0 && newJ < n)
                        {
                            int nextCellIdx = (newI * n + newJ) * 4;
                            sets.Union(cellLinearIdx + direction.Item2.Item1, nextCellIdx + direction.Item2.Item2);
                        }
                    }
                }
            }

            ISet<int> roots = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int cellLinearIdx = (i * n + j) * 4;
                    roots.Add(sets.Find(cellLinearIdx));
                    roots.Add(sets.Find(cellLinearIdx + 1));
                    roots.Add(sets.Find(cellLinearIdx + 2));
                    roots.Add(sets.Find(cellLinearIdx + 3));
                }
            }

            return roots.Count;
        }
