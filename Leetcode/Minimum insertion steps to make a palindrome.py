class Solution(object):
   def minInsertions(self, s):
        n = len(s)
        dp = [[0] * (n + 1) for i in xrange(n + 1)]
        for i in xrange(n):
            for j in xrange(n):
                dp[i + 1][j + 1] = dp[i][j] + 1 if s[i] == s[~j] else max(dp[i][j + 1], dp[i + 1][j])
        return n - dp[n][n]
