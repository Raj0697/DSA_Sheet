public class Solution {
    public int SubsetXORSum(int[] nums) {
        int or = 0;

        foreach (int num in nums)
        {
            or |= num;
        }

        return or << (nums.Length - 1);
    }
}
