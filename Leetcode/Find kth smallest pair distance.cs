int n = nums.Length, N = 1000000, sum = 0;
        var count = new int[N];
        for (int i = 0; i < n - 1; i++) 
            for (int j = i+1; j < n; j++)
                count[Math.Abs(nums[i] - nums[j])]++;
        
        for (int i = 0; i < N; i++) 
            if ((sum += count[i]) >= k) 
                return i;
        
        return 0;
