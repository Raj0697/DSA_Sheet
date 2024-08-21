int n = s.Length;
        int[,] dp = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            // Each single character needs one turn to print
            dp[i, i] = 1;
        }

        // Iterate over the length of the substrings
        for (int len = 2; len <= n; len++)
        {
            for (int i = 0; i <= n - len; i++)
            {
                int j = i + len - 1;
                dp[i, j] = len; // Initialize the maximum value for the current substring

                // Case 1: If the first and last characters are the same, reduce the turns
                if (s[i] == s[j])
                {
                    dp[i, j] = dp[i, j - 1];
                }

                // Case 2: Try all possible ways to split the substring and find the minimum turns
                for (int k = i; k < j; k++)
                {
                    dp[i, j] = Math.Min(dp[i, j], dp[i, k] + dp[k + 1, j]);
                }
            }
        }

        // The answer will be in the top-right cell of the DP array
        return dp[0, n - 1];
