class Solution {
    // TC - O(n)
    public int concatenatedBinary(int nn) {
        int MOD = 1_000_000_007;
        long sum = 0;
        int length = 0;
        
        for(int i = 1; i <= nn; i++) {
            if((i & (i - 1)) == 0)
                length++;
            sum = ((sum << length) | i) % MOD;
        }
        
        return (int) sum;
    }
}
