package sde_sheet;

import java.util.Arrays;

public class Missing_number {
	
	public static void main(String[] args) {
		int[] ar = {0,1};
		missingNumber(ar);
		System.out.print(missingNumber(ar));
	}
	public static int missingNumber(int[] nums) {
//        Arrays.sort(nums);
//        int start=1, end = nums.length, mid=0;
//
//        while(start <= end) {
//            mid = start + (end - start) / 2;
//            if(nums[mid] != mid)
//                return mid;
//            else if(nums[mid] < mid){
//                end = mid-1;
//            }
//            else{
//                start = mid + 1;
//            }
//        }
//        return mid;
		int n = nums.length;
		int sum = (n) * (n + 1) / 2;
		for (int i = 0; i < n; i++) {
			sum -= nums[i];
		}
		return sum;
    }
}
