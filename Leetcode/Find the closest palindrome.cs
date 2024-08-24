int len = n.Length;
        long num = Convert.ToInt64(n);
        bool even = len % 2 == 0;
        long left = Convert.ToInt64(n.Substring(0, even ? len/2 : len/2 + 1));
        IList<long> candidates = new List<long>();
        candidates.Add(getPalindrom(left, even));
        candidates.Add(getPalindrom(left + 1, even));
        candidates.Add(getPalindrom(left - 1, even));
        candidates.Add((long)Math.Pow(10, len - 1) - 1);
        candidates.Add((long)Math.Pow(10, len) + 1);
        long dif = long.MaxValue;
        long res = 0;
        for(int i = 0; i < candidates.Count; i ++) {
            long curdif = (long)Math.Abs(candidates[i] - num);
            if(curdif == 0) continue;
            if(curdif < dif) {
                dif = curdif;
                res = candidates[i];
            } else if(curdif == dif && candidates[i] < res) {
                res = candidates[i];
            }
        }
        return res.ToString();
    }
    public long getPalindrom(long left, bool even) {
        long res = left;
        if(!even) left /= 10;
        while(left > 0) {
            res = res * 10 + left % 10;
            left /= 10;
        }
        return res;
