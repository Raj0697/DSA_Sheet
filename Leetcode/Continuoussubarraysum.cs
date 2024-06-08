public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        int prevSum = nums[0] % k;
        int currSum = 0;
        HashSet<int> prefixSum = new HashSet<int>();
        for (int i=1; i<nums.Length; i++)
        {
            currSum = (prevSum+nums[i])%k;
            if(currSum%k==0 || prefixSum.Contains(currSum))
                return true;
            if(!prefixSum.Contains(prevSum))
                prefixSum.Add(prevSum);
            prevSum = currSum;
        }
        return false;
    }
}
