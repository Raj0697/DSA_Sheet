public int[] SortJumbled(int[] mapping, int[] nums) 
    {
        /*
          1. Convert all nums into mapped value.
          2. One Dic -> Mapped Value as Key = Value is the list of Nums.
          3. Sort by Keys asc
          4. Result is the list of key - values.       
        */
        var dic = new Dictionary<int, List<int>>();
        var mDic = new Dictionary<int, int>();

        foreach(var n in nums)
        {
            var m = 0;
            if(!mDic.ContainsKey(n))
                m = ProcessMappedValueByNum(mapping, n);
            else
                m = mDic[n]; 

            if(dic.ContainsKey(m))
              dic[m].Add(n);
            else
              dic.Add(m, new List<int>(){n});
        }

        //Sort the Key - asc
        var list = (from kv in dic orderby kv.Key ascending select kv.Key).ToList();

        var res = new List<int>();
        foreach(var x in list)
        {
            res.AddRange(dic[x]);
        }

        return res.ToArray();        
    }

    private int ProcessMappedValueByNum(int[] mapping, int n)
    {
        var res = 0;
        var c = 0;
        if(n <= 9)
          return mapping[n];

        while(n > 0)
        {
           var x = n % 10;
           x = (int)(Math.Pow(10, c)) * mapping[x];
           res = x + res; 
           n = n/10;
           c++;
        }
        
        return res;
    }
