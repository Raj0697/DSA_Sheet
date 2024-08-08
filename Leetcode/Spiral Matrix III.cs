List<int[]> result = new();
       int[,] directions = new int[,]{{0,1} ,{1,0},{0,-1},{-1,0}};
        int len =0;
        int d =0;
        result.Add(new int[]{rStart, cStart});

        while(result.Count < rows * cols)
        {
            //directions right---> or left <---, increase len++
            if(d==0 || d==2)
            {
                len++;
            }
            for(int k=0; k<len; k++)
            {
                rStart += directions[d,0];
                cStart += directions[d,1];
                if(rStart < rows && rStart >=0 && cStart < cols && cStart >=0)
                {
                    result.Add(new int[]{rStart, cStart});
                }
            }
            d= (d+1) % 4;
        }
        return result.ToArray();
