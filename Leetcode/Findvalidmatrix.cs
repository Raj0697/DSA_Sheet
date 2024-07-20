int m = rowSum.Length, n = colSum.Length;
            int[][] grid = new int[m][];
            int i =0,j=0;
            for(int k = 0;k<grid.Length;k++)
            {
                grid[k] = new int[n];
            }
            while( i < m && j < n ){
                if(rowSum[i]<colSum[j])
                {
                    grid[i][j] = rowSum[i];
                    colSum[j] -= rowSum[i];
                    i++;
                }
                else if(rowSum[i]>=colSum[j])
                {
                    grid[i][j] = colSum[j];
                    rowSum[i] -= colSum[j];
                    j++;
                }
            }
            return grid;
