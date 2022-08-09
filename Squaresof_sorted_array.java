package sde_sheet;

import java.util.Arrays;

public class Squaresof_sorted_array {
	public static void main(String[] args)
	{
		Squaresof_sorted_array sd = new Squaresof_sorted_array();
		int[] ar = {-4, -1, 0, 3, 10};
		sd.sortedSquares(ar);
		sd.printArray(ar);
		//System.out.print(sortedSquares(ar));
	}
	public static int[] sortedSquares(int[] nums) {
//        int[] ar = new int[nums.length];
//        int t;
//        for(int i=0; i<nums.length; i++) {
//            ar[i] = nums[i]*nums[i];
//        }
//        for(int i=0; i<ar.length-1; i++) {
//            for(int j=0; j<ar.length-i-1; j++) {
//                if(ar[j] > ar[j+1]) {
//                    t = ar[j];
//                    ar[j] = ar[j+1];
//                    ar[j+1] = t;
//                }
//            }
//        }
//        for(int i=0; i<ar.length; i++)
//            System.out.print(ar[i] + " ");
//            
//        return ar;
		int n=nums.length;
		for(int i=0;i<n;i++){
			nums[i]=nums[i]*nums[i];
		}

		Arrays.sort(nums);

		return nums;
    }
	void printArray(int arr[])
    {
        int n = arr.length;
        for (int i = 0; i < n; ++i)
            System.out.print(arr[i] + " ");
        System.out.println();
    }
}
