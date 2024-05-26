private const int MOD = 1000000007;

    public int CheckRecord(int n) {
        if (n == 1) return 3;  // "P", "L", "A"
        
        long[,,] dp = new long[n + 1, 2, 3]; // dp[length, number of 'A's, number of consecutive 'L's]
        
        dp[0, 0, 0] = 1; // Base case: an empty string is valid
        
        for (int i = 1; i <= n; i++) {
            for (int a = 0; a <= 1; a++) { // At most 1 'A'
                for (int l = 0; l < 3; l++) { // At most 2 consecutive 'L's
                    // Add 'P'
                    dp[i, a, 0] = (dp[i, a, 0] + dp[i - 1, a, l]) % MOD;
                    
                    // Add 'A'
                    if (a > 0) {
                        dp[i, a, 0] = (dp[i, a, 0] + dp[i - 1, a - 1, l]) % MOD;
                    }
                    
                    // Add 'L'
                    if (l < 2) {
                        dp[i, a, l + 1] = (dp[i, a, l + 1] + dp[i - 1, a, l]) % MOD;
                    }
                }
            }
        }
        
        long result = 0;
        
        for (int a = 0; a <= 1; a++) {
            for (int l = 0; l < 3; l++) {
                result = (result + dp[n, a, l]) % MOD;
            }
        }
        
        return (int)result;
    }
