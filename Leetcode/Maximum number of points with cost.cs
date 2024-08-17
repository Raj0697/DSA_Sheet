public long MaxPoints(int[][] points) {
        var prv = new long[points[0].Length];
        foreach(var p in points)
        {
            FindLocalMax(prv, p);
        }
        
        return prv.Max();
    }
    
    private void FindLocalMax(long[] prv, int[] cur)
    {
        var fromLeft = new long[cur.Length];
        var fromRight = new long[cur.Length];
        
        var len = cur.Length -1;
        for(var i = 0; i <= len; i++)
        {
            fromLeft[i] = i == 0 ? prv[0] : Math.Max(fromLeft[i-1]-1, prv[i]);
            fromRight[len - i] = len - i == len ? prv[len] : Math.Max(fromRight[len - i +1] - 1, prv[len - i]);
        }
        
        for(var i = 0; i < cur.Length; i++)
        {
            prv[i] = Math.Max(fromLeft[i], fromRight[i]) + cur[i];
        }
    }
